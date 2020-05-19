using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connections_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ok_button_Click(object sender, EventArgs e)
        {

            ServiceReference.ServiceClient service = new ServiceReference.ServiceClient();

            string startCity = startCityInput.Text;
            string endCity = endCityInput.Text;

            DateTime departure = DepartureDatePicker.Value.Date + DepartureTimePicker.Value.TimeOfDay;
            DateTime arrival = ArrivalDatePicker.Value.Date + ArrivalTimePicker.Value.TimeOfDay;

            
            string output = service.GetData(startCity, endCity, departure, arrival);

            Output.Text = output;

        }
    }
}
