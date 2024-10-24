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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
     class Car
    {
        public string Mileage { get; set; }
        public string Color { get; set; }
        private string Car_brand;
        private string Car_Model;
        private string Year_of_release;

    }/// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Car car1 = new Car();
            Car car2 = new Car();
        }
    }

   

}