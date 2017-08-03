using NemetschekFirstAssigment.ViewModel;

namespace NemetschekFirstAssigment.Views.WindowView
{
    class ResolutionViewModel : GeneralViewModel
    {

        public bool WindowCheckBox1
        {
            get { return gModel.WindowCheckBox2; }
            set { WindowCheckBox1 = gModel.WindowCheckBox1; RaisePropertyChangedEvent("WindowCheckBox1"); }
        }

        public string WindowLabel
        {
            get { return gModel.WindowLabel; }
            set { WindowLabel = gModel.WindowLabel; RaisePropertyChangedEvent("WindowLabel"); }
        }
    }
}
