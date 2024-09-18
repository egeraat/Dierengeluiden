public class koe : IAnimal
{
    public void ShowInfo()
    {
        Console.Write("Een koe slaapt maar een halfuur per dag\n");
        Console.WriteLine("Koeien geven meer melk als ze naar muziek luisteren\n\n");
    }

    public void MakeSound()
    {
        Console.WriteLine("Moe");
    }
}