# Basic types

All Basic types can be configured as unique. Basic types have a value and no members. The following types are basic types:

- Numeric Basic Types
- string
- char
- enums

## Numeric Basic Types

| Category                              | Type                      |
| ------------------------------------- | ------------------------- |
| Signed integral                       | sbyte, short, int, long   |
| Unsigned integral                     | byte, ushort, uint, ulong |
| IEEE binary floating-point            | float, double             |
| High-precision decimal floating-point | decimal                   |

## Unique value of basic types

**Numeric Basic Types**  
The algorithm to determine a new unique number acts on the underlying bit sequence of a certain numeric type. It alters the bit sequence to get a new not before seen number, till the definition space of the type is fully used, then it will start at the beginning.

**string**  
Uses `Guid.NewGuid().ToString();`.

**char**  
Uses the same algorithm as the Numeric Basic Types.
