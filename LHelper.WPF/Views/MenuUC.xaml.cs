using LHelper.WPF.Models;
using LHelper.WPF.ViewModels;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for MenuUC.xaml
    /// </summary>
    public partial class MenuUC : UserControl
    {
        public MenuUCViewModel menuUCViewModel = new MenuUCViewModel();
        
        public MenuUC()
        {
            InitializeComponent();
            Volume_ComboBox.SelectedIndex = menuUCViewModel.system_Settings.Volume;
            Language_ComboBox.SelectedIndex = menuUCViewModel.system_Settings.LanguageIndex;



        }

       

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            menuUCViewModel.mainWindow.mainWindow.Close();
        }

        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            Settings_Panel.Visibility = Visibility.Visible;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Settings_Panel.Visibility = Visibility.Hidden;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            Settings_Panel.Visibility = Visibility.Hidden;
        }

        private void Volume_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                string VolumeValue = Volume_ComboBox.SelectedItem.ToString();
                int newVolumeValue = int.Parse(VolumeValue);
                menuUCViewModel.system_Settings.Volume = newVolumeValue;
            }
            catch (Exception ex)
            {

            }            
        }

        private void Language_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                string LanguageValue = Language_ComboBox.SelectedItem.ToString();
                int newLanguageValue = int.Parse(LanguageValue);
                menuUCViewModel.system_Settings.LanguageIndex = newLanguageValue;
                menuUCViewModel.system_Settings.Language = LanguageValue;

            }
            catch (Exception ex)
            {

            }
        }
    }
}
