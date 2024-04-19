using Project_Group5.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace Project_Group5.View
{
    /// <summary>
    /// Interaction logic for AddRoom.xaml
    /// </summary>
    public partial class AddRoom : UserControl
    {
        private AddRoomViewModel addRoomViewModel;
        public AddRoom()
        {
            addRoomViewModel = new AddRoomViewModel();
            DataContext = addRoomViewModel;

            InitializeComponent();
        }

        public void OnSubmit(object sender, EventArgs e)
        {
            addRoomViewModel.OnSubmit(this, e);
        }
    }
}
