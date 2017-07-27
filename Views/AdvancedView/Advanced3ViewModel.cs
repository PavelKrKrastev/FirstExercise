using NemetschekFirstAssigment.ViewModels;
using System;

namespace NemetschekFirstAssigment.Views.AdvancedView
{
    class Advanced3ViewModel : BaseViewModel
    {
        public bool CheckBoxValue { get; set; }

        public string LblValue { get; set; }

        public Advanced3ViewModel()
        {
            CheckBoxValue = Convert.ToBoolean(Doc.Root.Element("Advanced").Element("AdvancedTab3").Attribute("CheckBoxValue").Value);
            LblValue = Doc.Root.Element("Advanced").Element("AdvancedTab3").Attribute("LabelContent").Value;
        }

    }
}
