using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_App.Model;

public static class CurrentOrder
{
    public static Order CurrentOrders { get; set; } = new Order();
    public static List<Food> CurrentOrderFood { get; set; } = new List<Food>();
    public static List<Food> AddOrdersAsync(Food food)
    {
        CurrentOrderFood.Add(food);

        CurrentOrders.Currentitems = CurrentOrderFood;

        return CurrentOrderFood;
    }
}
