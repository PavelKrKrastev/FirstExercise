using NemetschekFirstAssigment.ViewModels;
using System;

namespace NemetschekFirstAssigment.Views.AdvancedView
{
    class Advanced4ViewModel : BaseViewModel
    {
        public bool CheckBoxValue { get; set; }

        public string LblValue { get; set; }

        public Advanced4ViewModel()
        {
            CheckBoxValue = Convert.ToBoolean(Doc.Root.Element("Advanced").Element("AdvancedTab4").Attribute("CheckBoxValue").Value);
            LblValue = Doc.Root.Element("Advanced").Element("AdvancedTab4").Attribute("LabelContent").Value;
        }

    }
}
