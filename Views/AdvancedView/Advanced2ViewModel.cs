using NemetschekFirstAssigment.ViewModels;
using System;

namespace NemetschekFirstAssigment.Views.AdvancedView
{
    class Advanced2ViewModel : BaseViewModel
    {
        public bool CheckBoxValue { get; set; }

        public string LblValue { get; set; }

        public Advanced2ViewModel()
        {
            CheckBoxValue = Convert.ToBoolean(Doc.Root.Element("Advanced").Element("AdvancedTab2").Attribute("CheckBoxValue").Value);
            LblValue = Doc.Root.Element("Advanced").Element("AdvancedTab2").Attribute("LabelContent").Value;
        }

    }
}
