using NemetschekFirstAssigment.ViewModel;

namespace NemetschekFirstAssigment.Views.AdvancedView
{
    class Advanced3ViewModel : GeneralViewModel
    {
        public bool AdvancedCheckBox3
        {
            get { return gModel.AdvancedCheckBox3; }
            set { gModel.AdvancedCheckBox3 = value; RaisePropertyChangedEvent("AdvancedCheckBox3"); }
        }

        public string AdvancedLabel
        {
            get { return gModel.AdvancedLabel; }
            set { gModel.AdvancedLabel = value; RaisePropertyChangedEvent("AdvancedLabel"); }
        }
    }
}
