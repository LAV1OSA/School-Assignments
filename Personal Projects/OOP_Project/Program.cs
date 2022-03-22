using System;

var products = new ProductsProvider();
var productManager = new ProductsManager();
var display = new Display();
productManager.AddProduct(products.GetProducts("../../../Default Products new.txt"));
display.ProductsManager = productManager;
ProductPrinter.Print(productManager.Products);
Console.ReadLine();