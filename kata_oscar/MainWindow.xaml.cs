using System.IO;
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
            List<Oscar> oscarok = new();
            InitializeComponent();

            using StreamReader sr = new StreamReader(
                path: @"..\..\..\src\oscar.csv",
                encoding: Encoding.UTF8
                );

            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                oscarok.Add(new Oscar(sr.ReadLine()));
            }

            sr.Close();

            
            foreach (var item in oscarok)
            {
                FilmListbox.Items.Add(item.Cim);
            }

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

        private void ujFilm_Click(object sender, RoutedEventArgs e)
        {

            if (cimTxt.Text != "" || evTxt.Text != "" || jeloltTxt.Text != "" || dijakSzamaTxt.Text != "")
            {
                using StreamWriter sw = new StreamWriter(
                    path: @"..\..\..\src\oscar.csv");

            }
            else
            {
                MessageBox.Show("Valamelyik textbox üres!");
            }
        }
    }
}