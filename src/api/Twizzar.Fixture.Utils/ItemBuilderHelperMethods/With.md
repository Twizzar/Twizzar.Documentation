# ItemBuilderHelperMethods.With&lt;TFixtureItem,TPathProvider&gt; method

Provides the [`With`](../../Twizzar.Fixture/ItemBuilder-2/With.md) methods for [`ItemBuilder`](../../Twizzar.Fixture/ItemBuilder-1.md).

```csharp
public static ItemBuilderBase<TFixtureItem> With<TFixtureItem, TPathProvider>(
    ItemBuilderBase<TFixtureItem> builder, Func<TPathProvider, MemberConfig<TFixtureItem>> func)
    where TPathProvider : new()
```

| parameter | description |
| --- | --- |
| TFixtureItem | The type of the fixture item. |
| TPathProvider | The type of the path provider. |
| builder |  |
| func |  |

## Return Value

The provides builder.

## See Also

* class [ItemBuilderBase&lt;TFixtureItem&gt;](../../Twizzar.Fixture/ItemBuilderBase-1.md)
* class [MemberConfig&lt;TFixtureItem&gt;](../../Twizzar.Fixture.Member/MemberConfig-1.md)
* class [ItemBuilderHelperMethods](../ItemBuilderHelperMethods.md)
* namespace [Twizzar.Fixture.Utils](../../Twizzar.Api.md)

<!-- DO NOT EDIT: generated by xmldocmd for Twizzar.Api.dll -->