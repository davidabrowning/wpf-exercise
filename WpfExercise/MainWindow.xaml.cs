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

namespace WpfExercise
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

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            if (outputTextBox.Text == string.Empty)
                outputTextBox.Text = inputTextBox.Text;
            else
                outputTextBox.Text = $"{outputTextBox.Text}\n{inputTextBox.Text}";
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            outputTextBox.Text = string.Empty;
        }
    }
}