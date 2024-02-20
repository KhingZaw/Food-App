using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Food_App.Model;
using Food_App.Services;
using MvvmHelpers;
using ObservableObject = CommunityToolkit.Mvvm.ComponentModel.ObservableObject;
namespace Food_App.ViewModel;

[QueryProperty(nameof(Food), "Food")]
public partial class DetailViewModel : ObservableObject
{
    [ObservableProperty]
    Food food;

    public ObservableRangeCollection<Ingredient> Items { get; set; } = new ();

    FoodService _foodService;

    public DetailViewModel()
    {
        this._foodService = new FoodService();
        LoadIngredientAsync();
    }

    async Task LoadIngredientAsync()
    {
        var category = await _foodService.GetIngredient();
        if (category == null)
            return;

        if (Items.Count() > 0)
            Items.Clear();
        Items.AddRange(category);
       
    }

    [RelayCommand]
    async Task GoToBackAsync()
    {
        await Shell.Current.GoToAsync("..");
    }

    [RelayCommand]
    async Task GoToAddOrderAsync(Food food)
    {
        if (Food != null)

        CurrentOrder.AddOrdersAsync(Food);

        var toast =  Toast.Make("Is Successful.");

        var cts = new CancellationTokenSource(TimeSpan.FromSeconds(10));

        await toast.Show(cts.Token);

    }
}
