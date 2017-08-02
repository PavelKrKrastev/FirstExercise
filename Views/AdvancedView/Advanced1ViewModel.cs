using NemetschekFirstAssigment.ViewModel;
using System;
using System.Collections.ObjectModel;

namespace NemetschekFirstAssigment.Views.AdvancedView
{
    class Advanced1ViewModel : GeneralViewModel
    {
        public ObservableCollection<String> LanguageMode { get; set; }

        public ObservableCollection<String> PowerMode { get; set; }

        public ObservableCollection<String> BatteryMode { get; set; }

        public Advanced1ViewModel()
        {
            LanguageMode = new ObservableCollection<string> {AdvancedComboBox1Item1, AdvancedComboBox1Item2 };
            PowerMode = new ObservableCollection<string> { AdvancedComboBox2Item1, AdvancedComboBox2Item2 };
            BatteryMode = new ObservableCollection<string> { AdvancedComboBox3Item1, AdvancedComboBox3Item2 };
        }
    }
}
