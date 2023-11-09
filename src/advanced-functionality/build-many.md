# How to create multiple instances of a type

To create more than one instance of a certain type, use the `BuildMany(int count)` method of the [ItemBuilder](../api/Twizzar.Fixture/IItemBuilder-1.html) class. This method returns a collection of new objects of the specified type, each with different values for the unique configurations.

```csharp
// creates n instances of the given type:
var potions = new ItemBuilder<Potion>().BuildMany(5);
Assert.That(potions, Has.Count.EqualTo(5));
Assert.That(potions, Is.Unique);

// works with custom builders as well:
var bluePotions = new BluePotionBuilder().BuildMany(50);
Assert.That(bluePotions, Has.Count.EqualTo(50));
Assert.That(bluePotions, Is.Unique);
```
