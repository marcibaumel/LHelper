using LHelper.WPF.Commands;
using LHelper.WPF.Navigators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace LHelper.WPF.ViewModels
{
    public class MainMenuPageViewModel: ViewModelBase
    {
        

        public INavigator Navigator { get; set; } = new Navigator();

        public Command ViewCommand;


        public MainMenuPageViewModel()
        {
            ViewCommand = new Command(ExecuteHomeView, CanExecuteHomeView);
        }



        public bool CanExecuteHomeView(object para)
        {
            return true;
        }

        public void ExecuteHomeView(object para)
        {
            Navigator.CurrentViewModel = new MenuUCViewModel();
        }
    }
}
