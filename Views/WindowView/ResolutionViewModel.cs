using NemetschekFirstAssigment.ViewModels;
using System;

namespace NemetschekFirstAssigment.Views.WindowView
{
    class ResolutionViewModel : BaseViewModel
    {

        public bool CheckBoxValue { get; set; }

        public string LblValue { get; set; }

        public ResolutionViewModel()
        {
            CheckBoxValue = Convert.ToBoolean(Doc.Root.Element("Window").Element("WindowTab2").Attribute("CheckBoxValue").Value);
            LblValue = Doc.Root.Element("Window").Element("WindowTab2").Attribute("LabelContent").Value;
        }
    }
}
