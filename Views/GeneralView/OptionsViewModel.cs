using NemetschekFirstAssigment.Models;
using NemetschekFirstAssigment.ViewModel;

namespace NemetschekFirstAssigment.Views.GeneralView
{
    public class OptionsViewModel : GeneralViewModel
    {
        public bool GeneralCheckBox1
        {
            get { return gModel.GeneralCheckBox1; }
            set { gModel.GeneralCheckBox1 = value; RaisePropertyChangedEvent("GeneralCheckBox1"); }
        }

        public string GeneralLabel
        {
            get { return gModel.GeneralLabel; }
            set { gModel.GeneralLabel = value;}
        }

        
    }
}
