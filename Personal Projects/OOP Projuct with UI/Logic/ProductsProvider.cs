﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;

namespace OOP_Projuct_with_UI
{
    public class ProductsProvider
    {
        public ProductsManager ProductsManager { get; set; }

        public static List<Product> GetProducts(string fileLocation)
        {
            var _file = File.Open(fileLocation, FileMode.Open);
            var reader = new StreamReader(_file);
            var data = reader.ReadToEnd();

            var products = new List<Product>();
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
                products.Add(product);
            }
            _file.Close();
            reader.Close();
            return products;
        }
        public void Save(string fileLocation)//save products to file
        {
            var _file = File.Open(fileLocation, FileMode.OpenOrCreate);
            _file.Close();
            _file = File.Open(fileLocation, FileMode.Truncate);
            var writer = new StreamWriter(_file);

            foreach (var item in ProductsManager.Products)
            {
                writer.Write($"{item.Id};{item.Name} - {item.Description};{item.OriginalPrice};{item.Discount};{item.DateAdded.Date};{item.ExpiryDate.Date};{item.RestockPrice};{item.Quantity}\n");
            }

            writer.Flush();
            writer.Close();
            _file.Close();
        }
    }
}
