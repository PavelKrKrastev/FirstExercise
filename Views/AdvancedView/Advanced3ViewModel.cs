using NemetschekFirstAssigment.ViewModel;

namespace NemetschekFirstAssigment.Views.AdvancedView
{
    class Advanced3ViewModel : GeneralViewModel
    {
        public bool AdvancedCheckBox3
        {
            get { return gModel.AdvancedCheckBox3; }
            set { AdvancedCheckBox3 = gModel.AdvancedCheckBox3; RaisePropertyChangedEvent("AdvancedCheckBox3"); }
        }

        public string AdvancedLabel
        {
            get { return gModel.AdvancedLabel; }
            set { AdvancedLabel = gModel.AdvancedLabel; RaisePropertyChangedEvent("AdvancedLabel"); }
        }
    }
}
