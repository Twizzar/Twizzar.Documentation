# How to set up methods and properties with delegates

It is possible to provide a delegate instead of a literal to a method or property of an interface. The delegate will be called every time the member is invoked.

```csharp
// methods
public interface IStorage
{
    bool CheckAvailable(string ingredientName);
}

var storage = new ItemBuilder<IStorage>()
    .With(p => p.CheckAvailable.Value(name => name.Contains("Potion")))
    .Build();

// this returns false
storage.CheckAvailable("Water");

// this returns true
storage.CheckAvailable("Mana Potion");

// properties
public interface IIngredient
{
    string Name { get; }
}

var counter = 0;
var ingredient = new ItemBuilder<IIngredient>()
    .With(p => p.Name.Value(() => $"Ingredient{counter++}"))
    .Build();

_ = ingredient.Name; // Ingredient0
_ = ingredient.Name; // Ingredient1
```
