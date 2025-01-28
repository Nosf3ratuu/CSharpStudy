var pizza = new Pizza();
pizza.AddIngredient(new Cheddar());
pizza.AddIngredient(new TomatoSauce());
pizza.AddIngredient(new Mozzerella());
Console.WriteLine(pizza.Describe());

Console.ReadKey();
public class Pizza
{
    private List<Ingredient> _ingredients = new List<Ingredient>();
    public void AddIngredient(Ingredient ingredient) => _ingredients.Add(ingredient);
    public string Describe() =>
        $"This is a pizza with {string.Join(", ", _ingredients)}";
        

}

public class Ingredient
{
    public int PubliCField;
    public string PublicMethod() => "This method  is PUBLIC in the ingredient class";
    public string PrivateMethod() => "This method  is PRIVATE in the ingredient class";
    public string ProtectedMethod() => "This method  is PROTECTED in the ingredient class";
}

public class Cheddar : Ingredient
{
    public string name => "Cheddar Cheese";
    public int AgedForMonths { get; }

    public void UseMethodsFromBaseClass()
    {
        Console.WriteLine(PublicMethod());
    }
}
public class TomatoSauce : Ingredient
{
    public string name => "Tomato Sauce";
    public int TomatosIn100Grams { get; }
}

public class Mozzerella : Ingredient 
{
    public string name => "Mozzerella";
    public bool IsLight { get; }
}