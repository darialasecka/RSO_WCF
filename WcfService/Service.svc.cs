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
                    var values = line.Split(',');
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
            if (!CityExists(startCity))
            {
                throw new ArgumentException("Starting city [" + startCity + "] doesn't exists.");
            }
            if (!CityExists(endCity))
            {
                throw new ArgumentException("Ending city [" + endCity + "] doesn't exists.");
            }
            if (departure > arrival)
            {
                throw new ArgumentException("Departure time must be before arrival.");
            }

            HashSet<string> direct = new HashSet<string>();
            foreach (Connection conn in connections)
            {
                if (conn.StartCity.Equals(startCity) && conn.EndCity.Equals(endCity) && (conn.Departure >= departure) && (conn.Arrival <= arrival))
                {
                    direct.Add(conn.ToString());
                }
            }
            //if(direct.Count() == 0) throw new KeyNotFoundException("Direct connections doesn't exist");
            return direct;
        }

        public HashSet<string> GetDataIndirect(string startCity, string endCity, DateTime departure, DateTime arrival)
        {
            if (!CityExists(startCity))
            {
                throw new ArgumentException("Starting city [" + startCity + "] doesn't exists.");
            }
            if (!CityExists(endCity))
            {
                throw new ArgumentException("Ending city [" + endCity + "] doesn't exists.");
            }
            if (departure > arrival)
            {
                throw new ArgumentException("Departure time must be before arrival.");
            }

            HashSet<string> indirect = new HashSet<string>();
            HashSet<string> transfer = new HashSet<string>();
            foreach (Connection start in GetAllConnectionsFrom(startCity, departure))
            {
                transfer.Add(start.ToString());
                Connection prevCity = start;
                foreach (Connection nextCity in GetAllConnectionsFrom(prevCity.EndCity, prevCity.Arrival))
                {
                    if (nextCity.Arrival <= arrival)
                    {
                        transfer.Add(" --> " + nextCity.EndCity + " [" + nextCity.Arrival + "]");
                        if (nextCity.EndCity.Equals(endCity))
                        {
                            string connection = "";
                            foreach (string city in transfer)
                                connection += city;

                            indirect.Add(connection);

                            break;
                        }
                        prevCity = nextCity;
                    }
                }
                transfer = new HashSet<string>();
            }
            //if (indirect.Count() == 0) throw new KeyNotFoundException("Inirect connections doesn't exist");
            return indirect;

        }

        public HashSet<Connection> GetAllConnectionsFrom(string startCity, DateTime departure)
        {
            HashSet<Connection> connectionsFrom = new HashSet<Connection>();

            foreach(Connection from in connections)
            {
                if (from.StartCity.Equals(startCity) && (from.Departure >= departure))
                {
                    connectionsFrom.Add(from);
                }
            }
            return connectionsFrom;
        }

        public bool CityExists(string city)
        {
            return cities.Contains(city);
        }
        
    }
}
