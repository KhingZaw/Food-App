using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Food_App.Model;

[Table("Ingredient")]
public class Ingredient
{
    [PrimaryKey, AutoIncrement]
    public int IngredientID { get; set; }
    public string Name { get; set; }
    public string Images { get; set; }
    public bool Selecete { get; set; }

    [ForeignKey(typeof(Food))]
    public int FoodID { get; set; }

    [ManyToOne(CascadeOperations = CascadeOperation.All)]
    public Food Food { get; set; }
}
