using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Food_App.Model;

[INotifyPropertyChanged]
[Table("Food")]
public partial class Food
{
    [PrimaryKey, AutoIncrement]
    public int FoodID {  get; set; }
    public string? Image {  get; set; }
    public string Title {  get; set; }
    public string? Description { get; set; }
    public double Rating {  get; set; }
    public bool Selecte { get; set; }
    public int Ingredients { get; set; }

    [ForeignKey(typeof(Order))]
    public int OrderID { get; set; }

    [ManyToOne(CascadeOperations = CascadeOperation.All)]
    public Order Order { get; set; }

    [OneToMany(CascadeOperations = CascadeOperation.All)]
    public List<Ingredient> Ingredient { get; set; }

    [ObservableProperty]
    public bool productIsFav;

    [ObservableProperty]
    int price;

    [ObservableProperty]
    int quantity = 1;

    partial void OnQuantityChanged(int value)
    {
        OnPropertyChanged(nameof(SubTotal));
    }
    public double SubTotal
    {
        get
        {
            return Price * Quantity;
        }
    }


    [RelayCommand]
    void ProductFav()
    {
        ProductIsFav = !ProductIsFav;
    }

   
}
