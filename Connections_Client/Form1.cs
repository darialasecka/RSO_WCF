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

namespace Connections_Client
{
    public partial class Form1 : Form
    {

        ServiceReference.ServiceClient service;

        public Form1()
        {
            try
            {
                service = new ServiceReference.ServiceClient();
            } catch (CommunicationException) //zanim się połączy
            {
                MessageBox.Show("Coundn't connect to service", "Connection Error");
            }

            InitializeComponent();

            try
            {
                Output.Text = service.Initialize(); //przypisanie jest tu do testów, bo w konsoli się nie chce wypisać
            } catch (FaultException) //w trakcie wykonywania programu
            {
                MessageBox.Show("Couldn't connect to service", "Connection Error");
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

            if (!service.CityExists(startCity)) //ok, nie działa
            {
                MessageBox.Show("Starting city [" + startCity + "] doesn't exists", "Incorrect Input");
                incorrect_input = true;
            }
            
            if (!service.CityExists(endCity))
            {
                MessageBox.Show("Ending city [" + endCity + "] doesn't exists", "Incorrect Input");
                incorrect_input = true;
            }

            //show after validating everything
            if (!incorrect_input)
            {
                string output = service.GetData(startCity, endCity, departure, arrival);

                Output.Text = output; //zmienimy text na coś innego


            }

            

        }
    }
}
