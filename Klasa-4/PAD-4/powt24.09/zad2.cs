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

namespace powtZad1
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

        private void toggleChanged(object sender, RoutedEventArgs e)
        {
            int counter = 0;
            double suma = 0;

            string wynik = "Wybrane usługi:\n";

            if (Malowanie.IsChecked == true)
            {
                counter++;
                suma += 400;
                wynik += "Malowanie - 400 zł\n";
            }

            if (PrzygotowaniePodloza.IsChecked == true)
            {
                counter++;
                suma += 100;
                wynik += "Przygotowanie podłoża - 100 zł\n";
            }

            if (InstalacjeElektryczne.IsChecked == true)
            {
                counter++;
                suma += 500;
                wynik += "Wykonanie instalacji elektrycznej - 500 zł\n";
            }

            if (MontazGniazdek.IsChecked == true)
            {
                counter++;
                suma += 150;
                wynik += "Montaż gniazdek - 150 zł\n";
            }

            if (PodlaczenieUrzadzen.IsChecked == true)
            {
                counter++;
                suma += 300;
                wynik += "Podłączenie urządzeń - 300 zł\n";
            }


            if (counter == 0)
            {
                ResultBlock.Text = "Musisz wybrać co najmniej jedną usługę";
                ResultBlock.Foreground = Brushes.Red;
                ResultBlock.TextDecorations = TextDecorations.Underline;

                return;
            }


            if (counter >= 4)
            {
                suma = suma * 0.90;

                wynik += $"\nŁączny koszt wybranych usług - {suma:0.00} zł\n";
                wynik += "Podane ceny zawierają rabat 10%";

                ResultBlock.Text = wynik;
                ResultBlock.Foreground = Brushes.Green;
                ResultBlock.TextDecorations = null;
            }
            else
            {
                wynik += $"\nŁączny koszt wybranych usług - {suma:0.00} zł";

                ResultBlock.Text = wynik;
                ResultBlock.Foreground = Brushes.Black;
                ResultBlock.TextDecorations = null;
            }
        }

    }
}
