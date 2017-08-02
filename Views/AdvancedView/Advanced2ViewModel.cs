using NemetschekFirstAssigment.ViewModel;

namespace NemetschekFirstAssigment.Views.AdvancedView
{
    class Advanced2ViewModel : GeneralViewModel
    {
        public bool CheckBoxValue { get; set; }

        public string LblValue { get; set; }

        public Advanced2ViewModel()
        {
            CheckBoxValue = AdvancedCheckBox2;
            LblValue = AdvancedLabel;
        }

    }
}
