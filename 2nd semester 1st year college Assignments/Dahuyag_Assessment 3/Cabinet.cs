public class Cabinet
{
    private int _row;
    private int _column;
    private int _capacity;
    private int _remainingCapacity;
    private float _value;
    private List<Thing> _things;
    public int Row { get => _row; set => _row = value; }
    public int Column 
    { 
        get => _column; 
        set
        {
            _column = value;
            _capacity = _row * _column;
            _value = _capacity * 10;
        }
    }
    public int Capacity { get => _capacity; private set => _capacity = value; }
    public int RemainingCapacity 
    { 
        get
        {
            _remainingCapacity = _capacity - _things.Count;
            return _remainingCapacity;
        }
        set => _remainingCapacity = value;
    }
    public float Value { get => _value; private set => _value = value; }
    public List<Thing> Things { get => _things; set => _things = value; }


    public Cabinet(int row, int column)
    {
        _row = row;
        Column = column;
        _things = new List<Thing>();
    }
    public Cabinet(int row,
                   int column,
                   Thing thing)
        :this(row, column)
    {
        Things.Add(thing);
    }
}
