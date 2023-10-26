namespace wizualne;

public class Manager : Worker
{
    public Manager(string imie, string nazwisko, int age) : base(imie, nazwisko, age)
    {
        Console.WriteLine("Manager constructor");
    }
    
    

    public override string ToString()
    {
        return base.ToString() + " - Manager";
    }
}