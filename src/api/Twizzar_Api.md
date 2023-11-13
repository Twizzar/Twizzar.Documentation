# Twizzar.Api assembly

## Twizzar.Fixture namespace

| public type | description |
| --- | --- |
| interface [IItemBuilder&lt;TFixtureItem&gt;](./Twizzar.Fixture/IItemBuilder-1.md) | Builder for configuring a fixture item then building a concrete instance of it. |
| interface [IItemContext&lt;TFixtureItem&gt;](./Twizzar.Fixture/IItemContext-1.md) | The item scope contains information gathered while creating the fixture item. |
| interface [IItemContext&lt;TFixtureItem,TPathProvider&gt;](./Twizzar.Fixture/IItemContext-2.md) | The item scope contains information gathered while creating the fixture item. |
| interface [IMemberVerifier](./Twizzar.Fixture/IMemberVerifier.md) | Service for verifying members. |
| interface [IMethodVerifier&lt;TFixtureItem,TPathProvider,TMethodPathMember&gt;](./Twizzar.Fixture/IMethodVerifier-3.md) | Service for verifying methods. |
| interface [IPathSelectionProvider&lt;TFixtureItem&gt;](./Twizzar.Fixture/IPathSelectionProvider-1.md) | Marker interface used by the source generator to find object which provides path selections. |
| interface [IPathSelectionProvider&lt;TFixtureItem,TPathProvider&gt;](./Twizzar.Fixture/IPathSelectionProvider-2.md) | Marker interface used by the source generator to find object which provides path selections. |
| interface [IPropertySetOrGetVerifier](./Twizzar.Fixture/IPropertySetOrGetVerifier.md) | Service for selecting a getter or setter of a property for verification. |
| interface [IPropertyVerifier&lt;TDeclaredType&gt;](./Twizzar.Fixture/IPropertyVerifier-1.md) | Service for further configuration the property verification. |
| class [ItemBuilder&lt;TFixtureItem&gt;](./Twizzar.Fixture/ItemBuilder-1.md) | Builder for configuring a fixture item then building a concrete instance of it. |
| class [ItemBuilder&lt;TFixtureItem,TPathProvider&gt;](./Twizzar.Fixture/ItemBuilder-2.md) | Builder for configuring a fixture item then building a concrete instance of it. |
| abstract class [ItemBuilderBase&lt;TFixtureItem&gt;](./Twizzar.Fixture/ItemBuilderBase-1.md) | Base class for the item builders. |
| static class [ItemContext](./Twizzar.Fixture/ItemContext.md) | Static helper class for [`IItemContext`](./Twizzar.Fixture/IItemContext-1.md). |
| class [OriginalNameAttribute](./Twizzar.Fixture/OriginalNameAttribute.md) | Attribute to annotate member paths with their original name. |
| abstract class [PathProvider&lt;TFixtureItem&gt;](./Twizzar.Fixture/PathProvider-1.md) | Provides member paths. Is used for configure an [`ItemBuilder`](./Twizzar.Fixture/ItemBuilder-2.md). |
| class [TestSourceAttribute](./Twizzar.Fixture/TestSourceAttribute.md) | Attribute to define the method under test on a test method. |
| struct [TzAnyStruct](./Twizzar.Fixture/TzAnyStruct.md) | Marker struct for declaring paths types with any struct type. |
| class [TzParameter](./Twizzar.Fixture/TzParameter.md) | Infos about a method parameter. |
| class [TzVoid](./Twizzar.Fixture/TzVoid.md) | Marker class for declaring paths with the return type void. |
| class [VerificationException](./Twizzar.Fixture/VerificationException.md) | Exception throw when a verification failed. |
| static class [Verify](./Twizzar.Fixture/Verify.md) | Static twizzar class for verifying code. |

## Twizzar.Fixture.Member namespace

