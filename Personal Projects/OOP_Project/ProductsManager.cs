using System.Linq;

public class ProductsManager
//class to manage the products in the store
//does all the changes that happens to (a) specific product(s)
{
    private List<Product> _products = new List<Product>();
    public List<Product> Products 
    {
        get => _products; 
        private set => _products = value;
    }
    public List<Product> ProductsWithLowQuantity = new List<Product>();

    public void AddProduct(Product product)
    {
        if (product.Discount < 0 || product.Discount > 1) throw new InvalidOperationException("Discount value should be any value from 0 to 1");
        if (product.Quantity < 0) throw new InvalidOperationException("Invalid quantity value");
        if (product.DateAdded > product.ExpiryDate) throw new InvalidOperationException("Should not add expired item");
        if (_products.Select(item => item.Id).ToList().Contains(product.Id)) throw new InvalidOperationException("Id already Exists");
        if (product.Id == null) throw new InvalidOperationException("Items should at least have a product id");
        if (product.OriginalPrice < 0) throw new InvalidOperationException("Invalid original price value");
        if (product.RestockPrice < 0) throw new InvalidOperationException("Invalid restock price value");
        if (_products.Contains(product)) throw new InvalidOperationException("Product already exists");
        Products.Add(product);
    }
    public void AddProduct(List<Product> products)
    {
        foreach (var item in products)
        {
            AddProduct(item);
        }
    }
    public void RemoveProduct(Product product)
    {
        if (!_products.Contains(product)) throw new InvalidOperationException("Product does not exist");
        Products.Remove(product);
    }
    public void RemoveProduct(List<Product> products)
    {
        foreach (var item in products)
        {
            RemoveProduct(item);
        }
    }
    public void ChangeDiscountAmount(Product product, float newDiscountAmount)
    {
        if (newDiscountAmount > 1 || newDiscountAmount < 0) throw new InvalidOperationException("Invalid discount amount");
        if (!_products.Contains(product)) throw new InvalidOperationException("Product does not exist");

        product.Discount = newDiscountAmount;
    }
    public void MakeAlert()
    {
        foreach (var item in Products)
        {
            if (item.Quantity > 10) continue;
            ProductsWithLowQuantity.Add(item);
        }
        Console.WriteLine("Products that needs restocking: ");
        ProductPrinter.Print(ProductsWithLowQuantity);
    }
    public void BulkRestock(List<Product> products, int amount)
    {
        foreach (var item in products)
        {
            item.Restock(amount);
        }
    }
    public void Sorter(string sort)
    {
        switch (sort.ToLower())
        {
            case "id":
                Products = Products.OrderBy(item => item.Id).ToList();
                break;
            case "name":
                Products = Products.OrderBy(item => item.Name).ThenBy(item => item.Id).ToList();
                break;
            case "description":
                Products = Products.OrderBy(item => item.Description).ThenBy(item => item.Id).ToList();
                break;
            case "date added":
                Products = Products.OrderBy(item => item.DateAdded).ThenBy(item => item.Id).ToList();
                break;
            case "expiry date":
                Products = Products.OrderBy(item => item.ExpiryDate).ThenBy(item => item.Id).ToList();
                break;
            case "price":
                Products = Products.OrderBy(item => item.DiscountedPrice).ThenBy(item => item.Id).ToList();
                break;
            default:
                break;
        }
    }

}
