using CsvHelper;
using LHelper.Models;
using LHelper.Services;
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
        private EnglishWordsServices englishWordsServices = new EnglishWordsServices();


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
                    string[] csvLines = System.IO.File.ReadAllLines(@filePath);
                    
                    
                    string word;
                    string translate;
                    string help_sentence;
                    
                    for (int i=0; i< csvLines.Length; i++)
                    {
                        string[] rowData = csvLines[i].Split(',');
                        word = rowData[0];
                        translate = rowData[1];
                        help_sentence = rowData[2];

                        List<EnglishWordsModel> englishWordsModelsList = new List<EnglishWordsModel>
                        {
                            new EnglishWordsModel {Word=word, HelpSentence=help_sentence, Translate=translate}
                        };
                        
                        //Read EnglishWords elements 
                        for (int g = 0; g < englishWordsModelsList.Count; g++)
                        {
                                                                                  
                            englishWordsServices.AddANewEnglisWord(englishWordsModelsList[g]);
                            
                        }


                    }

                }
              
            }
            
           
        }

        private void JSON_Click(object sender, RoutedEventArgs e)
        {
            var filePath = string.Empty;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "JSON Files (*.json)|*.json";


            //openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == true)
            {
                filePath = openFileDialog.FileName;

                if (importUCViewModel.system_Settings.Language == "English")
                {
                    
                   
                }

            }
        }

        private void Single_World_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
