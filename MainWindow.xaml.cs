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

namespace PeopleProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        People p = new People();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                p.UjSzemely(int.Parse(tb.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnAtlag_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double atlag = p.AtlagEletkor(int.Parse(tbMin.Text), int.Parse(tbMax.Text));
                lbl.Content = atlag;
                img.Source = new BitmapImage(new Uri($"pack://application:,,,/imgs/{p.Kategoria(atlag)}.jpg"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}