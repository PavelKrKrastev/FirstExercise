using NemetschekFirstAssigment.ViewModel;

namespace NemetschekFirstAssigment.Views.AdvancedView
{
    class Advanced4ViewModel : GeneralViewModel
    {
        public bool CheckBoxValue { get; set; }

        public string LblValue { get; set; }

        public Advanced4ViewModel()
        {
            CheckBoxValue = AdvancedCheckBox4;
            LblValue = AdvancedLabel;
        }

    }
}
