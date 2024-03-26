using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfListViewApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Product> products = new List<Product>()
        {
            new(){ Title = "Phone", Company = "Samsung", Price = 12345.78M },
            new(){ Title = "Tv", Company = "Lg", Price = 5000.00M },
            new(){ Title = "Notebook", Company = "Asus", Price = 45000.50M, IsEmpty = true },
            new(){ Title = "Computer", Company = "HP", Price = 65700M },
            new(){ Title = "Clock", Company = "Apple", Price = 22000M },
        };
        public MainWindow()
        {
            InitializeComponent();

            listProds.ItemsSource = products;
            gridProds.ItemsSource = products;
        }
    }
}