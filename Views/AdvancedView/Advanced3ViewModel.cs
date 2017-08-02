using NemetschekFirstAssigment.ViewModel;

namespace NemetschekFirstAssigment.Views.AdvancedView
{
    class Advanced3ViewModel : GeneralViewModel
    {
        public bool CheckBoxValue { get; set; }

        public string LblValue { get; set; }

        public Advanced3ViewModel()
        {
            CheckBoxValue = AdvancedCheckBox3;
            LblValue = AdvancedLabel;
        }

    }
}
