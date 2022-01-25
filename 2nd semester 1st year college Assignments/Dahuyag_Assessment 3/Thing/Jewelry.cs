public class Jewelry : Thing
{
    private Rarity _rarity;
    private JewelryMaterialType _materialType;
    public Rarity Rarity { get => _rarity; set => _rarity = value; }
    public JewelryMaterialType MaterialType
    {
        get => _materialType;
        private set
        {
            _materialType = value;
            switch (_materialType)
            {
                case JewelryMaterialType.Bronze:
                    Value = 1000;
                    break;
                case JewelryMaterialType.Silver:
                    Value = 3000;
                    break;
                case JewelryMaterialType.Gold:
                    Value = 5000;
                    break;
            }
            switch (_rarity)
            {
                case Rarity.Common:
                    Value *= 1.5f;
                    break;
                case Rarity.Rare:
                    Value *= 2.0f;
                    break;
                case Rarity.Unique:
                    Value *= 3.5f;
                    break;
            }
        }
    }
    public Jewelry() { }
    public Jewelry(string name,
                   string itemId,
                   Rarity rarity,
                   JewelryMaterialType materialType) :
        base(name, itemId)
    {
        _rarity = rarity;
        MaterialType = materialType;
    }
}
