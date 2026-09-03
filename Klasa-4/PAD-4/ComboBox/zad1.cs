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

namespace zad1
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

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxItem dzialanie = (ComboBoxItem)comboBox.SelectedItem;
            double a, b;

            if (!double.TryParse(number1.Text, out a) || !double.TryParse(number2.Text, out b))
            {
                MessageBox.Show("Nieprawidłowy format danych");
                return;
            }

            switch (dzialanie.Content)
            {
                case "-":
                    resultBox.Text = (a - b).ToString();
                    break;
                case "+":
                    resultBox.Text = (a + b).ToString();
                    break;
                case "*":
                    resultBox.Text = (a * b).ToString();
                    break;
                case "/":
                    if (b == 0)
                    {
                        MessageBox.Show("Nie mozńa dzielić przez 0");
                    }
                    else
                    {
                        resultBox.Text = (a / b).ToString();
                    }
                    break;

            }
        }
    }
}
