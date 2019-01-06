using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Oefeningen
{
    /* Onder de oefening staat een test functie. Voeg daar
     * locaties toe om alle opdrachten te testen.
     * 
     * De class GeoCoordinate is een bestaande class, net zoals
     * DateTime. Je kan via internet meer informatie opzoeken over
     * deze class.
     * 
     * 1.   In deze oefening is er al een constructor voorzien. Maak 
     *      zelf read-only properties om de argumenten op te slaan.
     *      
     * 2.   Werk de functie AsText() uit. Gebruik zowel name als coordinate.
     *      Je kan zelf opzoeken hoe je een GeoCoordinate omzet naar een string.
     *      
     * 3.   Werk de functie DistanceTo() uit. Zoek op met welke functie van GeoCoordinate
     *      je de afstand tussen twee coordinaten kan krijgen. Gebruik dan je eigen coordinaat
     *      en de coordinaat van other om de afstand te berekenen.
     *      
     * 4.   De testfunctie voorziet twee locaties, met constructors die er helemaal
     *      anders uitzien. Zorg dat je weet wat het verschil is, en hoe ze eigenlijk 
     *      ook bijna hetzelfde zijn. Wat is het meest overzichtelijk?
     */

    public class Location
    {
        string name;
        public string Name { get => name; }

        GeoCoordinate coordinate;
        public GeoCoordinate Coordinate { get => coordinate; }

        public Location(string name, GeoCoordinate coordinate)
        {
            this.name = name;
            this.coordinate = coordinate;
        }

        public double DistanceTo(Location other)
        {
            return coordinate.GetDistanceTo(other.coordinate);
        }

        public string AsText()
        {
            return Name + " is located at " + coordinate.ToString();
        }
    }

    public partial class Tests
    {
        // ( deze locaties staan buiten de functie omdat we ze ook in de volgende oefening gebruiken)
        public static Location brussel = new Location("Brussel", new GeoCoordinate(50.84573, 4.34649));

        public static Location aarschot = new Location(
            "Aarschot",
            new GeoCoordinate(
                latitude: 50.99201,
                longitude: 4.83129
            )
        );

        public static void TestLocation()
        {
            Console.WriteLine("Location 1: " + brussel.AsText());
            Console.WriteLine();
            
            Console.WriteLine("Location 2: " + aarschot.AsText());
            Console.WriteLine();

            Console.WriteLine("Distance between locations: " + (int)(aarschot.DistanceTo(brussel) / 1000) + "km");
        }
    }
}
