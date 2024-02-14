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
        //Order = CurrentOrder.CurrentOrders;
        Order.Currentitems.Remove(foodID);
    }
    [RelayCommand]
    async Task GetOrdersAsync()
    {
        Order = CurrentOrder.CurrentOrders;

        if (CurrentOrder.CurrentOrders.Currentitems == null)
        {
            Order.Currentitems = new List<Food>();
        }
    }
}