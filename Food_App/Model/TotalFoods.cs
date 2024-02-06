namespace Food_App.Model;

public class TotalFoods
{
    public int totalFoodsID {  get; set; }
    public int foodID { get; set; }
    public string? title { get; set;}

    public required Food foods { get; set; }
}
