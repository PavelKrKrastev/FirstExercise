using NemetschekFirstAssigment.ViewModels;

namespace NemetschekFirstAssigment.Views.GeneralView
{
    class SettingsViewModel : BaseViewModel
    {
        public bool CheckBoxValue { get; set; }

        public string LblValue { get; set; }

        public SettingsViewModel()
        {
            CheckBoxValue = true;
            LblValue = "Settings View Model";
        }

    }
}
