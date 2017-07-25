using NemetschekFirstAssigment.ViewModels;

namespace NemetschekFirstAssigment.Views.GeneralView
{
    public class OptionsViewModel : BaseViewModel
    {
        public bool CheckBoxValue { get; set; }

        public string LblValue { get; set; }

        public OptionsViewModel()
        {
            CheckBoxValue = true;
            LblValue = "Options View Model";
        }
    }
}
