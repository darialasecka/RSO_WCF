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

        static List<Connection> connections = new List<Connection>();
        static HashSet<string> cities = new HashSet<string>();

        public void Initialize()
        {

            using (var reader = new StreamReader("D:\\Studia\\SEM 6\\RSO\\WcfService\\planes.csv"))
            {

                if (!reader.EndOfStream) reader.ReadLine(); //pierwszą ignorujemy, bo są nazwy tabel
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';'); //excel zapisał zamiast oddzielonego , to oddzielony ;
                    //0- start, 1- start time, 2- end, 3- end time

                    DateTime departure = DateTime.Parse(values[1]);
                    DateTime arrival = DateTime.Parse(values[3]);

                    Connection conn = new Connection(values[0], departure, values[2],arrival);

                    connections.Add(conn);

                    cities.Add(values[0].ToString().Trim().ToUpper());
                    cities.Add(values[2].ToString().Trim().ToUpper());

                }
            }
        }

        public HashSet<string> GetDataDirect(string startCity, string endCity, DateTime departure, DateTime arrival)
        {
            HashSet<string> direct = new HashSet<string>();
            //int connections_counter = 0;
            foreach (Connection conn in connections)
            {
                if (conn.StartCity.Equals(startCity) && conn.EndCity.Equals(endCity) && (conn.Departure >= departure) && (conn.Arrival <= arrival))
                {

                    direct.Add(conn.ToString());
                    //connections_counter ++;
                }
            }

            return direct;
            /*if (connections_counter == 0) return "Connection doesn't exist";
            else return string.Format("connections counter: {0}", connections_counter);*/ //return string.Format("start {0}, end {1}\n start datetime {2}, end datetime {3}", startCity, endCity, departure, arrival);
        }

        public bool CityExists(string city)
        {
            return cities.Contains(city);
        }

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
