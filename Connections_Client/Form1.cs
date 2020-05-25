using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfService;

namespace Connections_Client
{
    public partial class Form1 : Form
    {

        ServiceReference.ServiceClient client;

        public Form1()
        {

            InitializeComponent();
            try
            {
                Service service = new Service(); // starts service
                client = new ServiceReference.ServiceClient(); //connects client
                client.Initialize();
            } catch (CommunicationException) //zanim się połączy
            {
                MessageBox.Show("Coundn't connect to service", "Connection Error");
            }
            
        }

        private void ok_button_Click(object sender, EventArgs e)
        {

            bool incorrect_input = false;

            string startCity = startCityInput.Text;
            string endCity = endCityInput.Text;

            DateTime departure = DepartureDatePicker.Value.Date + DepartureTimePicker.Value.TimeOfDay;
            DateTime arrival = ArrivalDatePicker.Value.Date + ArrivalTimePicker.Value.TimeOfDay;

            //validation
            if (String.IsNullOrEmpty(startCity))
            {
                MessageBox.Show("Starting city is empty", "Incorrect Input");
                incorrect_input = true;
            }

            if (String.IsNullOrEmpty(endCity))
            {
                MessageBox.Show("Ending city is empty", "Incorrect Input");
                incorrect_input = true;
            }

            if (departure > arrival)
            {
                MessageBox.Show("Departure time must be before arrival", "Incorrect Input");
                incorrect_input = true;
            }

            if (!client.CityExists(startCity)) //ok, nie działa
            {
                MessageBox.Show("Starting city [" + startCity + "] doesn't exists", "Incorrect Input");
                incorrect_input = true;
            }
            
            if (!client.CityExists(endCity))
            {
                MessageBox.Show("Ending city [" + endCity + "] doesn't exists", "Incorrect Input");
                incorrect_input = true;
            }

            //show after validating everything
            if (!incorrect_input)
            {
                //direct connections
                HashSet<string> direct = new HashSet<string>();
                try
                {
                    direct = client.GetDataDirect(startCity, endCity, departure, arrival).ToHashSet();
                }
                catch (FaultException) //w trakcie wykonywania programu
                {
                    MessageBox.Show("Lost connection to service", "Connection Error");
                }
                
                DirectListView.Items.Clear();

                if (direct.Count() == 0)
                {
                    var lvi = new ListViewItem("Direct connections doesn't exist");
                    DirectListView.Items.Add(lvi);
                }
                else
                {
                    foreach (string conn in direct)
                    {
                        var lvi = new ListViewItem(conn);
                        DirectListView.Items.Add(lvi);
                    }
                }


                //indirect connections
                HashSet<string> indirect = new HashSet<string>();
                try
                {
                    indirect = client.GetDataIndirect(startCity, endCity, departure, arrival).ToHashSet();
                }
                catch (FaultException) //w trakcie wykonywania programu
                {
                    MessageBox.Show("Lost connection to service", "Connection Error");
                }

                IndirectListView.Items.Clear();

                if (indirect.Count() == 0)
                {
                    IndirectListView.Items.Add("Indirect connections doesn't exist");
                }
                else
                {
                    foreach (string conn in indirect)
                    {
                        IndirectListView.Items.Add(conn);
                    }
                }

            }

        }
    }
}
