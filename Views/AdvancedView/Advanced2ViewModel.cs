using NemetschekFirstAssigment.ViewModels;

namespace NemetschekFirstAssigment.Views.AdvancedView
{
    class Advanced2ViewModel : BaseViewModel
    {

        private bool _checkBoxValue;

        public bool CheckBoxValue
        {
            get { return _checkBoxValue; }
            set
            {
                _checkBoxValue = value;
                RaisePropertyChangedEvent("CheckBoxValue");
            }
        }

        private string _lblValue;

        public string LblValue
        {
            get { return _lblValue; }
            set
            {
                _lblValue = value;
                RaisePropertyChangedEvent("LblValue");
            }
        }

        public Advanced2ViewModel()
        {
            CheckBoxValue = true;
            LblValue = "Advanced 2 View Model";
        }

    }
}
