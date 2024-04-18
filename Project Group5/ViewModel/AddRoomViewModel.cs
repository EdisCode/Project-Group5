using Project_Group5.Model;
using Project_Group5.MVVM;
using System.Collections.ObjectModel;

namespace Project_Group5.ViewModel
{
    internal class AddRoomViewModel : AbstractViewModel
    {
        public ObservableCollection<Room> RoomList { get; set; }
        public ObservableCollection<string> RoomType { get; set; }
        public ObservableCollection<string> RoomBed { get; set; }

        private Room room;

        public Room Room
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

            RoomList = new ObservableCollection<Room>();
            RoomType = new ObservableCollection<string>();
            RoomBed = new ObservableCollection<string>();
            Room = new Room();

            RoomList.Add(new Room()
            {
                Number = 0,
                Type = "AC",
                Bed = "Single",
                Price = 3500,
            });

            RoomList.Add(new Room()
            {
                Number = 1,
                Type = "Non-AC",
                Bed = "Double",
                Price = 4000,
            });

            RoomList.Add(new Room()
            {
                Number = 2,
                Type = "Non-AC",
                Bed = "Triple",
                Price = 5500,
            });


            RoomType.Add("AC");
            RoomType.Add("Non-AC");

            RoomBed.Add("Single");
            RoomBed.Add("Double");
            RoomBed.Add("Triple");
        }
    }
}
