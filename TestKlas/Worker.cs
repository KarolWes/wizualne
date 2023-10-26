using System.Text;

namespace wizualne;

public abstract class Worker: IPrintable, IPublicPrintable, IComparable
{
    private string _imie;
    private string _nazwisko;
    private Guid _id;
    private int _age;
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

    // public Guid ID
    // {
    //     get => _id;
    //     set => _id = value;
    // }

    public int Age
    {
        get => _age;
        set => _age = value;
    }


    public override string ToString()
    {
        return Imie + " " + Nazwisko + " (" + Age + ")";  
    }

    public int CompareTo(object? obj)
    {
        Worker w = obj as Worker;
        return this.Age.CompareTo(w.Age);
    }

    // public void GenerateNewID()
    // {
    //     ID = Guid.NewGuid();
    // }

    protected Worker(string imie, string nazwisko, int age)
    {
        Console.WriteLine("Worker constructor");
        Imie = imie;
        Nazwisko = nazwisko;
        Age = age;
        //GenerateNewID();
    }

    static Worker()
    {
        Console.WriteLine("static constructor");
        
    }

    public int Id { get; set; }
    void IPrintable.Print()
    {
        Console.WriteLine(Imie + " " + Nazwisko + " (" + Id + ")");
         
    }

    void IPublicPrintable.Print()
    {
        Console.WriteLine(Imie + " " + Nazwisko);
    }

    public virtual void Print()
    {
        ((IPrintable)this).Print();
        Console.WriteLine("Virtual");
    }
}