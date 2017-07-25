using System.Windows.Controls;
using NemetschekFirstAssigment.Views.GeneralView;

namespace NemetschekFirstAssigment.Views
{
    /// <summary>
    /// Interaction logic for SettingsView.xaml
    /// </summary>
    public partial class SettingsView : UserControl
    {
        public SettingsView()
        {
            InitializeComponent();
            this.DataContext = new SettingsViewModel();
        }
    }
}
