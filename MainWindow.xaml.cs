using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Microsoft.Win32; 

namespace WpfApp8
{
    /// <summary>
    /// Interaction logic for UjDiak.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public MainWindow(string text)
        {
            this.Title = text;
        }
        private void NewStudentButton_Click(object sender, RoutedEventArgs e)
        {
            UjDiak hozzaadott = new UjDiak();
            hozzaadott.ShowDialog();
        }

        private void RemoveStudent_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void ImportCsvButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*",
                Title = "Válassz egy fájlt, amit importálni szeretnél."
            };

            if (openFileDialog.ShowDialog() == true)
            {
                try
                {
                    string filePath = openFileDialog.FileName;

                    string[] csvLines = File.ReadAllLines(filePath);

                    foreach (string line in csvLines)
                    {
                        string[] fields = line.Split(',');

                   
                    }

                    MessageBox.Show("Sikeres importálás.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hiba! {ex.Message}");
                }
            }
        }
    }
}
