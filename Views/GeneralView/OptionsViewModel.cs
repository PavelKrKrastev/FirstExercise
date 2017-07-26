using NemetschekFirstAssigment.ViewModels;
using System;

namespace NemetschekFirstAssigment.Views.GeneralView
{
    public class OptionsViewModel : BaseViewModel
    {
        public bool CheckBoxValue { get; set; }

        public string LblValue { get; set; }

        public OptionsViewModel()
        {
            CheckBoxValue = Convert.ToBoolean(Doc.Root.Element("General").Element("GeneralTab1").Attribute("CheckBoxValue").Value);
            LblValue = Doc.Root.Element("General").Element("GeneralTab1").Attribute("LabelContent").Value;
        }
    }
}
