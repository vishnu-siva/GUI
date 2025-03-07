// MainWindow.xaml.cs
using System.Windows;
using System.Windows.Controls;

namespace ConductManagementSystem
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ConductDetails conductDetailsWindow = new ConductDetails();
            conductDetailsWindow.ShowDialog();
            this.Close();
        }

        private void Sign(object sender, RoutedEventArgs e)
        {
            Signinxaml signinxaml = new Signinxaml();
            signinxaml.ShowDialog();
            this.Close();
        }
    }
}