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
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public int Age {
            get {
                int age = 0;
                age = DateTime.Now.Year - DateOfBirth.Year;
                if (DateTime.Now.DayOfYear < DateOfBirth.DayOfYear)
                    age = age - 1;

                return age;
            }
        }

        public User(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }

        public User(string FirstName, string LastName, DateTime DateOfBirth) 
            : this(FirstName, LastName)
        {
            this.DateOfBirth = DateOfBirth;
        }

        public string AsText()
        {
            return FirstName + " " + LastName + " is " + Age + " years old.";
        }
    }

    public partial class Tests
    {
        public static void TestUser()
        {
            Console.WriteLine("Testing the User class... ");
            Console.WriteLine(); // extra white line

            var user1 = new User("John", "Doe", new DateTime(2000, 6, 30));
            Console.WriteLine(user1.AsText());

            var user2 = new User("Jane", "Doe");
            Console.WriteLine(user2.AsText());
        }
    }
}
