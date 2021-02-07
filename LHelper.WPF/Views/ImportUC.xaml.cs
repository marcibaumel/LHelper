using CsvHelper;
using LHelper.WPF.ViewModels;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Globalization;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LHelper.WPF.Views
{
    /// <summary>
    /// Interaction logic for ImportUC.xaml
    /// </summary>
    public partial class ImportUC : UserControl
    {
        private ImportUCViewModel importUCViewModel = new ImportUCViewModel();
        

        public ImportUC()
        {
            InitializeComponent();
        }

        private void CSV_Click(object sender, RoutedEventArgs e)
        {
            var filePath = string.Empty;
            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "CSV Files (*.csv)|*.csv";
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == true)
            {
                //Get the path of specified file
                filePath = openFileDialog.FileName;
                //using (var csv = new CsvReader(filePath, CultureInfo.InvariantCulture))
                //{
                //    var records = csv.GetRecords<Foo>();
                //}

            }
        }

        private void JSON_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Single_World_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
