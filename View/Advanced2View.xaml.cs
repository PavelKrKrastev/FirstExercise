using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using NemetschekFirstAssigment.ViewModel.UserControlViewModels;

namespace NemetschekFirstAssigment.View
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
