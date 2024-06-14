using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class karakter
    {
        public string Name { get; set; }
        public string House { get; set; }
        public List<string> Inventory { get; set; }

        public karakter(string name, string house)
        {
            Name = name;
            House = house;
            Inventory = new List<string>();
        }

        public void Introduce()
        {
            Console.WriteLine($"Hei, jeg heter {Name}, tilhører huset {House}, og har følgende gjenstander:");
            foreach (var item in Inventory)
            {
                Console.WriteLine($"- {item}");
            }
        }



        public void PerformSpell(string spell)
        {
            string normalizedSpell = spell.Trim().ToLower();
            switch (normalizedSpell)
            {
                case "vingardium leviosa":
                    Console.WriteLine("Du fikk en fjær til å fly!");
                    break;
                case "hokus pokus":
                    Console.WriteLine("Du fyrte av fyrverkerier!");
                    break;
                default:
                    Console.WriteLine("Ugyldig trylleformel.");
                    break;
            }
        }





    }
}
