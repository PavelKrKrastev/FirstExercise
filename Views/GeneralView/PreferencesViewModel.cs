using NemetschekFirstAssigment.ViewModel;

namespace NemetschekFirstAssigment.Views.GeneralView
{
    class PreferencesViewModel : GeneralViewModel
    {
        public bool GeneralCheckBox2
        {
            get { return gModel.GeneralCheckBox2; }
            set { GeneralCheckBox2 = gModel.GeneralCheckBox2; RaisePropertyChangedEvent("GeneralCheckBox2"); }
        }

        public string GeneralLabel
        {
            get { return gModel.GeneralLabel; }
            set { GeneralLabel = gModel.GeneralLabel; RaisePropertyChangedEvent("GeneralLabel"); }
        }
    }
}
