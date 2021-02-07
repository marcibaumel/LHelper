using LHelper.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LHelper.WPF.Navigators
{
    public enum ViewType
    {
        Menu,
        Import,
        Export
    }

    /*
     * Implementálandó, hogy elérhessük a ViewModel-t 
     */

    public interface INavigator
    {
        ViewModelBase CurrentViewModel { get; set; }
        ICommand UpdateCurrentViewModelCommand { get; }
    }
}
