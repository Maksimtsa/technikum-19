
using System;
using System.Windows;
using System.Windows.Controls;

namespace zad
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Zaktualizuj();
        }

        private void Zaktualizuj()
        {
            int wypelnione = 0;
            int wszystkie = 8;

            if (!string.IsNullOrWhiteSpace(name.Text))
                wypelnione++;

            if (!string.IsNullOrWhiteSpace(surname.Text))
                wypelnione++;

            if (dateOfBirth.SelectedDate.HasValue)
                wypelnione++;

            if (comboBoxPlec.SelectedItem != null)
                wypelnione++;

            if (!string.IsNullOrWhiteSpace(street.Text))
                wypelnione++;

            if (!string.IsNullOrWhiteSpace(numberHouse.Text))
                wypelnione++;

            if (!string.IsNullOrWhiteSpace(code.Text))
                wypelnione++;

            if (!string.IsNullOrWhiteSpace(city.Text))
                wypelnione++;

            int procent = (int)Math.Round((double)wypelnione / wszystkie * 100);

            progressBar.Value = procent;
            postep.Content = $"Postęp: {procent}%";
        }

        private void ZmianaWyboru(object sender, SelectionChangedEventArgs e)
        {
            Zaktualizuj();
        }

        private void ZmianaTekstu(object sender, TextChangedEventArgs e)
        {
            Zaktualizuj();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            name.Clear();
            surname.Clear();
            dateOfBirth.SelectedDate = null;
            comboBoxPlec.SelectedIndex = -1;

            street.Clear();
            numberHouse.Clear();
            code.Clear();
            city.Clear();

            textblock.Text = "";

            Zaktualizuj();
        }

        private void Podsumowanie_Click(
            object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name.Text) ||
                string.IsNullOrWhiteSpace(surname.Text) ||
                !dateOfBirth.SelectedDate.HasValue ||
                comboBoxPlec.SelectedItem == null ||
                string.IsNullOrWhiteSpace(street.Text) ||
                string.IsNullOrWhiteSpace(numberHouse.Text) ||
                string.IsNullOrWhiteSpace(code.Text) ||
                string.IsNullOrWhiteSpace(city.Text))
            {
                MessageBox.Show("Musisz podać wszystkie dane");

                textblock.Text = "";
                return;
            }

            string plec = ((ComboBoxItem)comboBoxPlec.SelectedItem).Content.ToString();

            string data = dateOfBirth.SelectedDate.Value.ToString("dd.MM.yyyy");

            textblock.Text =
                $"{name.Text} {surname.Text}\n" +
                $"Data urodzenia: {data}\n" +
                $"Płeć: {plec}\n" +
                $"Adres zamieszkania:\n" +
                $"{street.Text} {numberHouse.Text}\n" +
                $"{code.Text}, {city.Text}";
        }
    }
}
