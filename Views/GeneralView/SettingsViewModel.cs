using NemetschekFirstAssigment.ViewModel;

namespace NemetschekFirstAssigment.Views.GeneralView
{
    class SettingsViewModel : GeneralViewModel
    {
        public bool GeneralCheckBox3
        {
            get { return gModel.GeneralCheckBox3; }
            set {gModel.GeneralCheckBox3 = value; RaisePropertyChangedEvent("GeneralCheckBox3"); }
        }

        public string GeneralLabel
        {
            get { return gModel.GeneralLabel; }
            set { gModel.GeneralLabel = value; RaisePropertyChangedEvent("GeneralLabel"); }
        }
    }
}
