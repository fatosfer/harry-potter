using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class butikk
    {
        public void DisplayMenu(karakter karakter)
        {
            Console.WriteLine("Velkommen til Magibutikken! Hva vil du gå innom?");
            Console.WriteLine("1. Dyre Seksjon");
            Console.WriteLine("2. Stav Seksjon");

            {
                string choice = Console.ReadLine().Trim();

                switch (choice)
                {
                    case "1":
                        DyreButikk(karakter);
                        break;
                    case "2":
                        StavButikk(karakter);
                        break;

                }
            }
        }




        public void DyreButikk(karakter karakter)
        {
            Console.Clear();
            Console.WriteLine("1. Ugle");
            Console.WriteLine("2. Rotte");
            Console.WriteLine("3. Katt");
            Console.WriteLine();

            Console.WriteLine("4. Gå til Stav seksjonen");
            Console.WriteLine("5. Avslutt");


            bool shopping = true;

            while (shopping)
            {
                string choice = Console.ReadLine().Trim();

                switch (choice)
                {
                    case "1":
                        karakter.Inventory.Add("Ugle");
                        Console.WriteLine("Du kjøpte en ugle.");
                        break;
                    case "2":
                        karakter.Inventory.Add("Rotte");
                        Console.WriteLine("Du kjøpte en rotte.");
                        break;
                    case "3":
                        karakter.Inventory.Add("Katt");
                        Console.WriteLine("Du kjøpte en katt.");
                        break;


                    case "4":
                        shopping = false;
                        StavButikk(karakter);
                        break;
                    case "5":
                        Console.Clear();
                        shopping = false;
                        break;
                    default:
                        Console.WriteLine("Ugyldig valg, prøv igjen.");
                        break;
                }
            }
        }



        public void StavButikk(karakter karakter)
        {
            Console.Clear();
            Console.WriteLine("1. Føniksstav");
            Console.WriteLine("2. Unikornstav");
            Console.WriteLine("3. Trollstav");
            Console.WriteLine();

            Console.WriteLine("4. Gå til Dyre seksjonen");
            Console.WriteLine("5. Avslutt");


            bool shopping = true;

            while (shopping)
            {
                string choice = Console.ReadLine().Trim();

                switch (choice)
                {
                    case "1":
                        karakter.Inventory.Add("Føniksstav");
                        Console.WriteLine("Du kjøpte en føniksstav.");
                        break;
                    case "2":
                        karakter.Inventory.Add("Unikornstav");
                        Console.WriteLine("Du kjøpte en unikornstav.");
                        break;
                    case "3":
                        karakter.Inventory.Add("Trollstav");
                        Console.WriteLine("Du kjøpte en trollstav.");
                        break;


                    case "4":
                        shopping = false;
                        DyreButikk(karakter);
                        break;
                    case "5":
                        Console.Clear();
                        shopping = false;
                        break;
                    default:
                        Console.WriteLine("Ugyldig valg, prøv igjen.");
                        break;
                }
            }
        }

    }
}
