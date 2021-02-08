using CsvHelper;
using LHelper.Models;
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
            
            
            //openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == true)
            {
                filePath = openFileDialog.FileName;

                if (importUCViewModel.system_Settings.Language == "English")
                {
                    var reader = new StreamReader(filePath);

                    using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                    {
                        var records = csv.GetRecords<EnglishWordsModel>();

                        records = new List<EnglishWordsModel>();
                        
                        foreach (EnglishWordsModel i in records)
                        {
                            Console.Write("{0}\t", i.ToString());
                        }
                        Console.WriteLine();
                    }

                }
              
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
