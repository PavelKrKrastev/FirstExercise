using NemetschekFirstAssigment.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Xml.Linq;

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
            var comboBox1Items = Doc.Root.Elements("Advanced").Elements("ComboBox1Item");

            this.LanguageMode = new ObservableCollection<String>();

            foreach (var item in comboBox1Items)
            {
                LanguageMode.Add(item.Attribute("Content").Value);
            }
            #endregion

            #region Add to PowerMode
            var comboBox2Items = Doc.Root.Elements("Advanced").Elements("ComboBox2Item");

            this.PowerMode = new ObservableCollection<string>();

            foreach (var item in comboBox2Items)
            {
                PowerMode.Add(item.Attribute("Content").Value);
            }
            #endregion

            #region Add to BatteryMode
            var comboBox3Items = Doc.Root.Elements("Advanced").Elements("ComboBox3Item");

            this.BatteryMode = new ObservableCollection<string>();

            foreach (var item in comboBox3Items)
            {
                BatteryMode.Add(item.Attribute("Content").Value);
            }
            #endregion
        }

    }
}
