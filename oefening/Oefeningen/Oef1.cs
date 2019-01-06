using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefeningen
{

	public class Circle
	{
        /*
		 * 1.   Voorzie een constructor bij deze circle die je verplicht om 
         *      Radius en Color een waarde te geven. On de class staat ook een functie
         *      'TestCircle'. Voeg hier een nieuwe cirkel toe om je constructor te testen.
		 * 
         * 2.   Vervang de functies Perimeter() en Area() door read only properties.
         *      Je zal ook de functie AsText() moeten aanpassen om dit te doen werken.
		 */

        public int Radius { get; set; }
        public string Color { get; set; }

        public double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public string AsText()
        {
            return "This is a " + Color + " circle, with a perimeter of " + Perimeter()
                + " and an area of " + Area();
        }
	}

    public partial class Tests
    {
        public static void TestCircle()
        {
            Console.WriteLine("Testing the Circle class... ");
            Console.WriteLine(); // extra white line 

            // creating a circle with default constructor
            Circle c1 = new Circle();
            c1.Radius = 1;
            c1.Color = "green";

            // print to console
            Console.WriteLine(c1.AsText());
            Console.WriteLine();

            // add your own circles here
        }
    }
    
}
