using NemetschekFirstAssigment.ViewModels;

namespace NemetschekFirstAssigment.Views.AdvancedView
{
    class Advanced3ViewModel : BaseViewModel
    {
        public bool CheckBoxValue { get; set; }

        public string LblValue { get; set; }

        public Advanced3ViewModel()
        {
            CheckBoxValue = false;
            LblValue = "Advanced 3 View Model";
        }

    }
}
