using SampleApplication.Services;
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

namespace SampleApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ExcelLoaderModuleController controller = new ExcelLoaderModuleController();
        }

        private void ExcelLoaderControl_Load(object sender, RoutedEventArgs e)
        {
            SampleApplication.ViewModel.ExcelDataLoaderViewModel studentViewModelObject =
               new SampleApplication.ViewModel.ExcelDataLoaderViewModel();

            ExcelLoaderControl.DataContext = studentViewModelObject;
        }
    }
}
