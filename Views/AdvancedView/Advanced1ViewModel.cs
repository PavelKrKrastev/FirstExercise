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

            #region Add to LanguageMode
            var comboBox1Items = Doc.Descendants("ComboBox1Item");

            this.LanguageMode = new ObservableCollection<String>();

            foreach (var item in comboBox1Items)
            {
                LanguageMode.Add(item.Value);
            }
            #endregion

            #region Add to PowerMode
            var comboBox2Items = Doc.Descendants("ComboBox2Item");

            this.PowerMode = new ObservableCollection<string>();

            foreach (var item in comboBox2Items)
            {
                PowerMode.Add(item.Value);
            }
            #endregion

            #region Add to BatteryMode
            var comboBox3Items = Doc.Descendants("ComboBox3Item");

            this.BatteryMode = new ObservableCollection<string>();

            foreach (var item in comboBox3Items)
            {
                BatteryMode.Add(item.Value);
            }
            #endregion
        }
    }
}
