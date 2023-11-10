---
outline: deep
---

# How to work with generics

With Twizzar, you can easily configure, mock, and verify the behavior of generic methods in your unit tests. This feature allows you to set up method responses for different type parameters, specify delegates for method calls, add callbacks, and perform verifications. This section will guide you through the process of using Twizzar to work with generic methods effectively.

## Setting Up Generic Methods

You can configure generic methods using Twizzar to return specific values for different type parameters. Here's how it works:

```c#
[Test]
public void Setup_method_with_a_typeParameter_as_return_type()
{
    var sut = new ItemBuilder<IGenericExample>()
        .With(p => p.SimpleGenericMethodT.Value(5))
        .Build();

    Assert.AreEqual(5, sut.SimpleGenericMethod<int>());
    Assert.AreEqual(5, sut.SimpleGenericMethod<object>());
    Assert.AreEqual(null, sut.SimpleGenericMethod<string>());
}
```

With the IGenericExample interface defined as follows:

```c#
interface IGenericExample
{
    T SimpleGenericMethod<T>();
}
```

In this example, the `SimpleGenericMethod<T>()` method is set up to return `5` when called with `int` or `object` type parameters. Other type parameters will return their default values.

## Naming of Generic Methods

To differentiate between methods with the same name but different type parameters, Twizzar appends type parameter names to the method name. Here's an example:

```c#
[Test]
public void Naming_of_generic_methods()
{
    var sut = new ItemBuilder<IGenericExample>()
        .With(p => p.MyMethod.Value(5))
        .With(p => p.MyMethodT.Value("test"))
        .With(p => p.MyMethodTK.Value((3, 4f)))
        .Build();

    Assert.AreEqual(5, sut.MyMethod());
    Assert.AreEqual("test", sut.MyMethod<string>());
    Assert.AreEqual((3, 4f), sut.MyMethod<int, float>());
}
```

With the IGenericExample interface defined as follows:

```c#
interface IGenericExample
{
    int MyMethod();
    T MyMethod<T>();
    (T, K) MyMethod<T, K>();
}
```

In this case, `MyMethod()` becomes `MyMethod`, `MyMethod<T>` becomes `MyMethodT`, and `MyMethod<T, K>()` becomes `MyMethodTK`.

## Setting Up Value Delegates

Twizzar allows you to assign delegates to generic methods for custom behavior. Here's an example of setting up a delegate for `CreateList<T>()`:

```c#
[Test]
public void Setup_value_delegate()
{
    var sut = new ItemBuilder<IGenericExample>()
        .With(p => p.CreateListT.Value<int>(items => items.ToList()))
        .Build();

    var list = sut.CreateList(1, 2, 3);
    Assert.AreEqual(1, list[0]);
    Assert.AreEqual(2, list[1]);
    Assert.AreEqual(3, list[2]);
}
```

The CreateList method is defined as follows:

```c#
IList<T> CreateList<T>(params T[] items);
```

In this example, the `CreateList<T>()` method is configured to use a custom delegate to create a list from the given items.

## Setting Up a Callback

You can add callbacks to generic methods to capture their input parameters and perform custom actions. Here's an example of setting up a callback for `CreateList<T>()`:

```c#
[Test]
public void Setup_a_callback()
{
    var myList = new List<int[]>();

    var sut = new ItemBuilder<IGenericExample>()
        .With(p => p.CreateListT.Callback<int>(items => myList.Add(items)))
        .Build();

    sut.CreateList(1);

    Assert.Contains(1, myList.Single());
}
```

In this case, a callback is used to add the input parameters of the `CreateList<T>()` method to the `myList` collection.

## Verifying Parameter Usage

Twizzar allows you to verify the usage of parameters in generic methods. Here's an example of verifying parameter usage for the `CreateList<T>()` method:

```c#
[Test]
public void Verify_parameter()
{
    var sut = new IGenericExampleBuilder()
        .Build(out var context);

    sut.CreateList(1, 2, 3);

    context.Verify(p => p.CreateListT)
        .WhereItemsIs<int>(items => items.Contains(1) && items.Contains(2) && items.Contains(3))
        .Called(1);
}
```

The `WhereItemsIs` method now takes not only a predicate but also a type parameter. This addition is essential because Twizzar distinguishes between methods with different type arguments. Meanwhile, the Called(1) method confirms that the `CreateList<T>()` method was invoked once.
