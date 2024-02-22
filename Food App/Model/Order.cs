using CommunityToolkit.Mvvm.ComponentModel;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Food_App.Model;

[INotifyPropertyChanged]
[Table("Order")]
public partial class Order
{
    [PrimaryKey,AutoIncrement]
    public int OrderID { get; set; }
    public DateTime StateDateTime { get; set; }= DateTime.Now;
    public DateTime EndDateTime { get; set; }= DateTime.Now;

    [ObservableProperty]
    private double tip;

    public string Total
    {
        get
        {
            var tot = Currentitems.Sum(i => i.SubTotal);

            if (Tip != 0)
                tot = tot + (tot * Tip);

            return tot.ToString();
        }
    }

    [OneToMany(CascadeOperations = CascadeOperation.All)]
    public List<Food> Currentitems { get;set; }

    [ObservableProperty]
    private string status;

}
