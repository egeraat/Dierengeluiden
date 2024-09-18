public class schaap : IAnimal
{
    public void ShowInfo()
    {
        Console.Write("Er zijn 970 schapenrassen\n");
        Console.WriteLine("Wanneer een lammetje geboren wordt kan het dier gelijk dorst hebben na 30 minuten\n\n");
    }

    public void MakeSound()
    {
        Console.WriteLine("Schapengeluid");
    }
}