# ItemBuilderBase&lt;TFixtureItem&gt; class

Base class for the item builders.

```csharp
public abstract class ItemBuilderBase<TFixtureItem>
```

| parameter | description |
| --- | --- |
| TFixtureItem |  |

## Public Members

| name | description |
| --- | --- |
| [AddMemberConfig](ItemBuilderBase-1/AddMemberConfig.md)(…) | Add or update a member config. |
| [Build](ItemBuilderBase-1/Build.md)() | Builds a concrete instance of type TFixtureItem as configured by this builder.  If TFixtureItem is a twizzar base-type a unique value of the given type will be returned.  If TFixtureItem is an interface, it will be a stub of Type TFixtureItem.  If TFixtureItem is a class, the type itself will be created via reflection. |
| [BuildMany](ItemBuilderBase-1/BuildMany.md)(…) | Builds many concrete instance of type TFixtureItem. The method [`Build`](./ItemBuilderBase-1/Build.md) will be called n times where `n = count`. |

## See Also

* namespace [Twizzar.Fixture](../Twizzar.Api.md)

<!-- DO NOT EDIT: generated by xmldocmd for Twizzar.Api.dll -->
