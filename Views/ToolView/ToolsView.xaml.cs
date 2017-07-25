using NemetschekFirstAssigment.Views.ToolView;
using System.Windows.Controls;

namespace NemetschekFirstAssigment.Views
{
    /// <summary>
    /// Interaction logic for ToolsView.xaml
    /// </summary>
    public partial class ToolsView : UserControl
    {
        public ToolsView()
        {
            InitializeComponent();
            this.DataContext = new ToolsViewModel();
        }
    }
}
