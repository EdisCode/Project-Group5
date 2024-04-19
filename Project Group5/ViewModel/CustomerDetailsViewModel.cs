using Project_Group5.MVVM;
using System.Collections.ObjectModel;

namespace Project_Group5.ViewModel
{
    internal class CustomerDetailsViewModel : AbstractViewModel
    {
        public ObservableCollection<string> Category { get; set; }

        public CustomerDetailsViewModel()
        {
            Category = new ObservableCollection<string>();

            Category.Add("All Customers");
            Category.Add("Checked In Customers");
            Category.Add("Checked Out Customers");
        }
    }
}
