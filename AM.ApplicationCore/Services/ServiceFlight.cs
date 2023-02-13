using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ServiceFlight : IServiceFlight
    {
        //TP2-Q3: Créer la propriété Flights et l’initialiser à une liste vide
        public List<Flight> Flights { get; set; } = new List<Flight>();

        //TP2-Q6: Implémenter la méthode GetFlightDates(string destination)
        public List<DateTime> GetFlightDates(string destination)
        {
            List<DateTime> ls = new List<DateTime>();
            for (int j = 0; j < Flights.Count; j++)
                if (Flights[j].Destination.Equals(destination))
                    ls.Add(Flights[j].FlightDate);
            return ls;
            ////TP2-Q7: Reformuler la requête avec foreach
            //List<DateTime> ls = new List<DateTime>();
            //foreach (Flight f in Flights)
            //    if (f.Destination.Equals(destination))
            //        ls.Add(f.FlightDate);
            //return ls;

            ////TP2-Q9: Reformuler la méthode en utilisant LINQ
            
        }

        public IEnumerable<DateTime> GetFlightdates(string Destination)
        {
            var query = from flight in Flights
                        where flight.Destination == Destination
                        select flight.FlightDate;
            return query;
        }



        //TP2-Q8: Implémenter la méthode GetFlights(string filterType, string filterValue)
        public void GetFlights(string filterType, string filterValue)
        {
            switch (filterType)
            {
                case "Destination":
                    foreach (var item in Flights)
                    {
                        if (item.Destination == filterValue)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    break;
                case "FlightDate":
                    foreach (var item in Flights)
                    {
                        if (item.FlightDate == DateTime.Parse(filterValue))
                        {
                            Console.WriteLine(item);
                        }
                    }
                    break;
                case "Departure":
                    foreach (var item in Flights)
                    {
                        if (item.Departure == filterValue)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    break;
                case "FlightID":
                    foreach (var item in Flights)
                    {
                        if (item.FlightId == int.Parse(filterValue))
                        {
                            Console.WriteLine(item);
                        }
                    }
                    break;

            }

        }


        
        }
    }
