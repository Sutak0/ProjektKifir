using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class UjDiak : Window
    {
        public UjDiak()
        {
            InitializeComponent();
        }

        private void LeaveButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
           
                string omAzonosito = OMAzonosito.Text; 
                string nev = Nev.Text;
                string ertesitescim = Ertesitescim.Text;
                string szuletesiDatum = SzuletesiDatum.Text; 
                string elerhetosegEmail = ElerhetosegEmail.Text;
                string matekPontszam = MatekPontszam.Text; 
                string magyarPontszam = MagyarPontszam.Text; 

                if (string.IsNullOrWhiteSpace(omAzonosito) || string.IsNullOrWhiteSpace(nev))
                {
                    MessageBox.Show("Az OM azonosító és Név mezőt kötelező kitölteni.");
                    return;
                }

                string collectedData = $"OM azonosító: {omAzonosito}\nNév: {nev}\nÉrtesítési cím: {ertesitescim}\nSzületési dátum: {szuletesiDatum}\nElérhetőség email: {elerhetosegEmail}\nMatek pontszám: {matekPontszam}\nMagyar pontszám: {magyarPontszam}";

                MessageBox.Show($"Sikeres mentés! A mentett adat: \n {collectedData}");

            if (!int.TryParse(omAzonosito, out int _) || omAzonosito.Length > 11)
            {
                MessageBox.Show("OM Azonosító meghaladja a 11 betűt.");
                return;
            }

            if (nev.Length > 45)
            {
                MessageBox.Show("Név megaladja a 45 betűt.");
                return;
            }

            if (ertesitescim.Length > 120)
            {
                MessageBox.Show("Értesítési cím meghaladja a 120 betűt.");
                return;
            }

            if (elerhetosegEmail.Length > 40)
            {
                MessageBox.Show("Elérhetőség meghaladja a 40 betűt.");
                return;
            }

            if (!int.TryParse(matekPontszam, out int matekPont) || matekPont < 0 || matekPont > 50)
            {
                MessageBox.Show("Matek pontszám nem lehet 50-nél nagyobb.");
                return;
            }

            if (!int.TryParse(magyarPontszam, out int magyarPont) || magyarPont < 0 || magyarPont > 50)
            {
                MessageBox.Show("Magyar pontszám nem lehet 50-nél nagyobb.");
                return;
            }

            DateTime? selectedDate = SzuletesiDatum.SelectedDate;
            if (!selectedDate.HasValue)
            {
                MessageBox.Show("Nem jó dátumot választottál.");
                return;
            }
            string szuletesiDatumValaszto = selectedDate.Value.ToString("yyyy-MM-dd");

        }
    }
}
            