using System.Windows.Controls;
using NemetschekFirstAssigment.Views.AdvancedView;

namespace NemetschekFirstAssigment.Views
{
    /// <summary>
    /// Interaction logic for Advanced4View.xaml
    /// </summary>
    public partial class Advanced4View : UserControl
    {
        public Advanced4View()
        {
            InitializeComponent();
            this.DataContext = new Advanced4ViewModel();
        }
    }
}
