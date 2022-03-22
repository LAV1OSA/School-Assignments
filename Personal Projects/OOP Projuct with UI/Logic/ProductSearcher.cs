using System.Collections.Generic;
using System.Linq;

namespace OOP_Projuct_with_UI
{
    public class ProductSearcher
    {
        public ProductsManager ProductsManager { get; set; }
        public List<Product> ProductsFilteredBySearch = new List<Product>();
        public Display Display { get; set; }

        public void Search(string keyword)
        {
            int keywordAsInt = 0;
            if (int.TryParse(keyword, out keywordAsInt))
            {
                ProductsFilteredBySearch = ProductsManager.Products.FindAll(
                item =>
                item.Name.Trim().ToLower().Contains(keyword.ToLower().Trim()) ||
                item.Id.Trim().ToLower().Contains(keyword.ToLower().Trim()) ||
                item.Description.Trim().ToLower().Contains(keyword.ToLower().Trim()) ||
                item.DiscountedPrice.ToString().Contains(keyword.ToLower().Trim()) ||
                item.Quantity >= keywordAsInt
            ).ToList();
            }
            else
            {
                ProductsFilteredBySearch = ProductsManager.Products.FindAll(
                item =>
                item.Name.Trim().ToLower().Contains(keyword.ToLower().Trim()) ||
                item.Id.Trim().ToLower().Contains(keyword.ToLower().Trim()) ||
                item.Description.Trim().ToLower().Contains(keyword.ToLower().Trim()) ||
                item.DiscountedPrice.ToString().Contains(keyword.ToLower().Trim())
                ).ToList();
            }


            if (keyword == null || keyword.Length == 0) ProductsFilteredBySearch = ProductsManager.Products;
            Display.ProductsToPage = ProductsFilteredBySearch;
        }
    }
}
