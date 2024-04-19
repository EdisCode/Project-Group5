using Project_Group5.Model;
using Project_Group5.MVVM;
using Project_Group5.Services;
using System.Collections.ObjectModel;
using System.Data;
using System.Windows;

namespace Project_Group5.ViewModel
{
    internal class AddRoomViewModel : AbstractViewModel
    {
        public ObservableCollection<RoomModel> RoomList { get; set; }
        public ObservableCollection<string> RoomType { get; set; }
        public ObservableCollection<string> RoomBed { get; set; }

        private RoomModel room;

        public RoomModel Room
        {
            get { return room; }
            set
            {
                room = value;
                OnPropertyChanged(nameof(Room));
            }
        }

        public AddRoomViewModel()
        {
            RoomList = new ObservableCollection<RoomModel>();
            RoomType = new ObservableCollection<string>();
            RoomBed = new ObservableCollection<string>();
            Room = new RoomModel();


            RoomList.Add(new RoomModel()
            {
                RoomNumber = "A301",
                Type = "AC",
                Bed = "Single",
                Price = 2500,
                Booked = true,
            });

            RoomList.Add(new RoomModel()
            {
                RoomNumber = "B120",
                Type = "Non-AC",
                Bed = "Double",
                Price = 3000,
                Booked = false,
            });

            RoomList.Add(new RoomModel()
            {
                RoomNumber = "C200",
                Type = "Non-AC",
                Bed = "Triple",
                Price = 5000,
                Booked = true,
            });


            RoomType.Add("AC");
            RoomType.Add("Non-AC");

            RoomBed.Add("Single");
            RoomBed.Add("Double");
            RoomBed.Add("Triple");
        }

        public void OnSubmit(object sender, EventArgs e)
        {
            if (RoomService.Add(Room))
            {
                MessageBox.Show($"{Room.RoomNumber}\n{Room.Type}\n{Room.Bed}\n{Room.Price}");
                Room = new RoomModel();

                DataTable source = RoomService.GetAll();
            }
        }
    }
}
