public class cat : IAnimal
{
    public void ShowInfo()
    {
        Console.Write("Een kat heeft tussen de 8 en 12 snorharen\n");
        Console.WriteLine("Een kat kan bijna 50 km per uur rennen\n\n");
    }

    public void MakeSound()
    {
        Console.WriteLine("katten gemauw");
    }
}