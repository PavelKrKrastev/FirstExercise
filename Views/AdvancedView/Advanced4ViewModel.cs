using NemetschekFirstAssigment.ViewModel;

namespace NemetschekFirstAssigment.Views.AdvancedView
{
    class Advanced4ViewModel : GeneralViewModel
    {
        public bool AdvancedCheckBox4
        {
            get { return gModel.AdvancedCheckBox4; }
            set { gModel.AdvancedCheckBox4 = value; RaisePropertyChangedEvent("AdvancedCheckBox4"); }
        }
        public string AdvancedLabel
        {
            get { return gModel.AdvancedLabel; }
            set { gModel.AdvancedLabel = value; RaisePropertyChangedEvent("AdvancedLabel"); }
        }
    }
}
