using LHelper.WPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LHelper.WPF.ViewModels
{
    public class ViewModelBase
    {
        public System_Settings system_Settings { get; set; } = new System_Settings();
    }
}
