using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHelper.WPF.ViewModels
{
    public class MenuUCViewModel:ViewModelBase
    {
        public MainWindowViewModel mainWindow = new MainWindowViewModel();
        public int Volume { get; set; } = 3;
        public int LanguageIndex{ get; set; } = 0;

        public string Language { get; set; } = "English";
    }
}
