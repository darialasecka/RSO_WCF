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

        ServiceReference.ServiceClient service;

        public Form1()
        {
            service = new ServiceReference.ServiceClient();

            InitializeComponent();

            Output.Text = service.Initialize(); //jest tu do testów, bo w konsoli się nie chce wypisać
        }

        private void ok_button_Click(object sender, EventArgs e)
        {

            string startCity = startCityInput.Text;
            string endCity = endCityInput.Text;

            DateTime departure = DepartureDatePicker.Value.Date + DepartureTimePicker.Value.TimeOfDay;
            DateTime arrival = ArrivalDatePicker.Value.Date + ArrivalTimePicker.Value.TimeOfDay;

            //validation
            if (String.IsNullOrEmpty(startCity))
            {
                MessageBox.Show("Starting city is empty", "Incorrect Input");
            }

            if (String.IsNullOrEmpty(endCity))
            {
                MessageBox.Show("Ending city is empty", "Incorrect Input");
            }


            if (departure > arrival)
            {
                MessageBox.Show("Departure time must be before arrival", "Incorrect Input");
            }


            string output = service.GetData(startCity, endCity, departure, arrival);

            Output.Text = output;

        }
    }
}
