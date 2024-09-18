public class hond : IAnimal
{
    public void ShowInfo()
    {
        Console.Write("Er zijn ongeveer 300 verschillende hondenrassen\n");
        Console.WriteLine("Een hond kan tot wel 20 kilometer ver ruiken\n\n");
    }

    public void MakeSound()
    {
        Console.WriteLine("honden geblaf");
    }
}