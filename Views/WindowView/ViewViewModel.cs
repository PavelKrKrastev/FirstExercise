using NemetschekFirstAssigment.ViewModels;

namespace NemetschekFirstAssigment.Views.WindowView
{
    class ViewViewModel : BaseViewModel
    {

        public bool CheckBoxValue { get; set; }

        public string LblValue { get; set; }

        public ViewViewModel()
        {
            CheckBoxValue = false;
            LblValue = "View View Model";
        }

    }
}
