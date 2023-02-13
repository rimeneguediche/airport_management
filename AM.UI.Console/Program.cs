// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;

Console.WriteLine("Hello, World!");
// TP2 - Q5:Créer une instance de la classe ServiceFlight
ServiceFlight sf = new ServiceFlight();
//TP2-Q5:Affecter listFlights à la propriété Flights de la classe ServiceFlight
sf.Flights = TestData.listFlights;

Console.WriteLine("************************************ GetFlightDates (string destination)  ****************************** ");
Console.WriteLine("Flight dates to Madrid");
foreach (var item in sf.GetFlightDates("Madrid"))
    Console.WriteLine(item);


