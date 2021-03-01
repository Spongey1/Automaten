using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialiseret Objekterne 
            Automaten skumbananer = new Automaten("Skumbanan", 5, 10);
            Automaten Cola = new Automaten("Coca Cola", 22.5, 20);
            Automaten Fanta = new Automaten("Fanta", 20, 15);

            List<string> custVare = new List<string>(); // Customers Inventory

            Console.WriteLine("Hvor mange penge har du i øjeblikket?"); // Customers money when they arrive at the machine
            double pengeMængde = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            bool loop = true;
            while (loop == true)
            {
                automatMenuen();
                string automatValg = Console.ReadLine();

                switch (automatValg.ToLower()) // Uses user input to purchase items
                {
                    case "skumbanan":
                        if (pengeMængde >= skumbananer.varePris)
                        {
                            Console.WriteLine("Du har nå købt en Skumbanan!");
                            skumbananer.vareAntal--;
                            pengeMængde = pengeMængde - skumbananer.varePris;
                            custVare.Add(skumbananer.vare);
                        }
                        else
                        {
                            Console.WriteLine("ERROR: Du har ikke nok penge");
                            loop = false;
                        }
                        break;

                    case "cola":
                        if (pengeMængde >= Cola.varePris)
                        {
                            Console.WriteLine("Du har nå købt en Cola!");
                            Cola.vareAntal--;
                            pengeMængde = pengeMængde - Cola.varePris;
                            custVare.Add(Cola.vare);
                        }
                        else
                        {
                            Console.WriteLine("ERROR: Du har ikke nok penge");
                            loop = false;
                        }
                        break;

                    case "fanta":
                        if (pengeMængde >= Fanta.varePris)
                        {
                            Console.WriteLine("Du har nå købt en Fanta!");
                            Fanta.vareAntal--;
                            pengeMængde = pengeMængde - Fanta.varePris;
                            custVare.Add(Fanta.vare);
                        }
                        else
                        {
                            Console.WriteLine("ERROR: Du har ikke nok penge");
                            loop = false;
                        }
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
            Console.WriteLine("Remaining money: " + pengeMængde + " kr."); // Displays the remaining money after the purchases have been completed
            Console.WriteLine("You currently own these items:");
            foreach (var item in custVare) // Displays all the values in the Customers inventory
            {
                Console.WriteLine(" - " + item);
            }
            Console.ReadKey();
        }
        static void automatMenuen() // Menuen
        {
            Console.WriteLine("==========================");
            Console.WriteLine("           Automat        ");
            Console.WriteLine("==========================");
            Console.WriteLine("                          ");
            Console.WriteLine("  - Skumbanan |-| Pris = 5");
            Console.WriteLine("  - Cola |-| Pris = 22.5  ");
            Console.WriteLine("  - Fanta |-| Pris = 20   ");
            Console.WriteLine("                          ");
            Console.WriteLine("==========================");
            Console.WriteLine("\r\n Hvad kunne du tænke dig at købe?");
        }
    }
}
