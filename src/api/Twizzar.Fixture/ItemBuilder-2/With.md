# ItemBuilder&lt;TFixtureItem,TPathProvider&gt;.With method

Configure a member. To configure the member use a lambda.

```csharp
new ItemBuilder<Car>()
    .With(p => p.Engine.CylinderCount.Value(4))
    .Build();
```

```csharp
public ItemBuilder With(Func<TPathProvider, MemberConfig<TFixtureItem>> func)
```

| parameter | description |
| --- | --- |
| func | A function which returns an [`MemberConfig`](../../Twizzar.Fixture.Member/MemberConfig-1.md). The function parameter provides access to [`MemberPath`](../../Twizzar.Fixture.Member/MemberPath-1.md) every member path provides methods for configure the member for example: `.Value()`. |

## Return Value

Itself for further configuration or for building the instance.

## See Also

* class [MemberConfig&lt;TFixtureItem&gt;](../../Twizzar.Fixture.Member/MemberConfig-1.md)
* class [ItemBuilder&lt;TFixtureItem,TPathProvider&gt;](../ItemBuilder-2.md)
* namespace [Twizzar.Fixture](../../Twizzar.Api.md)

<!-- DO NOT EDIT: generated by xmldocmd for Twizzar.Api.dll -->
