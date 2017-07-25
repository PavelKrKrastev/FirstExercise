using System.Windows.Controls;
using NemetschekFirstAssigment.Views.WindowView;

namespace NemetschekFirstAssigment.Views
{
    /// <summary>
    /// Interaction logic for ResolutionView.xaml
    /// </summary>
    public partial class ResolutionView : UserControl
    {
        public ResolutionView()
        {
            InitializeComponent();
            this.DataContext = new ResolutionViewModel();
        }
    }
}
