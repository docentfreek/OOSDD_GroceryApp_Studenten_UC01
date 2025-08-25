using GroceryApp.ViewModels;

namespace GroceryApp.Views;

public partial class GroceryListsView : ContentPage
{
	public GroceryListsView(GroceryListViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}