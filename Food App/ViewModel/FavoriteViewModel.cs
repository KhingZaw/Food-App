using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Food_App.Model;
using Food_App.Services;
using Food_App.View;
using MvvmHelpers;
using System.Diagnostics;
using ObservableObject = CommunityToolkit.Mvvm.ComponentModel.ObservableObject;

namespace Food_App.ViewModel;
public partial class FavoriteViewModel : ObservableObject
{
    FoodService _foodservice;

    public ObservableRangeCollection<Food> foodfav { get; set; } = new();

    [ObservableProperty]
    private bool isBusy;

    public FavoriteViewModel() 
    {
        this._foodservice = new FoodService();
    }

    [RelayCommand]
    async Task GetFavsAsync()
    {
        var favs = await _foodservice.GetFoodAsync();

        if (foodfav.Count > 0)
            foodfav.Clear();
        
        if (favs != null)
        {
            var foods = favs.Where(x=>x.productIsFav == true);
         
            foodfav.AddRange(foods);
        }
    }

    [RelayCommand]
    async Task ProductFavAsync(Food food)
    {
        if (food != null)
        {
            string fav = food.FoodID.ToString();

            try
            {
                var foods = foodfav.FirstOrDefault(p => p.FoodID.ToString() == fav);

                if (foods != null)
                {
                    IsBusy = true;

                    foods.ProductIsFav = false;

                    foodfav.Remove(foods);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Unable to get favoriteFood: {ex.Message}");
                await Shell.Current.DisplayAlert("Error!", ex.Message, "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }
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

}
