namespace Food_App.Model;
public partial class Food 
{
    public int foodID {  get; set; }
    public string? image {  get; set; }
    public string? title {  get; set; }
    public string? description { get; set; }
    public double rating {  get; set; }
    public bool favorites {  get; set; }
    public int price {  get; set; }
    public int total { get; set; }
    public bool selecte { get; set; }
    public int ingredients { get; set; }
    public int ingredientID { get; set; }
   
    public Ingredient? ingredient {  get; set; }
}
