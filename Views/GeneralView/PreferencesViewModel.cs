using NemetschekFirstAssigment.ViewModel;

namespace NemetschekFirstAssigment.Views.GeneralView
{
    class PreferencesViewModel : GeneralViewModel
    {
        public bool GeneralCheckBox2
        {
            get { return gModel.GeneralCheckBox2; }
            set { gModel.GeneralCheckBox2 = value; RaisePropertyChangedEvent("GeneralCheckBox2"); }
        }

        public string GeneralLabel
        {
            get { return gModel.GeneralLabel; }
            set { gModel.GeneralLabel = value; RaisePropertyChangedEvent("GeneralLabel"); }
        }
    }
}
