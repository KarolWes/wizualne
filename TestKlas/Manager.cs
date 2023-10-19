namespace wizualne;

public class Manager : Worker
{
    public Manager(string imie, string nazwisko, DateTime dataUrodzenia) : base(imie, nazwisko, dataUrodzenia)
    {
        Console.WriteLine("Manager constructor");
    }
    
    

    public sealed override string ToString()
    {
        return base.ToString() + " - Manager";
    }
}