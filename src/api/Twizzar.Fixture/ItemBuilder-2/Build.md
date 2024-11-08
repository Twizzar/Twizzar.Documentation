# ItemBuilder&lt;TFixtureItem,TPathProvider&gt;.Build method

Builds a concrete instance of type TFixtureItem as configured by this builder.  If TFixtureItem is a twizzar base-type a unique value of the given type will be returned.  If TFixtureItem is an interface, it will be a stub of Type TFixtureItem.  If TFixtureItem is a class, the type itself will be created via reflection.

Unique has different meaning for different types:  * Numeric value: Uses an algorithm to create a unique value. * String: generates a GUID. * Chars: Uses the same algorithm as Numeric values. * Bool: Returns True.

```csharp
public TFixtureItem Build(out IItemContext<TFixtureItem, TPathProvider> itemContext)
```

| parameter | description |
| --- | --- |
| itemContext | The context which can be used for verifications and to get dependencies which are setup before. |

## Return Value

A instance of type TFixtureItem.

## See Also

* interface [IItemContext&lt;TFixtureItem,TPathProvider&gt;](../IItemContext-2.md)
* class [ItemBuilder&lt;TFixtureItem,TPathProvider&gt;](../ItemBuilder-2.md)
* namespace [Twizzar.Fixture](../../Twizzar.Api.md)

<!-- DO NOT EDIT: generated by xmldocmd for Twizzar.Api.dll -->
