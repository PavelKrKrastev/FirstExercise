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
            set { gModel.AdvancedComboBox1Item1 = value; RaisePropertyChangedEvent("AdvancedComboBox1Item1"); }
        }

        public string AdvancedComboBox1Item2
        {
            get { return gModel.AdvancedComboBox1Item2; }
            set { gModel.AdvancedComboBox1Item2 = value; RaisePropertyChangedEvent("AdvancedComboBox1Item2"); }
        }

        public string AdvancedComboBox2Item1
        {
            get { return gModel.AdvancedComboBox2Item1; }
            set { gModel.AdvancedComboBox2Item1 = value; RaisePropertyChangedEvent("AdvancedComboBox2Item1"); }
        }

        public string AdvancedComboBox2Item2
        {
            get { return gModel.AdvancedComboBox2Item2; }
            set { gModel.AdvancedComboBox2Item2 = value; RaisePropertyChangedEvent("AdvancedComboBox2Item2"); }
        }

        public string AdvancedComboBox3Item1
        {
            get { return gModel.AdvancedComboBox3Item1; }
            set { gModel.AdvancedComboBox3Item1 = value; RaisePropertyChangedEvent("AdvancedComboBox3Item1"); }
        }

        public string AdvancedComboBox3Item2
        {
            get { return gModel.AdvancedComboBox3Item2; }
            set { gModel.AdvancedComboBox3Item2 = value; RaisePropertyChangedEvent("AdvancedComboBox3Item2"); }
        }

        public string AdvancedComboBox1SelectedItem
        {
            get { return gModel.AdvancedComboBox1SelectedItem; }
            set { gModel.AdvancedComboBox1SelectedItem = value; RaisePropertyChangedEvent("AdvancedComboBox1SelectedItem"); }
        }

        public string AdvancedComboBox2SelectedItem
        {
            get { return gModel.AdvancedComboBox2SelectedItem; }
            set { gModel.AdvancedComboBox2SelectedItem = value; RaisePropertyChangedEvent("AdvancedComboBox2SelectedItem"); }
        }

        public string AdvancedComboBox3SelectedItem
        {
            get { return gModel.AdvancedComboBox3SelectedItem; }
            set { gModel.AdvancedComboBox3SelectedItem = value; RaisePropertyChangedEvent("AdvancedComboBox3SelectedItem"); }
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
