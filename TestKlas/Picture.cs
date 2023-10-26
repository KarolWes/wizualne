namespace wizualne;

public class Picture:IDraw
{
    public void Draw()
    {
        Console.WriteLine("Drawing picture...");
    }

    void IDraw.Draw()
    {
        Console.WriteLine("Overriden draw");
    }
}