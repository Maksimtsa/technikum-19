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

namespace powtZad2
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

        private void BtnOblicz_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(liczbaDni.Text, out int days) || days <= 0 || days > 365)
            {
                txtWynik.Text = "Błędne dane";
                txtWynik.Foreground = Brushes.Red;
                txtWynik.FontWeight = FontWeights.Bold;
            }

            double cena = 0;
            string cmb = cmbStrefa.Text;
            if (cmb == "A")
            {
                cena = days * 3.6;
            }
            else if (cmb == "A+B")
            {
                cena = days * 4.6;
            }
            else if (cmb == "A+B+C")
            {
                cena = days * 5.4;
            }


            if (radioUlgowy.IsChecked == true)
            {
                cena *= 0.5;
                txtWynik.Text = $"Łączny koszt biletu na {days} dni w stefie {cmb} wynosi {cena} zł";
            }
            else if (radioNormalny.IsChecked == true)
            {
                txtWynik.Text = $"Łączny koszt biletu na {days} dni w stefie {cmb} wynosi {cena} zł";
            }
        }
    }
}
