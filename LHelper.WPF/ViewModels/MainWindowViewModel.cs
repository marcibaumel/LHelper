using LHelper.WPF.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace LHelper.WPF.ViewModels
{
    public class MainWindowViewModel: ViewModelBase
    {
        public Page mainMenu = new MainMenuPage();
    }
}
