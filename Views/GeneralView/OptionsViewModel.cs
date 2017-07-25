using NemetschekFirstAssigment.ViewModels;

namespace NemetschekFirstAssigment.Views.GeneralView
{
    public class OptionsViewModel : BaseViewModel
    {
        #region private variables
        private bool _checkBoxValue;
        private string _lblValue;
        #endregion

        #region public properties
        public bool CheckBoxValue
        {
            get { return _checkBoxValue; }
            set { _checkBoxValue = value; }
        }

        public string LblValue
        {
            get { return _lblValue; }
            set { _lblValue = value; }
        }
        #endregion

        public OptionsViewModel()
        {
            CheckBoxValue = true;
            LblValue = "Options View Model";
        }
    }
}
