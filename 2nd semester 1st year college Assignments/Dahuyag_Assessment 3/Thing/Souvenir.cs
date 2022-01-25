public class Souvenir : Thing
{
    private string _model;
    private SouvenirMaterialType _materialType;
    private string _countryOfOrigin;
    public string Model { get => _model; set => _model = value; }
    public SouvenirMaterialType MaterialType
    {
        get => _materialType;
        private set
        {
            _materialType = value;
            switch (_materialType)
            {
                case SouvenirMaterialType.Plastic:
                    Value = 100;
                    break;
                case SouvenirMaterialType.Wood:
                    Value = 150;
                    break;
                case SouvenirMaterialType.Steel:
                    Value = 300;
                    break;
            }
        }
    }
    public string CountryOfOrigin { get => _countryOfOrigin; set => _countryOfOrigin = value; }

    public Souvenir() { }
    public Souvenir(string name, 
                    string itemId, 
                    string model,
                    SouvenirMaterialType materialType,
                    string countryOfOrigin):
        base(name, itemId)
    {
        _model = model;
        MaterialType = materialType;
        _countryOfOrigin = countryOfOrigin;
    }
}
