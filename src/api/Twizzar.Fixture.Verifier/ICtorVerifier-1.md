# ICtorVerifier&lt;T&gt; interface

Ctor verifier for Verifying the constructor.

```csharp
public interface ICtorVerifier<T>
```

| parameter | description |
| --- | --- |
| T | The type of the class the constructor is creating. |

## Members

| name | description |
| --- | --- |
| [IgnoreParameter](ICtorVerifier-1/IgnoreParameter.md)(…) | Configure a parameter to be ignored for verification. |
| [SetupParameter](ICtorVerifier-1/SetupParameter.md)(…) | Provide an instance which will be used when the parameter will not be set to null. |
| [ShouldThrowArgumentNullException](ICtorVerifier-1/ShouldThrowArgumentNullException.md)() | Calls all constructors matching the given configuration n times, where n is the number of verifiable parameters. Without any configuration all parameters which have no default value are verifiable. With every call one of the verifiable parameter is set to null and a ArgumentNullException is expected. |

## See Also

* namespace [Twizzar.Fixture.Verifier](../Twizzar.Api.md)

<!-- DO NOT EDIT: generated by xmldocmd for Twizzar.Api.dll -->