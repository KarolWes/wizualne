namespace wizualne;

public sealed class OfficeWorker : Worker
{
    public OfficeWorker(string imie, string nazwisko, DateTime dataUrodzenia) : base(imie, nazwisko, dataUrodzenia)
    {
        Console.WriteLine("Office worker constructor");
    }
}