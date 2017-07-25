using NemetschekFirstAssigment.ViewModels;

namespace NemetschekFirstAssigment.Views.GeneralView
{
    class PreferencesViewModel : BaseViewModel
    {
        public bool CheckBoxValue { get; set; }

        public string LblValue { get; set; }

        public PreferencesViewModel()
        {
            CheckBoxValue = false;
            LblValue = "Preferences View Model";
        }
    }
}
