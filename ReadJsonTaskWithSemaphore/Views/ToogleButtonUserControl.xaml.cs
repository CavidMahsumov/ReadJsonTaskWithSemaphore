using ReadJsonTaskWithSemaphore.ViewModels;
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

namespace ReadJsonTaskWithSemaphore
{
    /// <summary>
    /// Interaction logic for ToogleButtonUserControl.xaml
    /// </summary>
    public partial class ToogleButtonUserControl : UserControl
    {
        public ToogleButtonUserControl()
        {
            InitializeComponent();
            this.DataContext = new ToogleButtonViewModel(this);
        }
    }
}
