using System.Windows.Controls;
using NemetschekFirstAssigment.Views.AdvancedView;

namespace NemetschekFirstAssigment.Views
{
    /// <summary>
    /// Interaction logic for Advanced1View.xaml
    /// </summary>
    public partial class Advanced1View : UserControl
    {
        public Advanced1View()
        {
            InitializeComponent();
            this.DataContext = new Advanced1ViewModel();
        }
    }
}
