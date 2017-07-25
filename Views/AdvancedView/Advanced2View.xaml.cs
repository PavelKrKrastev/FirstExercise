using System.Windows.Controls;
using NemetschekFirstAssigment.Views.AdvancedView;

namespace NemetschekFirstAssigment.Views
{
    /// <summary>
    /// Interaction logic for AdvancedView2.xaml
    /// </summary>
    public partial class Advanced2View : UserControl
    {
        public Advanced2View()
        {
            InitializeComponent();
            this.DataContext = new Advanced2ViewModel();
        }
    }
}
