using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHelper.WPF.ViewModels
{
    public class ShellViewModel : Screen
    {
        private string _firstName="Tim";

        public string FirstName
        {
            get 
            { 
                return _firstName; 
            }
            set 
            { 
                _firstName = value; 
            }
        }

    }
    
}
