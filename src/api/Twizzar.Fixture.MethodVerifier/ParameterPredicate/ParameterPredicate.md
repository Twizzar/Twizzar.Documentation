# ParameterPredicate constructor

Parameter predicate for method verification.

```csharp
public ParameterPredicate(Maybe<Type> ParameterType, 
    Expression<Func<object, Type, bool>> Expression)
```

| parameter | description |
| --- | --- |
| ParameterType | The parameter type this is equal to the method parameter type, except the parameter type contains a generic parameter, then the user needs to specify a constructed type. If this is None the user has not setuped a predicate for this parameter. |
| Expression |  |

## See Also

* record [ParameterPredicate](../ParameterPredicate.md)
* namespace [Twizzar.Fixture.MethodVerifier](../../Twizzar.Api.md)

<!-- DO NOT EDIT: generated by xmldocmd for Twizzar.Api.dll -->
