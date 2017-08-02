using NemetschekFirstAssigment.ViewModel;

namespace NemetschekFirstAssigment.Views.WindowView
{
    class ResolutionViewModel : GeneralViewModel
    {

        public bool CheckBoxValue { get; set; }

        public string LblValue { get; set; }

        public ResolutionViewModel()
        {
            CheckBoxValue = WindowCheckBox2;
            LblValue = WindowLabel;
        }
    }
}
