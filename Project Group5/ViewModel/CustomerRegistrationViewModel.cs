using Project_Group5.MVVM;
using System.Collections.ObjectModel;

namespace Project_Group5.ViewModel
{
    internal class CustomerRegistrationViewModel : AbstractViewModel
    {
        public ObservableCollection<string> RoomType { get; set; }
        public ObservableCollection<string> RoomBed { get; set; }

        public CustomerRegistrationViewModel()
        {
            RoomType = new ObservableCollection<string>();
            RoomBed = new ObservableCollection<string>();

            RoomType.Add("AC");
            RoomType.Add("Non-AC");

            RoomBed.Add("Single");
            RoomBed.Add("Double");
            RoomBed.Add("Triple");
        }
    }
}
