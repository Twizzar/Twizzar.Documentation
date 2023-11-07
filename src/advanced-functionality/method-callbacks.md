# How to set up method callbacks

For methods of an interface it is also possible to provide a callback delegate.

```csharp
public interface IStorage
{
    bool CheckAvailable(string ingredientName);
}

var storage = new ItemBuilder<IStorage>()
    .With(p => p.CheckAvailable.Callback(name => Console.WriteLine(name)))
    // it is also possible to provide a return value and a callback
    .With(p => p.CheckAvailable.Value(true))
    .Build();
```
