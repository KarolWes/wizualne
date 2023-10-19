namespace wizualne;

public readonly struct Point
{
    private readonly int _x;
    private readonly int _y;

    public readonly int x
    {
        get => _x;
        init => _x = value;
    }

    public readonly int y
    {
        get => _y;
        init => _y = value;
    }

    public Point()
    {
    }
}