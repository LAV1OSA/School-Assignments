public abstract class Thing
{
    private string _name;
    private string _itemID;
    private float _value;
    private static List<string> _idList = new List<string>();
    public string Name { get => _name; set => _name = value; }
    public string ItemID { get => _itemID; set => _itemID = value; }
    public float Value { get => _value; protected set => _value = value; }
    public static List<string> IdList { get => _idList; set => _idList = value; }
    public Thing() { }
    public Thing(string name, string itemId)
    {
        _name = name;
        if (_idList.Contains(itemId))
                throw new InvalidOperationException("ID already exists");
        _idList.Add(itemId);
        _itemID = itemId;
    }
    public override string ToString()
    {
        var sb = new StringBuilder();
        if (_name.Length > 11)
            sb.Append($"| {_name.Substring(0,11) + "...",-14} ");
        else
            sb.Append($"| {_name,-14} ");
        if (_value > 99999)
            sb.Append($"| {_value,8:E1} ");
        else
            sb.Append($"| { _value,8:F} ");
        if (_itemID.Length > 7)
            sb.Append($"| {_itemID.Substring(0, 4) + "...",7} |");
        else
            sb.Append($"| {_itemID, 7} |");
        return sb.ToString();
    }
}
