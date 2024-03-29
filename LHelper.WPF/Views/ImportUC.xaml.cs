﻿using CsvHelper;
using LHelper.Models;
using LHelper.Services;
using LHelper.WPF.ViewModels;
using Microsoft.Win32;
using Newtonsoft.Json;
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
            //var filePath = string.Empty;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "JSON Files (*.json)|*.json";


            //openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == true)
            {
                string filePath = openFileDialog.FileName;
              
                

                if (importUCViewModel.system_Settings.Language == "English")
                {

                    StreamReader r = new StreamReader(filePath);
                    string json = r.ReadToEnd();
                    List<EnglishWordsModel> data = JsonConvert.DeserializeObject<List<EnglishWordsModel>>(json);
                    Console.WriteLine(data.Count);

                    for(int i=0; i<data.Count; i++)
                    {
                        //Console.WriteLine(data[i].Word);
                        string word=data[i].Word;
                        string translate=data[i].Translate;
                        string help_sentence=data[i].HelpSentence;

                        EnglishWordsModel NewEnglishwWord = new EnglishWordsModel { Word = word, Translate = translate, HelpSentence = help_sentence };
                        

                        englishWordsServices.AddANewEnglisWord(NewEnglishwWord);
                    }
                    



                }

            }
        }

        private void Single_World_Click(object sender, RoutedEventArgs e)
        {
            word_tb.Text = "";
            translate_tb.Text = "";
            hel_tb.Text = "";

            one_word_panel.Visibility = Visibility.Visible;
        }

        private void visibility_back_one_word_panel(object sender, RoutedEventArgs e)
        {
            one_word_panel.Visibility = Visibility.Hidden;
        }

        private void save_back_one_word_panel(object sender, RoutedEventArgs e)
        {
            string word = word_tb.Text;
            string translate = translate_tb.Text;
            string help_sentence = hel_tb.Text;

            if (word == "" && translate == "")
            {
                MessageBox.Show("No new word");
                one_word_panel.Visibility = Visibility.Hidden;
            }
            else
            {

                EnglishWordsModel NewEnglishwWord = new EnglishWordsModel { Word = word, Translate = translate, HelpSentence = help_sentence };

                englishWordsServices.AddANewEnglisWord(NewEnglishwWord);

                one_word_panel.Visibility = Visibility.Hidden;
            }
        }
    }
}
