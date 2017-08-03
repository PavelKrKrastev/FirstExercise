using NemetschekFirstAssigment.ViewModel;

namespace NemetschekFirstAssigment.Views.AdvancedView
{
    class Advanced2ViewModel : GeneralViewModel
    {
        public bool AdvancedCheckBox2
        {
            get { return gModel.AdvancedCheckBox2; }
            set { AdvancedCheckBox2 = gModel.AdvancedCheckBox2; RaisePropertyChangedEvent("AdvancedCheckBox2"); }
        }

        public string AdvancedLabel
        {
            get { return gModel.AdvancedLabel; }
            set { AdvancedLabel = gModel.AdvancedLabel; RaisePropertyChangedEvent("AdvancedLabel"); }
        }
    }
}
