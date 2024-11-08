# ParameterPredicate record

Parameter predicate for method verification.

```csharp
public record ParameterPredicate
```

## Public Members

| name | description |
| --- | --- |
| [ParameterPredicate](ParameterPredicate/ParameterPredicate.md)(…) | Parameter predicate for method verification. |
| [Expression](ParameterPredicate/Expression.md) { get; set; } |  |
| [ParameterType](ParameterPredicate/ParameterType.md) { get; set; } | The parameter type this is equal to the method parameter type, except the parameter type contains a generic parameter, then the user needs to specify a constructed type. If this is None the user has not setuped a predicate for this parameter. |
| [IsMatching](ParameterPredicate/IsMatching.md)(…) | The argument provided to a method is matching the predicate. |

## See Also

* namespace [Twizzar.Fixture.MethodVerifier](../Twizzar.Api.md)

<!-- DO NOT EDIT: generated by xmldocmd for Twizzar.Api.dll -->
