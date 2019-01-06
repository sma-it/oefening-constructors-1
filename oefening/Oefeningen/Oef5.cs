using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefeningen
{
    public class Event
    {
        /*
         * 1.   Voeg geschikte properties toe, zodat je de waarden uit de constructor
         *      kan opslaan. (En doe dat dan ook)
         *      
         * 2.   Werk de functie AsText() uit.
         * 
         * 3.   Verwijder de comments voor de testcode. Gebruik de functie AsText om
         *      elk event op het scherm te tonen.
         *      
         * 4.   Maak nog een derde event aan, ditmaal in een stad naar keuze. Je maakt
         *      zelf ook een nieuwe locatie voor deze stad.
         */

        string name;
        public string Name { get => name; }

        DateTime date;
        public DateTime Date { get => date; }

        Location location;
        public Location Location { get => location; }

        public Event(string name, DateTime date, Location location)
        {
            this.name = name;
            this.date = date;
            this.location = location;
        }

        public string AsText()
        {
            return Name + " will happen on " + Date.ToShortDateString() + " in " + Location.Name;
        }
    }

    public partial class Tests
    {
        public static void TestEvent()
        {
            // je kan deze code gebruiken wanneer je je constructor klaar hebt
            var event1 = new Event("Coding Marathon", new DateTime(DateTime.Now.Year, 7, 21), aarschot);
            var event2 = new Event("Hacker Cup", new DateTime(DateTime.Now.Year, 5, 4), brussel);

            // extra coordinate with my location
            var myLocation = new Location("Leuven", new GeoCoordinate(50.8813454, 4.715648));

            Console.WriteLine(event1.AsText());
            // returned distance is in meters, but I prefer km
            Console.WriteLine("Distance to location: " + (int)(event1.Location.DistanceTo(myLocation) / 1000) + "km");
            Console.WriteLine();

            Console.WriteLine(event2.AsText());
            Console.WriteLine("Distance to location: " + (int)(event2.Location.DistanceTo(myLocation) / 1000) + "km");
            Console.WriteLine();
        }
    }
}
