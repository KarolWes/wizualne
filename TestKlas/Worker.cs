using System.Text;

namespace wizualne;

public abstract class Worker
{
    private string _imie;
    private string _nazwisko;
    private Guid _id;
    private DateTime _dataUrodzenia;
    public static int x;

    public String Imie
    {
        get => _imie;
        set => _imie = value;
    }

    public String Nazwisko
    {
        get => _nazwisko;
        set => _nazwisko = value;
    }

    public Guid ID
    {
        get => _id;
        set => _id = value;
    }

    public DateTime DataUrodzenia
    {
        get => _dataUrodzenia;
        set => _dataUrodzenia = value;
    }


    public override string ToString()
    {
        return Imie + " " + Nazwisko + " (" + ID.ToString() + ")";  
    }

    public void GenerateNewID()
    {
        ID = Guid.NewGuid();
    }

    protected Worker(string imie, string nazwisko, DateTime dataUrodzenia)
    {
        Console.WriteLine("Worker constructor");
        Imie = imie;
        Nazwisko = nazwisko;
        DataUrodzenia = dataUrodzenia;
        GenerateNewID();
    }

    static Worker()
    {
        Console.WriteLine("static constructor");
        
    }
}