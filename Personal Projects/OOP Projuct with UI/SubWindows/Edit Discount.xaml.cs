using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace OOP_Projuct_with_UI.SubWindows
{
    /// <summary>
    /// Interaction logic for Edit_Discount.xaml
    /// </summary>
    public partial class Edit_Discount : Window
    {
        private Product _productToChange = null;
        public Edit_Discount()
        {
            InitializeComponent();
        }
        public Edit_Discount(Product product) : this()
        {
            _productToChange = product;
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                try
                {
                    var productManager = new ProductsManager();
                    var productProvider = new ProductsProvider();
                    productProvider.ProductsManager = productManager;
                    productManager.AddProduct(ProductsProvider.GetProducts("../../../Default Products new.txt"));
                    productManager.ChangeDiscountAmount(productManager.Products.Find(item => item.Id == _productToChange.Id), float.Parse(TxtBoxNewDiscount.Text)/100f);
                    productProvider.Save("../../../Default Products new.txt");
                    var window = new MainWindow();
                    window.Show();
                    Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid Input!");
                    var window = new MainWindow();
                    window.Show();
                    Close();
                }
            }

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            TxtBlkProductInfo.Text = $"Product {_productToChange.Id}: {_productToChange.Name}\n Current Discount: {_productToChange.Discount * 100}";
        }
    }
}
