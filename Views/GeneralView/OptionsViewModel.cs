using NemetschekFirstAssigment.Models;
using NemetschekFirstAssigment.ViewModel;

namespace NemetschekFirstAssigment.Views.GeneralView
{
    public class OptionsViewModel : GeneralViewModel
    {
        public bool GeneralCheckBox1
        {
            get { return gModel.GeneralCheckBox1; }
            set { GeneralCheckBox1 = gModel.GeneralCheckBox1; RaisePropertyChangedEvent("GeneralCheckBox1"); }
        }

        public string GeneralLabel
        {
            get { return gModel.GeneralLabel; }
            set { GeneralLabel = gModel.GeneralLabel; RaisePropertyChangedEvent("GeneralLabel"); }
        }
    }
}
