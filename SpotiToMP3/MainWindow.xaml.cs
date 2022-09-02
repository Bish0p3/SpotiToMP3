using System.Windows;
using ViewModels.SpotiToMP3;

namespace SpotiToMP3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
            WelcomeWindow_VM hvm;
            hvm = new WelcomeWindow_VM();
            DataContext = hvm;
        }
    }
}
