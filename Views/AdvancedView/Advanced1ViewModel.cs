using NemetschekFirstAssigment.ViewModel;
using System;
using System.Collections.ObjectModel;

namespace NemetschekFirstAssigment.Views.AdvancedView
{
    class Advanced1ViewModel : GeneralViewModel
    {
        public string AdvancedComboBox1Item1
        {
            get { return gModel.AdvancedComboBox1Item1; }
            set { AdvancedComboBox1Item1 = gModel.AdvancedComboBox1Item1; RaisePropertyChangedEvent("AdvancedComboBox1Item1"); }
        }

        public string AdvancedComboBox1Item2
        {
            get { return gModel.AdvancedComboBox1Item2; }
            set { AdvancedComboBox1Item2 = gModel.AdvancedComboBox1Item2; RaisePropertyChangedEvent("AdvancedComboBox1Item2"); }
        }

        public string AdvancedComboBox2Item1
        {
            get { return gModel.AdvancedComboBox2Item1; }
            set { AdvancedComboBox2Item1 = gModel.AdvancedComboBox2Item1; RaisePropertyChangedEvent("AdvancedComboBox2Item1"); }
        }

        public string AdvancedComboBox2Item2
        {
            get { return gModel.AdvancedComboBox2Item2; }
            set { AdvancedComboBox2Item2 = gModel.AdvancedComboBox2Item2; RaisePropertyChangedEvent("AdvancedComboBox2Item2"); }
        }

        public string AdvancedComboBox3Item1
        {
            get { return gModel.AdvancedComboBox3Item1; }
            set { AdvancedComboBox3Item1 = gModel.AdvancedComboBox3Item1; RaisePropertyChangedEvent("AdvancedComboBox3Item1"); }
        }

        public string AdvancedComboBox3Item2
        {
            get { return gModel.AdvancedComboBox3Item2; }
            set { AdvancedComboBox3Item2 = gModel.AdvancedComboBox3Item2; RaisePropertyChangedEvent("AdvancedComboBox3Item2"); }
        }

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
