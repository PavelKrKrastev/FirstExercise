using System.Windows.Controls;
using NemetschekFirstAssigment.Views.AdvancedView;

namespace NemetschekFirstAssigment.Views
{
    /// <summary>
    /// Interaction logic for AdvancedView3.xaml
    /// </summary>
    public partial class Advanced3View : UserControl
    {
        public Advanced3View()
        {
            InitializeComponent();
            this.DataContext = new Advanced3ViewModel();
        }
    }
}
