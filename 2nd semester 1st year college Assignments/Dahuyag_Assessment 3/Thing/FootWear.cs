public class FootWear : Thing
{
    private float _size;
    private FootWearType _type;
    private float _originalPrice;
    public float Size { get => _size; private set => _size = value; }
    public FootWearType Type { get => _type; private set => _type = value;}
    public float OriginalPrice { get => _originalPrice; set => _originalPrice = value; }
    public FootWear() { }
    public FootWear(string name,
                    string itemId,
                    float originalPrice,
                    float size,
                    FootWearType type) :
        base(name, itemId)
    {
        _size = size;
        _type = type;
        Value = OriginalPrice = originalPrice;
    }
}
