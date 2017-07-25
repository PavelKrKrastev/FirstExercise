using NemetschekFirstAssigment.ViewModels;

namespace NemetschekFirstAssigment.Views.WindowView
{
    class ResolutionViewModel : BaseViewModel
    {

        public bool CheckBoxValue { get; set; }

        public string LblValue { get; set; }

        public ResolutionViewModel()
        {
            CheckBoxValue = true;
            LblValue = "Resolution View Model";
        }

    }
}
