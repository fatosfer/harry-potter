using ConsoleApp3;
using System;
using System.Collections.Generic; 

public class Character
{

}


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Velkommen til Harry Potter-verdenen!");
        Console.Write("Skriv inn navnet ditt: ");
        string name = Console.ReadLine();
        Console.Write("Skriv inn huset ditt: ");
        string house = Console.ReadLine();
        Console.Clear();

        var karakter = new karakter(name, house);

        karakter.Introduce();

        butikk shop = new butikk();
        shop.DisplayMenu(karakter);

        karakter.Introduce();

        Console.WriteLine("Skriv inn en trylleformel (vingardium leviosa / hokus pokus):");
        string spell = Console.ReadLine();
        karakter.PerformSpell(spell);
    }
}