namespace wizualne;

public interface IPrintable
{
    public int Id { get; set; }
    abstract void Print();
}