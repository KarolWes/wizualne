namespace wizualne;

public sealed class OfficeWorker : Worker
{
    public OfficeWorker(string imie, string nazwisko, int age) : base(imie, nazwisko, age)
    {
        Console.WriteLine("Office worker constructor");
    }
}