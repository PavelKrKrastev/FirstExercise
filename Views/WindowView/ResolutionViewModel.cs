using NemetschekFirstAssigment.ViewModel;

namespace NemetschekFirstAssigment.Views.WindowView
{
    class ResolutionViewModel : GeneralViewModel
    {

        public bool WindowCheckBox1
        {
            get { return gModel.WindowCheckBox2; }
            set { gModel.WindowCheckBox1 = value; RaisePropertyChangedEvent("WindowCheckBox1"); }
        }

        public string WindowLabel
        {
            get { return gModel.WindowLabel; }
            set { gModel.WindowLabel = value; RaisePropertyChangedEvent("WindowLabel"); }
        }
    }
}
