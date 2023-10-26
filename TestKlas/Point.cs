namespace wizualne;

public class Point
{
    private readonly int _x;
    private readonly int _y;

    public int x
    {
        get => _x;
        init => _x = value;
    }

    public int y
    {
        get => _y;
        init => _y = value;
    }

    public Point()
    {
    }
}