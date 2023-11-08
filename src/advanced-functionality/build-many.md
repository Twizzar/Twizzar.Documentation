# How to resolve more than one instance

If many unique instances are needed of a specific type, the `BuildMany(int count)` Method of the [ItemBuilder](../api/Twizzar.Fixture/IItemBuilder-1.html) can be used to get more than one instance. It is important to note that for each item a new object is created and configurations set to unique also get resolved with different vales for each item.

```csharp
// resolves the asked configuration n times:
var potions = new ItemBuilder<Potion>().BuildMany(5);
Assert.That(potions, Has.Count.EqualTo(5));
Assert.That(potions, Is.Unique);

// same can be done with specific custom builder:
var bluePotions = new BluePotionBuilder().BuildMany(50);
Assert.That(bluePotions, Has.Count.EqualTo(50));
Assert.That(bluePotions, Is.Unique);
```
