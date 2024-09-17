public class schaap : IAnimal
{
    public void ShowInfo()
    {
        Console.Write("Er zijn 970 schapenrassen");
        Console.WriteLine("Wanneer een lammetje geboren wordt kan het dier gelijk dorst hebben na 30 minuten");
    }

    public void MakeSound()
    {
        Console.WriteLine("Moe");
    }
}