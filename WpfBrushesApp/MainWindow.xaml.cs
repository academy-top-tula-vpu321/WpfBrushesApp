using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfBrushesApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //brd.Background = new SolidColorBrush(Color.FromArgb(125, 150, 78, 23));
            //var grad = new LinearGradientBrush();
            //grad.GradientStops.Add(new GradientStop(Colors.Aqua, 0));
            //grad.GradientStops.Add(new GradientStop(Colors.Yellow, 1));
            //brd.Background = grad;
        }
    }
}