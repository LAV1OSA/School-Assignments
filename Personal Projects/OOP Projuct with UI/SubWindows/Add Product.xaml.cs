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
    /// Interaction logic for Add_Product.xaml
    /// </summary>
    public partial class Add_Product : Window
    {
        public Add_Product()
        {
            InitializeComponent();
        }

        private void BtnAddExit_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                Product product = new Product(
                TxtBoxIDinput.Text,
                TxtBoxNameInput.Text,
                TxtBoxDescriptionInput.Text,
                float.Parse(TxtBoxOriginalPriceInput.Text),
                float.Parse(TxtBoxDiscountInput.Text) / 100f,
                DateTime.Now,
                DateTime.Parse(TxtBoxExpiryDateInput.Text),
                float.Parse(TxtBoxRestockPriceInput.Text),
                int.Parse(TxtBoxQuantityInput.Text)
                );
                var window = new MainWindow(product);
                window.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Input/s!");
                var window = new MainWindow();
                window.Show();
            }
            Close();
        }
    }
}
