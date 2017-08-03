using NemetschekFirstAssigment.ViewModel;

namespace NemetschekFirstAssigment.Views.AdvancedView
{
    class Advanced2ViewModel : GeneralViewModel
    {
        public bool AdvancedCheckBox2
        {
            get { return gModel.AdvancedCheckBox2; }
            set { gModel.AdvancedCheckBox2 = value; RaisePropertyChangedEvent("AdvancedCheckBox2"); }
        }

        public string AdvancedLabel
        {
            get { return gModel.AdvancedLabel; }
            set { gModel.AdvancedLabel = value; RaisePropertyChangedEvent("AdvancedLabel"); }
        }
    }
}
