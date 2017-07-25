using System.Windows.Controls;
using NemetschekFirstAssigment.Views.WindowView;

namespace NemetschekFirstAssigment.Views
{
    /// <summary>
    /// Interaction logic for ViewView.xaml
    /// </summary>
    public partial class ViewView : UserControl
    {
        public ViewView()
        {
            InitializeComponent();
            this.DataContext = new ViewViewModel();
        }
    }
}
