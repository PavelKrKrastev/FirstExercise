using NemetschekFirstAssigment.ViewModel;

namespace NemetschekFirstAssigment.Views.GeneralView
{
    class SettingsViewModel : GeneralViewModel
    {
        public bool GeneralCheckBox3
        {
            get { return gModel.GeneralCheckBox3; }
            set { GeneralCheckBox3 = gModel.GeneralCheckBox3; RaisePropertyChangedEvent("GeneralCheckBox3"); }
        }

        public string GeneralLabel
        {
            get { return gModel.GeneralLabel; }
            set { GeneralLabel = gModel.GeneralLabel; RaisePropertyChangedEvent("GeneralLabel"); }
        }
    }
}
