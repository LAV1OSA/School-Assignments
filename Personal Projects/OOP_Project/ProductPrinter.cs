public class ProductPrinter
{
    public static void Print(Product p)
    {
        Console.WriteLine($"{"ID",-15}  {"Product",-15}  {"Description",-15} {"Price",-8} {"Date Added",-11} {"Expiry Date"}");
        Console.Write($"{p.Id,-15}  {p.Name,-15}  {p.Description,-15} {p.DiscountedPrice,-8:C2} {p.DateAdded,-11:d-M-yyyy} {p.ExpiryDate,-11:d-M-yyyy}\n");
    }
    public static void Print(List<Product> products)
    {
        const int maxChars = 15;
        Console.WriteLine($"{"ID",-15}  {"Product",-15}  {"Description",-15} {"Price",-8} {"Date Added",-11} {"Expiry Date",-11}");
        foreach (var p in products)
        {
            string productName = p.Name.Length > maxChars ? string.Concat(p.Name.AsSpan(0, 12), "...") : p.Name;
            string productDescription = p.Description.Length > maxChars ? string.Concat(p.Description.AsSpan(0, 12), "...") : p.Description;

            Console.Write($"{p.Id,-maxChars}  {productName,-maxChars}  {productDescription,-maxChars} {p.DiscountedPrice,-8:C2} {p.DateAdded,-11:d-M-yyyy} {p.ExpiryDate,-11:d-M-yyyy}\n");
        }
        //Console.WriteLine($"Query returned {products.Count} items.");
    }
}
