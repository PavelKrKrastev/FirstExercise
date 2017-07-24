using NemetschekFirstAssigment.ViewModel.MainViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NemetschekFirstAssigment.ViewModel.UserControlViewModels
{
    class Advanced1ViewModel : BaseViewModel
    {

        private ObservableCollection<String> _languageMode;

        public ObservableCollection<String> LanguageMode
        {
            get { return _languageMode; }
            set
            {
                _languageMode = value;
                RaisePropertyChangedEvent("LanguageMode");
            }
        }

        private ObservableCollection<String> _powerMode;

        public ObservableCollection<String> PowerMode
        {
            get { return _powerMode; }
            set
            {
                _powerMode = value;
                RaisePropertyChangedEvent("PowerMode");
            }
        }

        private ObservableCollection<String> _batteryMode;

        public ObservableCollection<String> BatteryMode
        {
            get { return _batteryMode; }
            set
            {
                _batteryMode = value;
                RaisePropertyChangedEvent("BatteryMode");
            }
        }

        public Advanced1ViewModel()
        {
            LanguageMode = new ObservableCollection<string> { "English", "Spanish", "German", "French" };
            PowerMode = new ObservableCollection<string> { "Power Saver", "Balanced", "High Performance" };
            BatteryMode = new ObservableCollection<string> { "Maximum battery life", "Optimized battery health", "Stamina" };
        }

    }
}
