using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Food_App.Model;
[INotifyPropertyChanged]
public partial class Food 
{
    public int foodID {  get; set; }
    public string? image {  get; set; }
    public string title {  get; set; }
    public string? description { get; set; }
    public double rating {  get; set; }
    public bool selecte { get; set; }
    public int ingredients { get; set; }
    public int ingredientID { get; set; }

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
    public Ingredient? ingredient {  get; set; }
}
