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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OOP_Projuct_with_UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ProductsProvider ProductsProvider = new ProductsProvider();
        public ProductsManager ProductManager = new ProductsManager();
        public Display Display = new Display();
        public ProductSearcher ProductSearcher = new ProductSearcher();
        private Product PassedProduct;
        int currentPage = 1;
        double maxPages = 100;

        public MainWindow()
        {
            InitializeComponent();
        }
        public MainWindow(Product product) : this()
        {
            PassedProduct = product;
            ProductManager.AddProduct(product);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            int[] setItemsPerPAge = {5, 10, 25, 50};

            ProductManager.AddProduct(ProductsProvider.GetProducts("../../../Default Products new.txt"));
            ProductsProvider.ProductsManager = ProductManager;
            Display.ProductsManager = ProductManager;
            ProductSearcher.ProductsManager = ProductManager;
            ProductSearcher.Display = Display;

            foreach (var item in ProductManager.Products)
            {
                LstProducts.Items.Add(item);
            }

            CmbItemsPerPage.ItemsSource = setItemsPerPAge;
            CmbItemsPerPage.SelectedIndex = 3;

            maxPages = Math.Ceiling((double)Display.ProductsToPage.Count / Convert.ToInt32(CmbItemsPerPage.Text));
        }

        private void BtnPreviousPage_Click(object sender, RoutedEventArgs e)
        {
            if (currentPage == 1) ;
            else
            {
                currentPage -= 1;
                Display.Pager(currentPage, Convert.ToInt32(CmbItemsPerPage.Text));
                LstProducts.Items.Clear();
                foreach (var item in Display.ProductsOnPage)
                {
                    LstProducts.Items.Add(item);
                }
                maxPages = Math.Ceiling((double)Display.ProductsToPage.Count / Convert.ToInt32(CmbItemsPerPage.SelectedValue.ToString()));
                LstProducts.Items.Refresh();
                TxtBlkPage.Text = $"Page {currentPage} of {maxPages}";

            }
        }

        private void BtnNextPage_Click(object sender, RoutedEventArgs e)
        {
            if (currentPage >= maxPages) currentPage = (int)maxPages;
            else
            {
                currentPage += 1;
                Display.Pager(currentPage, Convert.ToInt32(CmbItemsPerPage.Text));
                LstProducts.Items.Clear();
                foreach (var item in Display.ProductsOnPage)
                {
                    LstProducts.Items.Add(item);
                }
                maxPages = Math.Ceiling((double)Display.ProductsToPage.Count / Convert.ToInt32(CmbItemsPerPage.SelectedValue.ToString()));
                LstProducts.Items.Refresh();
                TxtBlkPage.Text = $"Page {currentPage} of {maxPages}";

            }
        }

        private void BtnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            var window = new SubWindows.Add_Product();
            ProductsProvider.Save("../../../Default Products new.txt");
            window.Show();
            Close();
        }

        private void BtnRemoveProduct_Click(object sender, RoutedEventArgs e)
        {
            if (LstProducts.SelectedIndex == -1) ;
            else
            {
                try
                {
                    ProductManager.RemoveProduct(Display.ProductsOnPage[LstProducts.SelectedIndex]);
                }
                catch (Exception)
                {
                    MessageBox.Show("Product Does Not Exist!");
                }
            }
            UpdateView();
        }

        private void BtnEditDiscount_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var window = new SubWindows.Edit_Discount(Display.ProductsOnPage[LstProducts.SelectedIndex]);
                ProductsProvider.Save("../../../Default Products new.txt");
                window.Show();
                Close();

            }
            catch (Exception)
            {
                MessageBox.Show("No Item Selected");
            }
        }
        private void BtnSaveAndExit_Click(object sender, RoutedEventArgs e)
        {
            ProductsProvider.Save("../../../Default Products new.txt");
            Close();
        }

        private void CmbItemsPerPage_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Display.Pager(1, Convert.ToInt32(CmbItemsPerPage.SelectedValue.ToString()));
            UpdateView();
        }

        private void TxtBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                ProductSearcher.Search(TxtBoxSearch.Text);
                UpdateView();
            }
           
        }

        private void BtnId_Click(object sender, RoutedEventArgs e)
        {
            ProductManager.Sorter(BtnId.Content.ToString());
            Display.ProductsToPage = ProductManager.Products;
            UpdateView();
        }

        private void BtnName_Click(object sender, RoutedEventArgs e)
        {
            ProductManager.Sorter(BtnName.Content.ToString());
            Display.ProductsToPage = ProductManager.Products;
            UpdateView();

        }

        private void BtnDescription_Click(object sender, RoutedEventArgs e)
        {
            ProductManager.Sorter(BtnDescription.Content.ToString());
            Display.ProductsToPage = ProductManager.Products;
            UpdateView();

        }

        private void BtnPrice_Click(object sender, RoutedEventArgs e)
        {
            ProductManager.Sorter(BtnPrice.Content.ToString());
            Display.ProductsToPage = ProductManager.Products;
            UpdateView();
        }

        private void BtnRestock_Click(object sender, RoutedEventArgs e)
        {
            ProductManager.Sorter(BtnRestock.Content.ToString());
            Display.ProductsToPage = ProductManager.Products;
            UpdateView();
        }

        private void BtnQuantity_Click(object sender, RoutedEventArgs e)
        {
            ProductManager.Sorter(BtnQuantity.Content.ToString());
            Display.ProductsToPage = ProductManager.Products;
            UpdateView();
        }

        public void UpdateView()
        {
            currentPage = 1;
            LstProducts.Items.Clear();
            Display.Pager(currentPage, Convert.ToInt32(CmbItemsPerPage.SelectedItem.ToString()));
            foreach (var item in Display.ProductsOnPage)
            {
                LstProducts.Items.Add(item);
            }
            maxPages = Math.Ceiling((double)Display.ProductsToPage.Count / Convert.ToInt32(CmbItemsPerPage.SelectedValue.ToString()));
            LstProducts.Items.Refresh();
            TxtBlkPage.Text = $"Page {currentPage} of {maxPages}";
        }
    }
}
