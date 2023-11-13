# Analyzer diagnostics

## TZ0001

⚠️ TZ0001: Unexpected error occurred in Path Generation.

### Cause

An unexpected occurred in he Twizzar analyzer, this most likely happens when a state is reached that was not expected.

### How to fix the warning

This is most likely a Bug, if Twizzar does not work as expected, please make a Bug report under: [https://github.com/Twizzar/Twizzar/issues](https://github.com/Twizzar/Twizzar/issues)

## TZ0002

⚠️ TZ0002: Only public and internal types are supported.

### Cause

When a private or protected member is used in the `ItemBuilder` this warning will be shown by the Twizzar analyzer.

### How to fix the warning

Private and protected types are not supported, change the accessibility to internal or public.
