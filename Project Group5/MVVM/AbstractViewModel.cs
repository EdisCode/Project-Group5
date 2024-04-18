using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Project_Group5.MVVM
{
    abstract public class AbstractViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
