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

namespace zad2
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

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            ComboBoxItem dzialanie = (ComboBoxItem)comboBox.SelectedItem;
            double a, b;
            if(dzialanie.Content == "--Wybierz--")
            {
                return;
            }

            if (!double.TryParse(A.Text, out a) || !double.TryParse(B.Text, out b))
            {
                MessageBox.Show("Nieprawidłowy format danych");
                return;
            }

            switch (dzialanie.Content)
            {
                case "Pole":
                    result.Text = (a * b).ToString();
                    break;
                case "Obwod":
                    result.Text = ((a + b)*2).ToString();
                    break;
            }
        }
    }
}
