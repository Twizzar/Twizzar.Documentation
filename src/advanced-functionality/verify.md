<script setup lang="ts">

const fixtureUrl = "../api/Twizzar.Fixture/";

const itemContextUrl = `${fixtureUrl}/IItemContext-2`;
const memberVerifierUrl = `${fixtureUrl}IMemberVerifier`;

const verifyMethodUrl = `${fixtureUrl}/IItemContext-2/Verify.html#iitemcontext-tfixtureitem-tpathprovider-verify-tmethodmemberpath-method-2-of-2`;
const verifyPropUrl = `${fixtureUrl}/IItemContext-2/Verify`;

const calledUrl = `${fixtureUrl}IMemberVerifier/Called`;
const calledAtLestOnceUrl = `${fixtureUrl}IMemberVerifier/CalledAtLeastOnce`;

const getUrl = `${fixtureUrl}IPropertyVerifier-1/Get`;
const setUrl = `${fixtureUrl}IPropertyVerifier-1/Set`;
</script>

# How to verify Method and Properties
Consider the following service:

```c#
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

To validate that the `Apply` method is called, the <a :href="itemContextUrl">`ItemContext`</a> can be used. The context can be used to get dependencies which are resolved and set by the ItemBuilder. But also for validating if a method or property was called. To validate if a method was called the <a :href="verifyMethodUrl">`Verify`</a> method can be used.

```c#{9-10}
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
The context can only be retrieved form a [Custom Item Builder](../key-concepts/item-builder.html#custom-item-builder).
:::

## Parameter verification

It is also possible to validate if a method is called with the right parameter. For this, Twizzar provides methods which get automatically generated.

```c#
public interface IStorage
{
    void Store(IIngredient ingredient);
    IIngredient Take(string ingredientName);
}

var storage = new MyIStorageBuilder()
    .Build(out var context);
```
To verify `IStorage.Take` is called where the `ingredientName` is `"MyPotion"`:
```c#{2}
context.Verify(p => p.Take)
    .WhereIngredientNameIs("MyPotion")
    .Called(1);
```

It is also possible to use a predicate to check for parameters here we check if the `IStorage.Store` method was called and the `ingredient` provided has the Name `"Mushroom"`.

```c#{2}
context.Verify(p => p.Store)
    .WhereIngredientIs(ingredient => ingredient.Name == "Mushroom")
    .Called(1);
```
If we setup the IStorage.Take method to return an specific ingredient, and the want to check if IStorage.Store is called and the set up ingredient was provided as parameter we could do the following:

```c#{2}
var ingredient = context.Get(p => p.Take);
context.Verify(p => p.Store)
    .WhereIngredientIs(ingredient)
    .Called(1);
```

But Twizzar also provides a Verify which can handle this in one statement.
```c#{2}
context.Verify(p => p.Store)
    .WhereIngredientIs(p => p.Take)
    .Called(1);
```

## Validate the count of calls
To validate the count of calls the `Called` method can be used. The `Called` method accepts an integer to set the call count. The `Called` method can also be used with the `CalledAtLeastOnce` method to validate that the method was called at least once.

```c#{3,7}
// called exactly twice
context.Verify(p => p.Store)
    .Called(2);

// called at least once
context.Verify(p => p.Store)
    .CalledAtLeastOnce();
```

## Property verification
The verification of a property works similar to the method verification, use the <a :href="verifyPropUrl">`Verify`</a> method on the <a :href="itemContextUrl">`ItemContext`</a> to select a property. Afterward use the <a :href="getUrl">`Get`</a> or <a :href="setUrl">`Set`</a> method to select the getter or setter of the property.

Verify the getter of `MyProperty` is called once:
```c#
context.Verify(p => p.MyProperty)
    .Get()
    .Called(1);
```

Verify the setter of `MyProperty` is called once:
```c#
context.Verify(p => p.MyProperty)
    .Set()
    .Called(1);
```

Verify the setter of `MyProperty` is called once and the set value is `"MyValue"`:
```c#
context.Verify(p => p.MyProperty)
    .Set("MyValue")
    .Called(1);
```
