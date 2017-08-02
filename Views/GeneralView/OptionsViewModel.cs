using NemetschekFirstAssigment.ViewModel;

namespace NemetschekFirstAssigment.Views.GeneralView
{
    public class OptionsViewModel : GeneralViewModel
    {
        public bool CheckBoxValue { get; set; }
      
        public string LblValue { get; set; }

        public OptionsViewModel()
        {
            CheckBoxValue = GeneralCheckBox1;
            LblValue = GeneralLabel;
        }
    }
}
