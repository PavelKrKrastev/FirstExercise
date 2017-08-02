using NemetschekFirstAssigment.ViewModel;

namespace NemetschekFirstAssigment.Views.GeneralView
{
    class SettingsViewModel : GeneralViewModel
    {
        public bool CheckBoxValue { get; set; }

        public string LblValue { get; set; }

        public SettingsViewModel()
        {
            CheckBoxValue = GeneralCheckBox3;
            LblValue = GeneralLabel;
        }

    }
}
