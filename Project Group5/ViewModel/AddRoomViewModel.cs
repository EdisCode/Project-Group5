using Project_Group5.Model;
using Project_Group5.MVVM;
using Project_Group5.Services;
using System;
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

            LoadRoomTypesAndBeds();

            LoadRooms(); // Load existing rooms from the database
        }

        private void LoadRoomTypesAndBeds()
        {
            RoomType.Add("AC");
            RoomType.Add("Non-AC");

            RoomBed.Add("Single");
            RoomBed.Add("Double");
            RoomBed.Add("Triple");
        }

        private void LoadRooms()
        {
            DataTable dataTable = RoomService.GetAll();
            foreach (DataRow row in dataTable.Rows)
            {
                RoomList.Add(new RoomModel()
                {
                    RoomNumber = row["RoomNumber"].ToString(),
                    Type = row["Type"].ToString(),
                    Bed = row["Bed"].ToString(),
                    Price = Convert.ToSingle(row["Price"]),
                    Booked = Convert.ToBoolean(row["Booked"])
                });
            }
        }

        public void OnSubmit(object sender, EventArgs e)
        {
            if (RoomService.Add(Room))
            {
                MessageBox.Show($"{Room.RoomNumber}\n{Room.Type}\n{Room.Bed}\n{Room.Price}");
                Room = new RoomModel();

                // Reload rooms from the database after adding a new room
                RoomList.Clear();
                LoadRooms();
            }
        }
    }
}
