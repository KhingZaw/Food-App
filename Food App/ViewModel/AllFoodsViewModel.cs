using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Food_App.Model;
using Food_App.Services;
using Food_App.View;
using MvvmHelpers;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using ObservableObject = CommunityToolkit.Mvvm.ComponentModel.ObservableObject;

namespace Food_App.ViewModel;

[QueryProperty(nameof(FromSearch),nameof(FromSearch))]
public partial class AllFoodsViewModel : ObservableObject
{
    [ObservableProperty]
    FoodService _foodService;

    public ObservableRangeCollection<Food> foods { get; set; } = new();

    public AllFoodsViewModel()
    {
        this._foodService = new FoodService();
    }
    [ObservableProperty]
    private bool _fromSearch;

    [ObservableProperty]
    private bool _searching;

    [RelayCommand]
   async Task GetFoodsAsync()
    {
        var food = await _foodService.GetFoodAsync();

        if (food != null)

        foods.AddRange(food);
    }

    [RelayCommand]
    async Task GoToDetailAsync(Food food)
    {
        if (food == null) return;
        await Shell.Current.GoToAsync(nameof(DetailPage), true, new Dictionary<string, object>
        {
            {"Food" , food }
        });
    }

    [RelayCommand]
    private async Task SearchFoods(string searchTerm)
    {
        foods.Clear();

        Searching = true;

        var food = await _foodService.GetFoodAsync();

        string.IsNullOrWhiteSpace(searchTerm);

        var searchitem = food.Where(p => p.title.Contains(searchTerm, StringComparison.OrdinalIgnoreCase));

        if (searchitem != null)
        {
            foods.AddRange(searchitem);
        }
        Searching = false;
    }
}
