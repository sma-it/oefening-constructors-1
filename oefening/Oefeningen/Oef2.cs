using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefeningen
{
    public class Rectangle
    {
        /*      Onder de oefening staat een test functie. Voeg daar extra
         *      rechthoeken toe om alle opdrachten te testen.
         * 
         * 1.   Voorzie een constructor om height en width in te stellen.
         *      Gebruik deze constructor in je test, zowel met positional
         *      als named arguments.
         *         
         * 2.   Voorzie een default constructor die height en width
         *      de waarde 1 geeft.
         *      
         * 3.   Maak de properties Height en Width read-only.
         *      
         * 4.   Maak een boolean read-only property die je laat weten
         *      of de rechthoek eigenlijk een vierkant is. 
         */      

        public int Height { get; set; }
        public int Width { get; set; }

        public int Area { get => Height * Width; }

        public string AsText()
        {
            return "This circle has an area of " + Area;
        }
    }

    public partial class Tests
    {
        public static void TestRectangle()
        {
            Console.WriteLine("Testing the Rectangle class... ");
            Console.WriteLine(); // extra white line 

            var r1 = new Rectangle();
            Console.WriteLine(r1.AsText());
            Console.WriteLine();

            var r2 = new Rectangle();
            r2.Width = 3; // will this work after exercise 3??
            r2.Height = 4;
            Console.WriteLine(r2.AsText());
            Console.WriteLine();

            // add your own rectangles here
        }
    }
}
