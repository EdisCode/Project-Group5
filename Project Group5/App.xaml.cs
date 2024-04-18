using Project_Group5.MVVM;
using Project_Group5.ViewModel;
using System.Windows;

namespace Project_Group5
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static MainViewModel mainViewModel = new MainViewModel();

        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new Main()
            {
                DataContext = mainViewModel
            };
            MainWindow.Show();

            base.OnStartup(e);
        }

        public static void NavitageTo(AbstractViewModel viewModel)
        {
            mainViewModel.CurrentViewModel = viewModel;
        }
    }

}
