# How to verify Method and Properties
Consider the following service:

```csharp
public class Consumer{
  private readonly IEffect _effect;

  public Consumer(IEffect effect){
    _effect = effect;
  }

  public void Apply(){
    _effect.Apply(this);
  }
}
```

When we now want to validate if the `Apply` method of the `IEffect` interface is called, we need access to the effect object.

To validate that the `Apply` method is called, the `ItemContext` can be used. The context can be used to get dependencies which are resolved and set by the ItemBuilder. But also for validating if a method was called.

```csharp
var consumer = new MyConsumerBuilder()
    .With(p => p.Ctor.effect.Stub<IEffect>())
    .Build(out var context);

consumer.Apply();

// to verify that the Apply method is called we select the Apply method.
// and the verify it with the Called method.
context.Verify(p => p.Ctor.effect.Apply)
    .Called();
```

::: info Note
The context can only be retrieved form a custom ItemBuilder.
:::

It is also possible to validate if a method is called with the right parameter. For this, Twizzar provides methods which get automatically generated.

```csharp
public interface IStorage
{
    void Store(IIngredient ingredient);
    IIngredient Take(string ingredientName);
}

var storage = new MyIStorageBuilder()
    .Build(out var context);

// To verify IStorage.Take is called where the ingredientName is MyPotion
context.Verify(p => p.Take)
    .WhereIngredientNameIs("MyPotion")
    .Called();

// It is also possible to use a predicate to check for parameters
// here we check if the IStorage.Store method was called and the ingredient provided has the Name Mushroom.
context.Verify(p => p.Store)
    .WhereIngredientIs(ingredient => ingredient.Name == "Mushroom");

// If we setup the IStorage.Take method to return an specific ingredient, and the want to check if IStorage.Store is called and the setuped ingredient was provided as parameter we could do the following:
var ingredient = context.Get(p => p.Take);
context.Verify(p => p.Store)
    .WhereIngredientIs(ingredient)
    .Called();

// But Twizzar also provides a Verify which can handle this in one statement.
context.Verify(p => p.Store)
    .WhereIngredientIs(p => p.Take)
    .Called();
```
