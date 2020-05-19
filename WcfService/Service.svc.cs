using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService
{
    // UWAGA: możesz użyć polecenia „Zmień nazwę” w menu „Refaktoryzuj”, aby zmienić nazwę klasy „Service1” w kodzie, usłudze i pliku konfiguracji.
    // UWAGA: aby uruchomić klienta testowego WCF w celu przetestowania tej usługi, wybierz plik Service1.svc lub Service1.svc.cs w eksploratorze rozwiązań i rozpocznij debugowanie.
    public class Service : IService
    {

        List<Connection> connections = new List<Connection>();
        //HashSet<string> cities = new HashSet<string>();
        List<string> cities = new List<string>();

        public string Initialize()
        {

            using (var reader = new StreamReader("D:\\Studia\\SEM 6\\RSO\\WcfService\\planes.csv"))
            {

                if (!reader.EndOfStream) reader.ReadLine(); //pierwszą ignorujemy, bo są nazwy tabel
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';'); //excel zapisał zamiast oddzielonego , to oddzielony ;

                    Console.WriteLine(values);
                    //0- start, 1- start time, 2- end, 3- end time

                    DateTime departure = DateTime.Parse(values[1]);
                    DateTime arrival = DateTime.Parse(values[3]);

                    Connection conn = new Connection(values[0], departure, values[2],arrival);

                    connections.Add(conn);

                    cities.Add(values[0]);
                    cities.Add(values[2]);

                }
            }
            return connections[0].ToString(); //test
        }

        public string GetData(string startCity, string endCity, DateTime departure, DateTime arrival)
        {
            if (cities.Contains(startCity)) return "Tek";
            return string.Format("start {0}, end {1}\n start datetime {2}, end datetime {3}", startCity, endCity, departure, arrival);
        }

        public bool CityExists(string city) //to w sumie też nie działa
        {
            cities = cities.Distinct().ToList();
            foreach(string town in cities)
            {
                if (town.Equals(city)) return true;
            }
            return false;
        }

        /*public bool CityExists(string city) //nie działa
        {
            return cities.Contains(city);
        }*/

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        
    }
}
