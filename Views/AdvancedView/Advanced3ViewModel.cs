using NemetschekFirstAssigment.ViewModels;

namespace NemetschekFirstAssigment.Views.AdvancedView
{
    class Advanced3ViewModel : BaseViewModel
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

        public Advanced3ViewModel()
        {
            CheckBoxValue = false;
            LblValue = "Advanced 3 View Model";
        }

    }
}
