using NemetschekFirstAssigment.ViewModels;

namespace NemetschekFirstAssigment.Views.AdvancedView
{
    class Advanced4ViewModel : BaseViewModel
    {
        public bool CheckBoxValue { get; set; }

        public string LblValue { get; set; }

        public Advanced4ViewModel()
        {
            CheckBoxValue = true;
            LblValue = "Advanced 4 View Model";
        }

    }
}
