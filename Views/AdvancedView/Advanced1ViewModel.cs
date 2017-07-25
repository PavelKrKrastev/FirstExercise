using NemetschekFirstAssigment.ViewModels;
using System;
using System.Collections.ObjectModel;

namespace NemetschekFirstAssigment.Views.AdvancedView
{
    class Advanced1ViewModel : BaseViewModel
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
