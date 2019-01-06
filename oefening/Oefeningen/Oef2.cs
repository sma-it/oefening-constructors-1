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

        private int height;
        public int Height { get => height; }

        private int width;
        public int Width { get => width; }

        public int Area { get => Height * Width; }

        public bool IsSquare { get => height == width; }

        public Rectangle()
        {
           height = width = 1;
        }
        public Rectangle(int Height, int Width)
        {
            this.height = Height;
            this.width = Width;
        }

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
            Console.WriteLine("Is a square: " + r1.IsSquare);
            Console.WriteLine();

            var r2 = new Rectangle(3, 4);
            Console.WriteLine(r2.AsText());
            Console.WriteLine("Is a square: " + r2.IsSquare);
            Console.WriteLine();
        }
    }
}
