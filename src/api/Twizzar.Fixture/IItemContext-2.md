# IItemContext&lt;TFixtureItem,TPathProvider&gt; interface

The item scope contains information gathered while creating the fixture item.

```csharp
public interface IItemContext<TFixtureItem, TPathProvider> : 
    IPathSelectionProvider<TFixtureItem, TPathProvider>
    where TPathProvider : new()
```

| parameter | description |
| --- | --- |
| TFixtureItem | The fixture item type. |
| TPathProvider | The type of the path provider. |

## Members

| name | description |
| --- | --- |
| [Get&lt;TReturnType&gt;](IItemContext-2/Get.md)(…) | Get a configured member or dependencies of the fixture item. |
| [GetAsMoq&lt;TReturnType&gt;](IItemContext-2/GetAsMoq.md)(…) | Gets a configured member or dependencies of the fixture item as an Mock. |
| [Verify&lt;TReturnType&gt;](IItemContext-2/Verify.md)(…) | Start the verification of a property. |
| [Verify&lt;TMethodMemberPath&gt;](IItemContext-2/Verify.md)(…) | Start the verification of a method. |

## See Also

* interface [IPathSelectionProvider&lt;TFixtureItem,TPathProvider&gt;](./IPathSelectionProvider-2.md)
* namespace [Twizzar.Fixture](../Twizzar.Api.md)

<!-- DO NOT EDIT: generated by xmldocmd for Twizzar.Api.dll -->