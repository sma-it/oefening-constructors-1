using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefeningen
{
    public class User
    {
        /* Onder de oefening staat een test functie. Voeg daar
         * Users toe om alle opdrachten te testen.
         * 
         * 1.   Voorzie properties FirstName (string), LastName (string), en 
         *      DateOfBirth (DateTime).
         *      
         * 2.   Voorzie een read-only property Age (int)
         * 
         * 3.   Maak een constructor waar je FirstName en LastName mee kan instellen.
         *      
         * 4.   Maak een tweede constructor waar je je ook DateOfBirth mee kan instellen.
         * 
         */
         
        public string AsText()
        {
            // return some info about this user
            return string.Empty;
        }
    }

    public partial class Tests
    {
        public static void TestUser()
        {
            Console.WriteLine("Testing the User class... ");
            Console.WriteLine(); // extra white line

            var user = new User();
            Console.WriteLine(user.AsText());
        }
    }
}
