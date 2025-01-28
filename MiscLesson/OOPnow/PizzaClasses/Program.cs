Console.ReadKey();

public class Pizza
{
    private List<Ingredient> _ingredients = new List<Ingredient>();
    public void AddIngredient(Ingredient _ingredient) => _ingredients.Add(ingredient);
    public string Describe() =>
        $"This is a pizza with {string.Join(", ", _ingredients)}";

}

public class Ingredient
{
    
}

public class Cheddar
{
    public string name => "Cheddar Cheese";
    public int AgedForMonths { get; }
}

public class TomatoSauce
{
    public string name => "Tomato Sauce";
    public int TomatosIn100Grams { get; }
}

public class Mozzerella 
{
    public string name => "Mozzerella";
    public bool IsLight { get; }
}