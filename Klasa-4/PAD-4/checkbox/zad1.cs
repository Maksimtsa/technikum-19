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

namespace checkbox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Oblicz_Click(object sender, RoutedEventArgs e)
        {

            if (!double.TryParse(txtA.Text, out var a) || !double.TryParse(txtB.Text, out var b))
            {
                MessageBox.Show("Nieprawidłowy format danych", "Błąd");
                return;
            }
            double res;
            if (checkboxDodawanie.IsChecked == true)
            {
                res = a + b;
                result.Content += $"{a} + {b} = {res}\n";
            }
            if (checkboxOdejmowanie.IsChecked == true)
            {
                res = a - b;
                result.Content += $"{a} - {b} = {res}\n";
            }
            if (checkboxMnozenie.IsChecked == true)
            {
                res = a * b;
                result.Content += $"{a} * {b} = {res}\n";
            }
            if (checkboxDzielenie.IsChecked == true)
            {
                if(b != 0)
                {
                    res = a / b;
                    result.Content += $"{a} / {b} = {res}\n";
                }
                else
                {
                    MessageBox.Show("Nie można dzielić przez 0", "Błąd");
                }
            }
            
        }
    }
}
