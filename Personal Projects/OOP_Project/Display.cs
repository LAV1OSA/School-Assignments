public class Display //
{
    private ProductsManager _productsManager;
    public List<Product> ProductsOnPage = new List<Product>();

    public ProductsManager ProductsManager
    {
        get { return _productsManager; }
        set { _productsManager = value; }
    }

    public void Pager(int currentPage, int itemsPerPage)//applies paging to the items
    {
        ProductsOnPage = _productsManager.Products
               .Skip((currentPage - 1) * itemsPerPage)
               .Take(itemsPerPage)
               .ToList();

        float personsCount = _productsManager.Products.Count;
        double totalPage = personsCount / itemsPerPage;
        totalPage = Math.Ceiling(totalPage);
     

        Console.WriteLine("--- Products ---");
        ProductPrinter.Print(ProductsOnPage);
        Console.WriteLine($"Page {currentPage} of {totalPage}");
    }
    public void Sorter(int sort)
    {
        switch (sort)
        {
            case 1:
                ProductsManager.Products.Select(item => item.Id).OrderBy()
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
            case 6:
                break;
            default:
                break;
        }
    }
}
