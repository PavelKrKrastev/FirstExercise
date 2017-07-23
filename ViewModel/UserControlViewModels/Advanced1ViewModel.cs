using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NemetschekFirstAssigment.ViewModel.UserControlViewModels
{
    class Advanced1ViewModel
    {

        public ObservableCollection<String> LanguageMode { get; set; }

        public ObservableCollection<String> PowerMode { get; set; }

        public ObservableCollection<String> BatteryMode { get; set; }

        public Advanced1ViewModel()
        {
            LanguageMode = new ObservableCollection<string> { "English", "Spanish", "German", "French" };
            PowerMode = new ObservableCollection<string> { "Power Saver", "Balanced", "High Performance" };
            BatteryMode = new ObservableCollection<string> { "Maximum battery life", "Optimized battery health", "Stamina" };
        }

    }
}
