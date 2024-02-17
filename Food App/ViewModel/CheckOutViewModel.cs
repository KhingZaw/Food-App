using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Food_App.Model;

namespace Food_App.ViewModel;

[INotifyPropertyChanged]
public partial class CheckOutViewModel
{
    [ObservableProperty]
    Order order;

    public CheckOutViewModel()
    {
    }
    [RelayCommand]
    async Task GoToBackAsync()
    {
        await Shell.Current.GoToAsync("..");
    }

    [RelayCommand]
    async Task DeletedOrderAsync(Food foodID)
    {
        var Orders = Order.Currentitems.Remove(foodID);

        return;
    }

    [RelayCommand]
    async Task GetOrdersAsync()
    {
        Order = CurrentOrder.CurrentOrders;

        if (Order == null) 
        {
            Order.Currentitems = new List<Food>();
        }
    }
}