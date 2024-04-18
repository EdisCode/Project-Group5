using Project_Group5.ViewModel;
using System.Windows;

namespace Project_Group5
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        private MainViewModel mainViewModel;

        public Main()
        {
            mainViewModel = new MainViewModel();
            DataContext = mainViewModel;
            WindowStartupLocation = WindowStartupLocation.CenterScreen;

            InitializeComponent();
        }
    }
}