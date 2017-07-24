using NemetschekFirstAssigment.ViewModel.MainViewModels;

namespace NemetschekFirstAssigment.ViewModel.UserControlViewModels
{
    class Advanced4ViewModel : BaseViewModel
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
        public Advanced4ViewModel()
        {
            CheckBoxValue = true;
            LblValue = "Advanced 4 View Model";
        }

    }
}
