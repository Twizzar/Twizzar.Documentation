# How to set up methods and properties with delegates

It is possible to provide a delegate instead of a literal to a method or property of an interface. The delegate will be called every time the member is invoked.

## Methods
For methods TWIZZAR automatically generates a `Value` method which accepts a function as a parameter. The function must return a value of the same type as the method and has the method parameters as its parameters.

```c#{8}
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
```

## Properties
For properties TWIZZAR automatically generates a `Value` method which accepts a function as a parameter. The function must return a value of the same type as the property and always has no parameters.

```c#{8}
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
