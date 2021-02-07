using LHelper.WPF.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace LHelper.WPF.ViewModels
{
    public class MainWindowViewModel: ViewModelBase
    {
        public Page mainMenu = new MainMenuPage();
        public Window mainWindow { get; set; } = Application.Current.MainWindow;
    }
}
