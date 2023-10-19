namespace wizualne;

public class Supervisor: Manager
{
    public Supervisor(string imie, string nazwisko, DateTime dataUrodzenia) : base(imie, nazwisko, dataUrodzenia)
    {
        Console.WriteLine("Supervisor constructor");
    }

    public Supervisor() : this("imie", "nazwisko", new DateTime(1990, 1,1))
    {
        Console.WriteLine("argumentless constructor");
    }


#pragma warning disable CS0114
    public string ToString()
    {
        return base.ToString() + " - Supervisor";
    }
}