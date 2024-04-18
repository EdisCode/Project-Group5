using Project_Group5.MVVM;

namespace Project_Group5.ViewModel
{
    public class MainViewModel : AbstractViewModel
    {
        public AbstractViewModel currentViewModel;
        public AbstractViewModel CurrentViewModel
        {
            get { return currentViewModel; }
            set
            {
                currentViewModel = value;
                OnPropertyChanged(nameof(CurrentViewModel));
            }
        }

        private string activeTitle = "Hotel Management";
        public string ActiveTitle
        {
            get { return activeTitle; }
            set
            {
                activeTitle = value;
                OnPropertyChanged(nameof(ActiveTitle));
            }
        }

        public MainViewModel()
        {
            CurrentViewModel = new LoginViewModel();
        }
    }
}
