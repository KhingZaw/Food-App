using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Food_App.Model;
using MvvmHelpers;
using PointOfSale.Service;
using System.Collections.ObjectModel;

namespace Food_App.ViewModel;

[INotifyPropertyChanged]
public partial class CheckOutViewModel
{
    public ObservableRangeCollection<List<Order>> orders { get; set; } = new();
    //public ObservableCollection<List<Food>> foods { get; set; } = new();
    public CheckOutViewModel()
    {
    }
    [RelayCommand]
    async Task GoToBackAsync()
    {
        await Shell.Current.GoToAsync("..");
    }

    //[RelayCommand]
    //async Task DeletedOrderAsync(Order oriderID)
    //{
    //    var Orders = orders.Remove(foo);

    //    return;
    //}

    [RelayCommand]
    async Task GetOrdersAsync()
    {
        if (orders.Count > 0)
            orders.Clear();

        var order = FoodsDatabase.Orders;

        if (order == null) 
        {
            order = new List<Order>();
        }

        orders.Add(order);
    }
}