| public type | description |
| --- | --- |
| class [CtorParamBasetypeMemberPath&lt;TFixtureItem,TParameterType&gt;](./Twizzar.Fixture.Member/CtorParamBasetypeMemberPath-2.md) | Member path for a constructor parameter where the type is a twizzar base-tye. |
| class [CtorParamMemberPath&lt;TFixtureItem,TParameterType&gt;](./Twizzar.Fixture.Member/CtorParamMemberPath-2.md) | Member path for a constructor parameter. |
| class [FieldBasetypeMemberPath&lt;TFixtureItem,TReturnType&gt;](./Twizzar.Fixture.Member/FieldBasetypeMemberPath-2.md) | Member path for a field where the return type is a twizzar base-tye. |
| class [FieldMemberPath&lt;TFixtureItem,TReturnType&gt;](./Twizzar.Fixture.Member/FieldMemberPath-2.md) | Member path for a field. |
| interface [IBaseTypePath&lt;TFixtureItem&gt;](./Twizzar.Fixture.Member/IBaseTypePath-1.md) | A member where the return type is a twizzar base-type. |
| interface [IInstancePath&lt;TFixtureItem&gt;](./Twizzar.Fixture.Member/IInstancePath-1.md) | Path of an instance member like Property, Field or an Method. |
| class [ItemCallbackConfig&lt;TFixtureItem&gt;](./Twizzar.Fixture.Member/ItemCallbackConfig-1.md) |  |
| class [ItemDelegateConfig&lt;TFixtureItem&gt;](./Twizzar.Fixture.Member/ItemDelegateConfig-1.md) |  |
| class [MemberConfig&lt;TFixtureItem&gt;](./Twizzar.Fixture.Member/MemberConfig-1.md) | A configuration of a member. |
| abstract class [MemberPath&lt;TFixtureItem&gt;](./Twizzar.Fixture.Member/MemberPath-1.md) |  |
| abstract class [MemberPath&lt;TFixtureItem,TReturnType&gt;](./Twizzar.Fixture.Member/MemberPath-2.md) |  |
| class [MethodBasetypeMemberPath&lt;TFixtureItem,TReturnType,TDeclaredType&gt;](./Twizzar.Fixture.Member/MethodBasetypeMemberPath-3.md) | Member path for a method where the return type is a twizzar base-tye.. |
| class [MethodMemberPath&lt;TFixtureItem,TReturnType,TDeclaredType&gt;](./Twizzar.Fixture.Member/MethodMemberPath-3.md) | Member path for a method. |
| class [PropertyBasetypeMemberPath&lt;TFixtureItem,TReturnType&gt;](./Twizzar.Fixture.Member/PropertyBasetypeMemberPath-2.md) | Member path for a property where the return type is a twizzar base-tye. |
| class [PropertyMemberPath&lt;TFixtureItem,TReturnType&gt;](./Twizzar.Fixture.Member/PropertyMemberPath-2.md) | Member path for a property. |

## Twizzar.Fixture.MethodVerifier namespace

| public type | description |
| --- | --- |
| record [ParameterPredicate](./Twizzar.Fixture.MethodVerifier/ParameterPredicate.md) | Parameter predicate for method verification. |

## Twizzar.Fixture.Utils namespace

| public type | description |
| --- | --- |
| static class [ItemBuilderHelperMethods](./Twizzar.Fixture.Utils/ItemBuilderHelperMethods.md) | Helper methods for the [`ItemBuilder`](./Twizzar.Fixture/ItemBuilder-1.md). |

## Twizzar.Fixture.Verifier namespace

| public type | description |
| --- | --- |
| class [CtorVerifierException](./Twizzar.Fixture.Verifier/CtorVerifierException.md) | Error occurred when verifying ctor. |
| interface [ICtorVerifier&lt;T&gt;](./Twizzar.Fixture.Verifier/ICtorVerifier-1.md) | Ctor verifier for Verifying the constructor. |

<!-- DO NOT EDIT: generated by xmldocmd for Twizzar.Api.dll -->
