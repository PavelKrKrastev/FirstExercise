using NemetschekFirstAssigment.ViewModels;
using System;

namespace NemetschekFirstAssigment.Views.GeneralView
{
    class SettingsViewModel : BaseViewModel
    {
        public bool CheckBoxValue { get; set; }

        public string LblValue { get; set; }

        public SettingsViewModel()
        {
            CheckBoxValue = Convert.ToBoolean(Doc.Root.Element("General").Element("GeneralTab3").Attribute("CheckBoxValue").Value);
            LblValue = Doc.Root.Element("General").Element("GeneralTab3").Attribute("LabelContent").Value;
        }

    }
}
