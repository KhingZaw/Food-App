using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Food_App.Model;
using Food_App.Services;
using Food_App.View;
using MvvmHelpers;
using System.ComponentModel;
using System.Diagnostics;

namespace Food_App.ViewModel;

[INotifyPropertyChanged]
public partial class HomeViewModel
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
    async Task GoToAllFoodsPageAsync(bool fromSearch = false)
    {
        var parameter = new Dictionary<string, object>
        {
            [nameof(AllFoodsViewModel.FromSearch)] = fromSearch
        };

        await Shell.Current.GoToAsync(nameof(AllFoodsPage), true, parameter);
    }


    [RelayCommand]
    async Task GoToAddOrderAsync(Food food)
    {
        var result = await Shell.Current.DisplayAlert("Add Order", $"Are you want to add order \"{food.title}\"?", "Ok", "Cancel");
        
        if(result is true)
        {
            try
            {
                CurrentOrder.AddOrdersAsync(food);

                var toast = Toast.Make("Add Order is Successful.");

                var cts = new CancellationTokenSource(TimeSpan.FromSeconds(10));

                await toast.Show(cts.Token);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Unable to get userstory: {ex.Message}");
                await Shell.Current.DisplayAlert("Error!", ex.Message, "OK");
            }

        }
    }

    [RelayCommand]
    async Task GetFoodsAsync() 
    {
        try
        {
            var food = await _foodService.GetFoodAsync();
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