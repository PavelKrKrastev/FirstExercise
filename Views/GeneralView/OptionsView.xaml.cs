using NemetschekFirstAssigment.Views.GeneralView;
using System.Windows.Controls;

namespace NemetschekFirstAssigment.Views
{
    /// <summary>
    /// Interaction logic for OptionsView.xaml
    /// </summary>
    public partial class OptionsView : UserControl
    {
        public OptionsView()
        {
            InitializeComponent();
            this.DataContext = new OptionsViewModel();
        }
    }
}
