using Food_App.ViewModel;

namespace Food_App.View;

public partial class AllFoodsPage : ContentPage
{
	private readonly AllFoodsViewModel _allFoodsViewModel;
	public AllFoodsPage(AllFoodsViewModel allFoodsViewModel)
	{
		InitializeComponent();
		_allFoodsViewModel = allFoodsViewModel;
		BindingContext = _allFoodsViewModel;
	}
	protected override async void OnAppearing()
	{
		base.OnAppearing();
		if (_allFoodsViewModel.FromSearch)
		{
			await Task.Delay(100);
			searchBar.Focus();
		}
	}
	void searchBar_TextChanged(System.Object sender, Microsoft.Maui.Controls.TextChangedEventArgs e)
	{
		if (!string.IsNullOrWhiteSpace(e.OldTextValue)
			|| string.IsNullOrWhiteSpace(e.NewTextValue))
		{ 
			_allFoodsViewModel.SearchFoodsCommand.Execute(e.NewTextValue);
		}
	 }
}