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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void sliderChange(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int red = (int)sliderRed.Value;
            int green = (int)sliderGreen.Value;
            int blue = (int)sliderBlue.Value;

            Color newColor = Color.FromRgb((byte)red, (byte)green, (byte)blue);
            colorPreview.Background = new SolidColorBrush(newColor);

            if ((red + green + blue) / 3 > 122)
            {
                txtColorPreview.Foreground = new SolidColorBrush(Colors.Black);
            }
            else
            {
                txtColorPreview.Foreground = new SolidColorBrush(Colors.White);
            }

            txtRGB.Text = $"RGB: {red}, {green}, {blue}";
        }

    }
}