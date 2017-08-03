using NemetschekFirstAssigment.ViewModel;

namespace NemetschekFirstAssigment.Views.WindowView
{
    class ResolutionViewModel : GeneralViewModel
    {

        public bool WindowCheckBox2
        {
            get { return gModel.WindowCheckBox2; }
            set { gModel.WindowCheckBox2 = value; RaisePropertyChangedEvent("WindowCheckBox2"); }
        }

        public string WindowLabel
        {
            get { return gModel.WindowLabel; }
            set { gModel.WindowLabel = value; RaisePropertyChangedEvent("WindowLabel"); }
        }
    }
}
