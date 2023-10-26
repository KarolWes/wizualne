namespace wizualne;

public class Supervisor: Manager
{
    public Supervisor(string imie, string nazwisko, int age) : base(imie, nazwisko, age)
    {
        Console.WriteLine("Supervisor constructor");
    }

    public Supervisor() : this("imie", "nazwisko", 33)
    {
        Console.WriteLine("argumentless constructor");
    }


#pragma warning disable CS0114
    public override string ToString()
    {
        return base.ToString() + " - Supervisor";
    }
}