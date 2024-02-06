using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Food_App.Model;
using Food_App.Services;
using Food_App.View;
using MvvmHelpers;
using System.Diagnostics;
using ObservableObject = MvvmHelpers.ObservableObject;

namespace Food_App.ViewModel;

public partial class HomeViewModel : ObservableObject
{
    FoodService _foodService;

    public ObservableRangeCollection<Food> foods {get; set; } = new();

    public HomeViewModel() 
    {
        this._foodService = new FoodService();
    }

    [RelayCommand]
    async Task GoToDetailAsync(Food food)
    {
        if (food == null) return;
        await Shell.Current.GoToAsync(nameof(DetailPage),true,new Dictionary<string, object>
        {
            {"Food" , food }
        });
    }

    [RelayCommand]
    async Task GetFoodsAsync() 
    {
        try
        {
            var food = await _foodService.GetCategoryAsync();
            if (foods.Count > 0)
            {
                foods.Clear();
            }

            if (food != null)
                foods.AddRange(food);

        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Unable to get userstory: {ex.Message}");
            await Shell.Current.DisplayAlert("Error!", ex.Message, "OK");
        }
    }

}