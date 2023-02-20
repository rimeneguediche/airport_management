// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using AM.ApplicationCore.Services;

//Console.WriteLine("Hello, World!");
// TP2 - Q5:Créer une instance de la classe ServiceFlight
ServiceFlight sf = new ServiceFlight();
//TP2-Q5:Affecter listFlights à la propriété Flights de la classe ServiceFlight
sf.Flights = TestData.listFlights;

//Console.WriteLine("************************************ GetFlightDates (string destination)  ****************************** ");
//Console.WriteLine("Flight dates to Madrid");
//foreach (var item in sf.GetFlightDates("Madrid"))
//    Console.WriteLine(item);



//ServiceFlight serviceFlight = new ServiceFlight();
//serviceFlight.Flights = TestData.listFlights;
//foreach (var item in serviceFlight.GetFlightDates("Paris"))
//    Console.WriteLine(item);
//sf.GetFlights("Destination", "Paris");

//foreach (var item in sf.GetFlightdates("Paris"))
//{
//    Console.WriteLine(item);
//}



//sf.FlightDetailsDel(TestData.BoingPlane);
//Console.WriteLine(sf.DurationAverageDel("Paris"));



Passenger passenger1 = new Passenger()
{
    FirstName = "houssemeddine",
    LastName = "mhedhbi",
    EmailAddress = "abc@gmail.com"
};
Console.WriteLine(passenger1.ToString());
PassangerExtension.UpperFullName(passenger1);
Console.WriteLine(passenger1.ToString());