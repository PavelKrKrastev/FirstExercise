using NemetschekFirstAssigment.ViewModel;

namespace NemetschekFirstAssigment.Views.WindowView
{
    class ViewViewModel : GeneralViewModel
    {
        public bool WindowCheckBox1
        {
            get { return gModel.WindowCheckBox1; }
            set { WindowCheckBox1 = gModel.WindowCheckBox1; RaisePropertyChangedEvent("WindowCheckBox1"); }
        }

        public string WindowLabel
        {
            get { return gModel.WindowLabel; }
            set { WindowLabel = gModel.WindowLabel; RaisePropertyChangedEvent("WindowLabel"); }
        }
    }
}
