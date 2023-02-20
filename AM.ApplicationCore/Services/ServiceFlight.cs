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

        public void ShowFlightDetails(Plane plane)
        {
            var query = from flight in Flights
                        where flight.Plane == plane
                        select flight;
            foreach (var item in query)
            {
                Console.WriteLine(item.FlightDate);
                Console.WriteLine(item.Destination);
            }
        }

        public IEnumerable<Flight> OrderedDurationFlights()
        {
            var query = from flight in Flights
                        orderby flight.EstimatedDuration descending
                        select flight;
            return query;
        }

        public IEnumerable<Traveller> SeniorTravellers(Flight flight)
        {
            var query = from traveller in flight.Passengers.OfType<Traveller>()
                        orderby traveller.BirthDate
                        select traveller;
            return query.Take(3);
        }


        public void DestinationGroupedFlights()
        {
            var query = from flight in Flights
                        group flight by flight.Destination;
            foreach (var group in query)
            {
                Console.WriteLine("Destination" + " : " + group.Key);
                foreach (var item in group)
                {
                    Console.WriteLine("Decollage" + " : " + item.FlightDate);
                }
            }
        }


        public double DurationAverage(string Destination)
        {
            var query = from flight in Flights
                        where flight.Destination == Destination
                        select flight.EstimatedDuration;
            return query.Average();
        }


        public Action<Plane> FlightDetailsDel;
        public Func<String, double> DurationAverageDel;


        public ServiceFlight()
        {
            //FlightDetailsDel = ShowFlightDetails;
            //DurationAverageDel =DurationAverage;


            FlightDetailsDel = p =>
            {
                var query = from flight in Flights
                            where flight.Plane == Plane
                            select flight;
                foreach (var item in query)
                {
                    Console.WriteLine(item.FlightDate);
                    Console.WriteLine(item.Destination);
                }
            };
        }

    }
}
