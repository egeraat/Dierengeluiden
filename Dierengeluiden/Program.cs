// Program.cs
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Maak een lijst van IAnimal en vul deze met dierobjecten
        List<IAnimal> animals = new List<IAnimal>
        {
            new hond(),
            new cat(),
            new kip(),
            new hond(),
            new koe(),
            new schaap()
        };

        // Loop door de lijst en laat elk dier een geluid maken
        foreach (var animal in animals)
        {
            animal.ShowInfo();
            animal.MakeSound();
            Console.WriteLine(); // Voor een lege regel tussen de outputs
        }
    }
}
