public class CollectibleFigure : Thing
{
    private string _franchise;
    private float _originalPrice;
    private Rarity _rarity;
    private Condition _condition;

    public string Franchise { get => _franchise; set => _franchise = value; }
    public float OriginalPrice { get => _originalPrice; set => _originalPrice = value; }
    public Rarity Rarity { get => _rarity; set => _rarity = value; }
    public Condition Condition
    {
        get => _condition;
        private set
        {
            _condition = value;
            switch (_condition)
            {
                case Condition.Worst:
                    _originalPrice *= 0.25f;
                    break;
                case Condition.Bad:
                    _originalPrice *= 0.5f;
                    break;
                case Condition.Fine:
                    _originalPrice *= 0.75f;
                    break;
                case Condition.Good:
                    _originalPrice *= 1f;
                    break;
                case Condition.Best:
                    _originalPrice *= 1.25f;
                    break;
            }
            switch (_rarity)
            {
                case Rarity.Common:
                    Value = _originalPrice * 1.25f;
                    break;
                case Rarity.Rare:
                    Value = _originalPrice * 2.5f;
                    break;
                case Rarity.Unique:
                    Value = _originalPrice * 5.0f;
                    break;
            }
        }
    }
    public CollectibleFigure() { }
    public CollectibleFigure(string name,
                             string itemId,
                             string franchise,
                             float originalPrice,
                             Rarity rarity,
                             Condition condition) :
        base(name, itemId)
    {
        _franchise = franchise;
        _originalPrice = originalPrice;
        _rarity = rarity;
        Condition = condition;
    }
}
