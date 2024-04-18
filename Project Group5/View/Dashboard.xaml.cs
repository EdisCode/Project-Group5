using Project_Group5.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace Project_Group5.View
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : UserControl
    {
        private DashboardViewModel dashboardViewModel;
        public Dashboard()
        {
            dashboardViewModel = new DashboardViewModel();
            DataContext = dashboardViewModel;

            InitializeComponent();
        }

        private void AddRoom_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
