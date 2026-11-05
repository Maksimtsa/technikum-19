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

namespace WpfApp2
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
        private void TabControlKarty_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.Source is TabControl && TabControlKarty.SelectedItem == TabItemPodsumowanie)
            {
                OdswiezPodsumowanie();
            }
        }

        private void OdswiezPodsumowanie()
        {
            ComboBoxItem wybranyElement = CbPlec.SelectedItem as ComboBoxItem;
            DateTime? dataUrodzenia = DpDataUrodzenia.SelectedDate;

            string imie = TxtImie.Text.Trim();
            string nazwisko = TxtNazwisko.Text.Trim();
            string ulica = TxtUlica.Text.Trim();
            string nrDomu = TxtNrDomu.Text.Trim();
            string kodPocztowy = TxtKodPocztowy.Text.Trim();
            string miejscowosc = TxtMiejscowosc.Text.Trim();

            if (string.IsNullOrEmpty(imie) ||
                string.IsNullOrEmpty(nazwisko) ||
                string.IsNullOrEmpty(ulica) ||
                string.IsNullOrEmpty(nrDomu) ||
                string.IsNullOrEmpty(kodPocztowy) ||
                string.IsNullOrEmpty(miejscowosc) ||
                wybranyElement == null ||
                !dataUrodzenia.HasValue)
            {
                TxtBlockPodsumowanie.Text = "Musisz wypełnić wszystkie pola formularza";
                return;
            }
            string plec = wybranyElement.Content.ToString();
            string dataFormatowana = dataUrodzenia.Value.ToString("dd.MM.yyyy");

            TxtBlockPodsumowanie.Text = $"{imie} {nazwisko}\n" +
                                        $"Data urodzenia: {dataFormatowana}\n" +
                                        $"Płeć: {plec}\n" +
                                        $"Adres zamieszkania:\n" +
                                        $"ul. {ulica} {nrDomu}\n" +
                                        $"{kodPocztowy}, {miejscowosc}";
        }
    }
}
