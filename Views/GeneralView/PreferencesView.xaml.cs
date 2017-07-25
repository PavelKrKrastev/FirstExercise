using System.Windows.Controls;
using NemetschekFirstAssigment.Views.GeneralView;

namespace NemetschekFirstAssigment.Views
{
    /// <summary>
    /// Interaction logic for PreferencesView.xaml
    /// </summary>
    public partial class PreferencesView : UserControl
    {
        public PreferencesView()
        {
            InitializeComponent();
            this.DataContext = new PreferencesViewModel();
        }
    }
}
