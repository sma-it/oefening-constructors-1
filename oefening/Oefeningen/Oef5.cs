using System;
using System.Collections.Generic;
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

        public Event(string name, DateTime date, Location location)
        {

        }

        public string AsText()
        {
            return string.Empty;
        }
    }

    public partial class Tests
    {
        public static void TestEvent()
        {
            // je kan deze code gebruiken wanneer je je constructor klaar hebt
            // var event1 = new Event("Coding Marathon", new DateTime(DateTime.Now.Year, 7, 21), aarschot);
            // var event2 = new Event("Hacker Cup", new DateTime(DateTime.Now.Year, 5, 4), brussel);

            
        }
    }
}
