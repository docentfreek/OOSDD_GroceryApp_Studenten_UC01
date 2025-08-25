using CommunityToolkit.Mvvm.ComponentModel;

namespace GroceryApp.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        string title = "";

        public virtual void Load() { }
        public virtual void OnAppearing() { }
        public virtual void OnDisappearing() { }
    }
}
