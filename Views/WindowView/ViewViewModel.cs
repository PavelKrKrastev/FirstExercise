using NemetschekFirstAssigment.ViewModel;

namespace NemetschekFirstAssigment.Views.WindowView
{
    class ViewViewModel : GeneralViewModel
    {
        public bool CheckBoxValue { get; set; }

        public string LblValue { get; set; }

        public ViewViewModel()
        {
            CheckBoxValue = WindowCheckBox1;
            LblValue = WindowLabel;
        }

    }
}
