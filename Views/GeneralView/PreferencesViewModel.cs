using NemetschekFirstAssigment.ViewModels;
using System;

namespace NemetschekFirstAssigment.Views.GeneralView
{
    class PreferencesViewModel : BaseViewModel
    {
        public bool CheckBoxValue { get; set; }

        public string LblValue { get; set; }

        public PreferencesViewModel()
        {
            CheckBoxValue = Convert.ToBoolean(Doc.Root.Element("General").Element("GeneralTab2").Attribute("CheckBoxValue").Value);
            LblValue = Doc.Root.Element("General").Element("GeneralTab2").Attribute("LabelContent").Value;
        }
    }
}
