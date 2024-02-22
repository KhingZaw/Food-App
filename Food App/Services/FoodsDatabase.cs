using Food_App.Model;
using SQLite;

namespace PointOfSale.Service;
public class FoodsDatabase
{
    SQLiteAsyncConnection Database;
    public FoodsDatabase()
    {
        SetupDatabase();
    }
    private async void SetupDatabase()
    {
        if (Database is not null)
            return;
        string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "FoodServices.db3");
        Database = new SQLiteAsyncConnection(dbPath);
        await Database.CreateTablesAsync<Food, Order, Ingredient>();
    }

    public static List<Food> Foods = new ();
    public static List<Order> Orders { get; set; } = GenerateOrders();

    //FoodItem
    public async Task<List<Food>> GetItemsAsync()
    { 
        return await Database.Table<Food>().ToListAsync();
    }

    //public async Task<List<Item>> GetItemsNotDoneAsync()
    //{
    //    await Init();
    //    return await Database.Table<Item>().Where(t => t.Done).ToListAsync();

    //    // SQL queries are also possible
    //    //return await Database.QueryAsync<TodoItem>("SELECT * FROM [TodoItem] WHERE [Done] = 0");
    //}

    public async Task<Food> GetItemAsync(int id)
    {
        return await Database.Table<Food>().Where(i => i.FoodID == id).FirstOrDefaultAsync();
    }

    public async Task<int> AddItemAsync(Food food)
    {
        if (food.FoodID != 0)
        {
            return await Database.UpdateAsync(food);
        }
        else
        {
            return await Database.InsertAsync(food);
        }
    }

    public static List<Food> AddOrderItemsAsync(Food food)
    {
       if(food.FoodID != null)
        {
            Foods.Add(food);
        }
        return (Foods);
    }

    public async Task<int> DeleteItemAsync(Food food)
    {
        return await Database.DeleteAsync(food);
    }

    //Order
    public async Task<List<Order>> GetOrderAsync()
    {
       var result = await Database.Table<Order>().ToListAsync();

        return result;
    }
    private static List<Order> GenerateOrders()
    {
        List<Order> orders = new List<Order>();
        orders.Add((new Order()
        {
            Currentitems = Foods
        }));
        return(orders);
    }

    public async Task<int> AddOrderAsync(Order order)
    {
        if (order.OrderID != 0)
        {
            return await Database.UpdateAsync(order);
        }
        else
        {
            return await Database.InsertAsync(order);
        }
    }

}
