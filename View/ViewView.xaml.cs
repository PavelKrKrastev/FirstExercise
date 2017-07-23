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
