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
            MessageBox.Show($"{addRoomViewModel.Room.Number}\n{addRoomViewModel.Room.Type}\n{addRoomViewModel.Room.Bed}\n{addRoomViewModel.Room.Price}");
        }
    }
}
