using CommunityToolkit.Mvvm.Input;
using Food_App.Model;
using Food_App.Services;
using Food_App.View;
using MvvmHelpers;
using ObservableObject = CommunityToolkit.Mvvm.ComponentModel.ObservableObject;

namespace Food_App.ViewModel;
public partial class FavoriteViewModel : ObservableObject
{
    FoodService _foodservice;

    public ObservableRangeCollection<Food> foods { get; set; } = new();

    public FavoriteViewModel() 
    {
        this._foodservice = new FoodService();
    }
    [RelayCommand]
    async Task GetFavsAsync()
    {
        var favs = await _foodservice.GetFoodAsync();

        if (favs == null)
            return;

        var fav = favs.Where(x => x.ProductIsFav == true).ToList();
        if(foods.Count > 0)
        {
           foods.Clear();
        }
        if(fav != null)
           foods.AddRange(fav);   
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
