using System;

namespace First
{
	class Program
	{


		static void Main(string[] args)
		{
			var menu = new Utils.Menu();

			menu.AddOption('1', "Voer Oef1 uit", () => { Oefeningen.Tests.TestCircle(); });
            menu.AddOption('2', "Voer Oef2 uit", () => { Oefeningen.Tests.TestRectangle(); });
            menu.AddOption('3', "Voer Oef3 uit", () => { Oefeningen.Tests.TestUser(); });
            menu.AddOption('4', "Voer oef4 uit", () => { Oefeningen.Tests.TestLocation(); });

            menu.Start();
		}
        
	}
}
