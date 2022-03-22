using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FluentAssertions;
using System.Globalization;

namespace OOP_Project
{
    public class Tests
    {
        [Test]
        public void AddProduct_AddProductToProductsProperty_ProductsContainProduct()
        {
            var productManager = new ProductsManager();

            productManager.AddProduct(ProductsProvider.GetProducts("../../../Default Products new.txt"));

            var file = File.Open("../../../Default Products new.txt", FileMode.Open);
            var reader = new StreamReader(file);
            var data = reader.ReadToEnd();

            var TempProducts = new List<Product>();
            char rowSeparator = '\n';
            var separateRows = data.Split(rowSeparator);
            foreach (var row in separateRows)
            {
                if (row.Length <= 0) continue;
                var splitColumns = row.Trim().Split(';');//made a semicolon separated file because data contains comma
                string id = splitColumns[0];
                string name;
                string description;
                string[] splitNameAndDescription;
                if (splitColumns[1].Length <= 0) //if no name, put the product id; if no description, put "No description added"
                {
                    name = $"Product {id}";
                    description = "No description added";
                }
                else
                {
                    splitNameAndDescription = splitColumns[1].Split(" - ");
                    name = splitNameAndDescription[0].Length <= 0 ? $"Product {id}" : splitNameAndDescription[0];
                    description = splitNameAndDescription.Length < 2 ? "No description added" : splitNameAndDescription[1];
                }
                float price = splitColumns[2].Length <= 0 ? 0 : float.Parse(splitColumns[2], CultureInfo.InvariantCulture.NumberFormat);
                float discount = splitColumns[3].Length <= 0 ? 0 : float.Parse(splitColumns[3], CultureInfo.InvariantCulture.NumberFormat);
                DateTime dateAdded = DateTime.Parse(splitColumns[4]);
                DateTime expiryDate = DateTime.Parse(splitColumns[5]);
                float restockPrice = float.Parse(splitColumns[6]);
                int quantity = int.Parse(splitColumns[7]);
                var product = new Product(id, name, description, price, discount, dateAdded, expiryDate, restockPrice, quantity);
/*                if (Enum.TryParse<ProductType>(splitColumns[8], out ProductType type))
                {
                    Enum.Parse(typeof(ProductType), splitColumns[8]);
                    product.Type = type;
                }
*/                TempProducts.Add(product);
            }
            file.Close();
            reader.Close();

            productManager.Products.Should().HaveCount(TempProducts.Count());
            productManager.Products.Should().BeEquivalentTo(TempProducts);
        }
        [Test]
        public void RemoveProduct_RemoveExistingProduct_RemoveProductFromList()
        {
            //arrange
            var productManager = new ProductsManager();

            //act
            productManager.AddProduct(ProductsProvider.GetProducts("../../../Default Products new.txt"));
            List<Product> productsToRemove = productManager.Products.GetRange(0, 5);
            productManager.RemoveProduct(productsToRemove);

            //assert
            productManager.Products.Should().NotContain(productsToRemove);
        }
        [Test]
        public void ProductPrinter_ReadFromFile_DisplayListOfProducts()
        {
            //arrange
            var productManager = new ProductsManager();

            //act
            productManager.AddProduct(ProductsProvider.GetProducts("../../../Default Products new.txt"));

            //assert
            ProductPrinter.Print(productManager.Products);
        }
        [Test]
        public void ChangeDiscount_ChangeDiscountValueOfProduct_SetNewDiscountValue()
        {
            //arrange
            var productManager = new ProductsManager();

            //act
            float newDiscount = 0.12f;
            productManager.AddProduct(ProductsProvider.GetProducts("../../../Default Products new.txt"));
            productManager.ChangeDiscountAmount(productManager.Products[0], newDiscount);

            //assert
            productManager.Products[0].Discount.Should().Be(newDiscount);
        }
        [Test]
        public void OneProduct_SetProduct_AssertAndDisplayOneProduct()
        {
            //act
            var product = new Product("1123-123", "Beans", "Green", 100, 0, new DateTime(2020, 1, 4), new DateTime(2021, 3, 17), 90, 20);

            //assert
            ProductPrinter.Print(product);
        }
        [TestCase(2, 5)]
        [TestCase(4, 10)]
        [TestCase(12, 2)]
        public void Display_AddPagingToProducts_DiplayProductsByPage(int currentPage, int itemsPerPage)
        {
            var productManager = new ProductsManager();
            var display = new Display();

            productManager.AddProduct(ProductsProvider.GetProducts("../../../Default Products new.txt"));
            display.ProductsManager = productManager;

            display.Pager(currentPage, itemsPerPage);
        }
        [Test]
        public void MakeAlert_CheckProductsWithLowQuaantity_UpdateAndPrintList()
        {
            var productManager = new ProductsManager();

            productManager.AddProduct(ProductsProvider.GetProducts("../../../Default Products new.txt"));
            List<Product> lowQuantity = productManager.Products.Where(item => item.Quantity <= 10).ToList();
            productManager.MakeAlert();

            productManager.ProductsWithLowQuantity.Should().Equal(lowQuantity);
        }
        [Test]
        public void RestockAndBulkRestock_RestockListOfProducts_AddQuantityToItems()
        {
            var productManager = new ProductsManager();

            int amount = 10;
            productManager.AddProduct(ProductsProvider.GetProducts("../../../Default Products new.txt"));
            List<Product> tempProducts = new List<Product>();
            tempProducts = ProductsProvider.GetProducts("../../../Default Products new.txt");
            productManager.BulkRestock(productManager.Products, amount);

            for(int x = 0; x < productManager.Products.Count; x++)
            {
                productManager.Products[x].Quantity.Should().Be(tempProducts[x].Quantity + amount);
            }
        }
        [TestCase("NaMe")]
        [TestCase("ID")]
        [TestCase("DescriPtioN")]
        [TestCase("Date AddeD")]
        [TestCase("ExPiry dAte")]
        [TestCase("pRice")]
        public void Sorter_SetSortingParameter_SortByGivenParameter(string sort)
        {
            var productManager = new ProductsManager();
            var display = new Display();

            productManager.AddProduct(ProductsProvider.GetProducts("../../../Default Products new.txt"));
            display.ProductsManager = productManager;
            var tempProducts = ProductsProvider.GetProducts("../../../Default Products new.txt");

            switch (sort.ToLower())
            {
                case "id":
                    tempProducts.OrderBy(item => item.Id);
                    break;
                case "name":
                    tempProducts.OrderBy(item => item.Name).ThenBy(item => item.Id);
                    break;
                case "description":
                    tempProducts.OrderBy(item => item.Description).ThenBy(item => item.Id);
                    break;
                case "date added":
                    tempProducts.OrderBy(item => item.DateAdded).ThenBy(item => item.Id);
                    break;
                case "expiry date":
                    tempProducts.OrderBy(item => item.ExpiryDate).ThenBy(item => item.Id);
                    break;
                case "price":
                    tempProducts.OrderBy(item => item.DiscountedPrice).ThenBy(item => item.Id);
                    break;
                default:
                    break;
            }
            productManager.Sorter(sort);

            //assert
            productManager.Products.Should().BeEquivalentTo(tempProducts);

            display.Pager(1, 10);
        }
        [TestCase("squash")]
        [TestCase("10")]
        [TestCase("502")]
        [TestCase("water")]
        [TestCase("or")]
        [TestCase("f")]
        [TestCase("")]
        public void ItemSearcher_SearchByKeyword_UpdateListToDisplay(string keyword)
        {
            var productManager = new ProductsManager();
            var display = new Display();
            var searcher = new ProductSearcher();

            productManager.AddProduct(ProductsProvider.GetProducts("../../../Default Products new.txt"));
            display.ProductsManager = productManager;
            searcher.ProductsManager = productManager;
            searcher.Display = display;
            var tempProducts = ProductsProvider.GetProducts("../../../Default Products new.txt");

            
            if (int.TryParse(keyword, out int keywordAsInt))
            {
                tempProducts = tempProducts.FindAll(
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
                tempProducts = tempProducts.FindAll(
                item =>
                item.Name.Trim().ToLower().Contains(keyword.ToLower().Trim()) ||
                item.Id.Trim().ToLower().Contains(keyword.ToLower().Trim()) ||
                item.Description.Trim().ToLower().Contains(keyword.ToLower().Trim()) ||
                item.DiscountedPrice.ToString().Contains(keyword.ToLower().Trim())
                ).ToList();
            }

            if (keyword == null) tempProducts = productManager.Products;

            searcher.Search(keyword);

            searcher.ProductsFilteredBySearch.Should().BeEquivalentTo(tempProducts);
            display.ProductsToPage.Should().BeEquivalentTo(tempProducts);

            display.Pager(1, 10);
            display.Pager(2, 10);
            display.Pager(3, 10);
            display.Pager(4, 10);
            display.Pager(5, 10);
        }
        [Test]
        public void SaveProducts_SaveProductToFile_GetCorrectListFromFile()
        {
            var provider = new ProductsProvider();
            var productManager = new ProductsManager();
            var dummyManager = new ProductsManager();

            provider.ProductsManager = productManager;
            productManager.AddProduct(ProductsProvider.GetProducts("../../../Default Products new.txt"));
            provider.Save("../../../Test Save File.txt");
            dummyManager.AddProduct(ProductsProvider.GetProducts("../../../Test Save File.txt"));

            productManager.Products.Should().BeEquivalentTo(dummyManager.Products);

            ProductPrinter.Print(dummyManager.Products);
        }

        [TestCase("1123-123", "Beans", "Green", 100, -1, "2020, 1, 4", "2021, 3, 4", 90, 20)]
        [TestCase("1123-124", "Sandwich", "Green", 20, 0, "2020, 1, 4", "2021, 3, 4", 30, -11)]
        [TestCase("1123-125", "Apple", "Green", 100, 0, "2020, 1, 4", "2019, 3, 4", 60, 20)]
        [TestCase(null, "Paper", "Green", 100, 0, "2020, 1, 4", "2021, 3, 4", 35, 20)]
        [TestCase("1123-155", "Bed", "Green", -100, 0, "2020, 1, 4", "2021, 3, 4", 35, 20)]
        [TestCase("1123-986", "Pad", "Green", 800, 0, "2020, 1, 4", "2021, 3, 4", -35, 20)]
        public void AddProduct_SetInvalidValues_ThrowError(string id, string name, string description, float price, float discount, string dateAdded, string expiryDate, float restockPrice, int quantity)
        {
            var productManager = new ProductsManager();

            productManager.AddProduct(ProductsProvider.GetProducts("../../../Default Products new.txt"));
            var p = new Product(id, name, description, price, discount, DateTime.Parse(dateAdded), DateTime.Parse(expiryDate), restockPrice, quantity);
            Action act = () =>
            {
                productManager.AddProduct(p);
            };
            //assert
            act.Should().Throw<InvalidOperationException>();
        }
        [Test]
        public void AddProduct_SetInvalidID_ThrowError()
        {
            //arrange
            var productManager = new ProductsManager();
            //act
            productManager.AddProduct(ProductsProvider.GetProducts("../../../Default Products new.txt"));
            var p = new Product("1123-125", "Apple", "Green", 100, 0, new DateTime(2020, 1, 4), new DateTime(2021, 3, 4), 60, 20);
            var p2 = new Product("1123-125", "Orange", "Fresh", 100, 0, new DateTime(2020, 1, 4), new DateTime(2021, 3, 4), 60, 20);
            Action act = () =>
            {
                productManager.AddProduct(p);
                productManager.AddProduct(p2);
            };

            //assert
            act.Should().Throw<InvalidOperationException>().WithMessage("Id already exists");
        }
        [Test]
        public void RemoveProduct_RemoveInvalidItem_ThrowError()
        {
            //arrange
            var productManager = new ProductsManager();

            //act
            Product dummy = new Product("1123-125", "Orange", "Fresh", 100, 0, new DateTime(2020, 1, 4), new DateTime(2021, 3, 4), 60, 20);
            productManager.AddProduct(ProductsProvider.GetProducts("../../../Default Products new.txt"));

            Action act = () =>
            {
                productManager.RemoveProduct(dummy);
            };

            //assert
            act.Should().Throw<InvalidOperationException>();
        }
        [Test]
        public void ChangeDiscountAmount_SetInvalidAmount_ThrowError()
        {
            var productManager = new ProductsManager();

            //act
            float newDiscount = -0.12f;
            productManager.AddProduct(ProductsProvider.GetProducts("../../../Default Products new.txt"));

            Action act = () =>
            {
                productManager.ChangeDiscountAmount(productManager.Products[0],newDiscount);
            };

            //assert
            act.Should().Throw<InvalidOperationException>();
        }
        [Test]
        public void ChangeDiscountAmount_SetInvalidProduct_ThrowError()
        {
            var productManager = new ProductsManager();

            //act
            float newDiscount = 0.12f;
            Product dummy = new Product("1123-125", "Orange", "Fresh", 100, 0, new DateTime(2020, 1, 4), new DateTime(2021, 3, 4), 60, 20);
            productManager.AddProduct(ProductsProvider.GetProducts("../../../Default Products new.txt"));

            Action act = () =>
            {
                productManager.ChangeDiscountAmount(dummy, newDiscount);
            };

            //assert
            act.Should().Throw<InvalidOperationException>();
        }
        [Test]
        public void RestockAndBulkRestock_SetInvalidAmount_ThrowError()
        {
            var productManager = new ProductsManager();

            //act
            int amount = -1;
            productManager.AddProduct(ProductsProvider.GetProducts("../../../Default Products new.txt"));

            Action act = () =>
            {
                productManager.BulkRestock(productManager.Products, amount);
            };

            //assert
            act.Should().Throw<InvalidOperationException>();
        }
    }
}
