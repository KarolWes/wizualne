using System.Collections;

namespace wizualne;

public class Office:IEnumerable, IComparer
{
    public Worker[] staff = new Worker[6];

    public Office()
    {
        staff[0] = new OfficeWorker("Tom", "Abby", 18);
        staff[1] = new OfficeWorker("Ben", "Jones", 27);
        staff[2] = new OfficeWorker("Anna", "Derby", 22);
        staff[3] = new OfficeWorker("Will", "Jackson", 65);
        staff[4] = new Manager("Jon", "Snow", 30);
        staff[5] = new Supervisor("Betty", "Brant", 42);
    }

    public void ShowAll()
    {
        foreach (var w in staff)
        {
            Console.WriteLine(w);
        }
    }

    public IEnumerator GetEnumerator()
    {
        return staff.GetEnumerator();
    }

    public IEnumerable GetByPosition(String pos)
    {
        switch (pos)
        {
            case "Worker":
            {
                yield return staff[0];
                yield return staff[1];
                yield return staff[2];
                yield return staff[3];
                break;
            }
            case "Manager":
            {
                yield return staff[4];
                break;
            }
            case "Supervisor":
            {
                yield return staff[5];
                break;
            }
            default:
            {
                ShowAll();
                break;
            }
        }
    }

    public IEnumerable GetByName()
    {
        yield return staff[0];
        yield return staff[5];
        yield return staff[2];
        yield return staff[3];
        yield return staff[1];
        yield return staff[4];
    }

    public void PrintByAge()
    {
        Array.Sort(staff);
        foreach (var w in staff)
        {
            Console.WriteLine(w);
        }
    }

    public int Compare(object? x, object? y)
    {
        Worker? x1 = x as Worker;
        Worker? y1 = y as Worker;
        return x1.Nazwisko.CompareTo(y1.Nazwisko);
    }
    
}