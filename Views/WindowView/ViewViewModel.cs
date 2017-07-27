using NemetschekFirstAssigment.ViewModels;
using System;

namespace NemetschekFirstAssigment.Views.WindowView
{
    class ViewViewModel : BaseViewModel
    {
        public bool CheckBoxValue { get; set; }

        public string LblValue { get; set; }

        public ViewViewModel()
        {
            CheckBoxValue = Convert.ToBoolean(Doc.Root.Element("Window").Element("WindowTab1").Attribute("CheckBoxValue").Value);
            LblValue = Doc.Root.Element("Window").Element("WindowTab1").Attribute("LabelContent").Value;
        }

    }
}
