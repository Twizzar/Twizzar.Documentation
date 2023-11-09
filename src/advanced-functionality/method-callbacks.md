# How to set up method callbacks
For methods of an interface it is possible to provide a callback delegate. TWIZZAR generates a `Callback` method for every method of an interface. The `Callback` method accepts a function as a parameter. The function returns void and has the method parameters as its parameters.
```c#{7}
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

::: warning Important
Only one callback can be set up for a method. If multiple callbacks are set up the last one will be used.
:::
