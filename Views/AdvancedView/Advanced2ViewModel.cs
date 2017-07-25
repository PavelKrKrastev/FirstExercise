using NemetschekFirstAssigment.ViewModels;

namespace NemetschekFirstAssigment.Views.AdvancedView
{
    class Advanced2ViewModel : BaseViewModel
    {
        public bool CheckBoxValue { get; set; }

        public string LblValue { get; set; }

        public Advanced2ViewModel()
        {
            CheckBoxValue = true;
            LblValue = "Advanced 2 View Model";
        }

    }
}
