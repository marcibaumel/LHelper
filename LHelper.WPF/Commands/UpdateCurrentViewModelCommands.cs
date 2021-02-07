using LHelper.WPF.Navigators;
using LHelper.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LHelper.WPF.Commands
{
    class UpdateCurrentViewModelCommands : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private INavigator _navigator;

        /*
         * Kapot érték alapján generál egy új ViewModel-t
         */

        public UpdateCurrentViewModelCommands(INavigator navigator)
        {
            _navigator = navigator;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            /*
             * Kapott paraméter alapján eldönti melyiket is kell betölteni
             */

            if (parameter is ViewType)
            {
                ViewType viewType = (ViewType)parameter;

                /*
                 * Kapott view type alapján az aktuális view modellen változtatunk
                 */

                switch (viewType)
                {
                    case ViewType.Menu:
                        _navigator.CurrentViewModel = new MenuUCViewModel();
                        break;
                    case ViewType.Import:
                        _navigator.CurrentViewModel = new ImportUCViewModel();
                        break;
                    case ViewType.Export:
                        _navigator.CurrentViewModel = new ExportUCViewModel();
                        break;

                }
            }
        }
    }
}
