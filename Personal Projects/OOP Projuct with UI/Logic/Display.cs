using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace OOP_Projuct_with_UI
{
    public class Display
    {
        public List<Product> ProductsOnPage = new List<Product>();
        public List<Product> ProductsToPage = new List<Product>();//list of products to apply paging to
        public int itemsPerPage = 10;

        public ProductsManager ProductsManager { get; set; }
        public ProductSearcher ProductSearcher { get; set; }

        public void Pager(int currentPage, int newItemsPerPage)//applies paging to the items
        {
            if (ProductsToPage.Count == 0) ProductsToPage = ProductsManager.Products;

            ProductsOnPage = ProductsToPage
                   .Skip((currentPage - 1) * newItemsPerPage)
                   .Take(newItemsPerPage)
                   .ToList();

            float productsCount = ProductsToPage.Count;
            double totalPage = productsCount / newItemsPerPage;
            totalPage = Math.Ceiling(totalPage);


            Console.WriteLine("--- Products ---");
            ProductPrinter.Print(ProductsOnPage);
            Console.WriteLine($"Page {currentPage} of {totalPage}");
        }
    }
}
