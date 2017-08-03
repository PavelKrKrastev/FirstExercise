using NemetschekFirstAssigment.ViewModel;

namespace NemetschekFirstAssigment.Views.AdvancedView
{
    class Advanced4ViewModel : GeneralViewModel
    {
        public bool AdvancedCheckBox4
        {
            get { return gModel.AdvancedCheckBox4; }
            set { AdvancedCheckBox4 = gModel.AdvancedCheckBox4; RaisePropertyChangedEvent("AdvancedCheckBox4"); }
        }
        public string AdvancedLabel
        {
            get { return gModel.AdvancedLabel; }
            set { AdvancedLabel = gModel.AdvancedLabel; RaisePropertyChangedEvent("AdvancedLabel"); }
        }
    }
}
