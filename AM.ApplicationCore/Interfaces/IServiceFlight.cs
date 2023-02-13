using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interfaces
{
    public interface IServiceFlight
    {
        List<DateTime> GetFlightDates(string destination);
        void GetFlights(string filterType, string filterValue);

        public IEnumerable<DateTime> GetFlightdates(string Destination);


        public IEnumerable<Flight> OrderedDurationFlights();

        public IEnumerable<Traveller> SeniorTravellers(Flight flight);

        public void DestinationGroupedFlights();





    }
}
