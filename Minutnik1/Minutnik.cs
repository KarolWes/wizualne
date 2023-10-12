namespace wizualne;

public class Minutnik
{

    private DateTime _endTime;
    private DateTime _today;
    private String _last, _diff;

    public Minutnik(DateTime endTime)
    {
        _today = DateTime.Now;
        _last = "";
        _diff = "";
        this._endTime = endTime;
    }

    public Minutnik(int hour, int minute, int sek)
    {
        _last = "";
        _diff = "";
        _today = DateTime.Now;
        this._endTime = new DateTime(_today.Year, _today.Month, _today.Day, hour, minute, sek);
        
    }
    public void show()
    {
        while (_today < _endTime)
        {
            _today = DateTime.Now;
            _diff = (_endTime - _today).ToString().Substring(0,8);
            if (_last != _diff)
            {
                // Console.Clear();
                Console.SetCursorPosition(Console.WindowWidth-8, 0);
                Console.WriteLine(_diff);
                _last = _diff;
            }
        }
        Console.WriteLine("Finished");
    }
}
    