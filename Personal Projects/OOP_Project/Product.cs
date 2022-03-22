public class Product
{
    private string _id;
    private string _name;
    private string _description;
    //private ProductType _type;
    private float _originalPrice;
    private float _discount;
    private float _discountedPrice;
    private float _restockPrice;
    private DateTime _dateAdded;
    private DateTime _expiryDate;
    private int _quantity;

    public string Id { get => _id; private set => _id = value; }
    public string Name { get => _name; set => _name = value; }
    public string Description { get => _description; set => _description = value; }
    //public ProductType Type { get => _type; set => _type = value; }
    public float OriginalPrice { get => _originalPrice; set => _originalPrice = value; }
    public float Discount 
    {   
        get => _discount;
        set
        {
            _discount = value;
            _discountedPrice = _originalPrice - (_originalPrice * _discount);
        }
    }
    public float DiscountedPrice { get => _discountedPrice; private set => _discountedPrice = value; }
    public float RestockPrice { get => _restockPrice; private set => _restockPrice = value; }
    public DateTime DateAdded { get => _dateAdded; private set => _dateAdded = value; }
    public DateTime ExpiryDate { get => _expiryDate; private set => _expiryDate = value; }
    public int Quantity { get => _quantity; private set => _quantity = value; }

    public Product(
        string id,
        string name,
        string description,
        float originialPrice,
        float discount,
        DateTime dateAdded,
        DateTime expiryDate,
        float restockPrice,
        int quantity = 0)
    {
        _id = id;
        _name = name;
        _description = description;
        _originalPrice = originialPrice;
        Discount = discount;
        ExpiryDate = expiryDate;
        _dateAdded = dateAdded;
        _restockPrice = restockPrice;
        _quantity = quantity;
    }
/*    public Product(
        string id, 
        string name, 
        string description, 
        float originialPrice, 
        float discount, 
        DateTime dateAdded, 
        DateTime expiryDate,
        float restockPrice,
        ProductType type,
        int quantity = 0)
        :this(id, name, description, originialPrice, discount, dateAdded, expiryDate, restockPrice, quantity)
    {
        _type = type;
    }

*/    public void Restock(int amount)
    {
        if (amount < 0) throw new InvalidOperationException("Invalid amount to restock");
        Quantity += amount;
    }
}
