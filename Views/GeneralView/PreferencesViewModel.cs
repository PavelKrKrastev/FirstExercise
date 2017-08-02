using NemetschekFirstAssigment.ViewModel;

namespace NemetschekFirstAssigment.Views.GeneralView
{
    class PreferencesViewModel : GeneralViewModel
    {
        public bool CheckBoxValue { get; set; }

        public string LblValue { get; set; }

        public PreferencesViewModel()
        {
            CheckBoxValue = GeneralCheckBox2;
            LblValue = GeneralLabel;
        }
    }
}
