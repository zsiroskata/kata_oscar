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

namespace kata_oscar
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

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            // Kiüríti a TextBox tartalmát
            szo.Text = "";
            // Az eseménykód első futása után eltávolítja az eseménykezelőt
            szo.GotFocus -= TextBox_GotFocus;
        }

        private void keresFilm(object sender, RoutedEventArgs e)
        {
            kfilm.Text = "";
            kfilm.GotFocus -= TextBox_GotFocus;
        }
    }
}