using GroceryApp.Models.Models;
using GroceryApp.Services;
using System.Collections.ObjectModel;

namespace GroceryApp.ViewModels
{
    public partial class GroceryListViewModel : BaseViewModel
    {
        public ObservableCollection<GroceryList> GroceryLists { get; set; }
        private readonly GroceryListService _groceryListService;
        public GroceryListViewModel(GroceryListService groceryListService) 
        {
            Title = "Boodschappenlijst";
            _groceryListService = groceryListService;
            GroceryLists = new(_groceryListService.GetAll());
        }
    }
}
