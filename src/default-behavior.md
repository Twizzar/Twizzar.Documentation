# Default behavior

If a member is not configured, the default behavior will be applied. The default behavior is defined different for the requested type:

## Basic types

Unique will be used see [Basic types](./basic-types).

## Interfaces

For all interfaces a defaukt [Mock object](https://github.com/moq/moq4) is created. This means:

- All Properties and Methods will return the default value (`default(T)`)

## Structs, classes and records

The greatest constructor will be used and all its parameter will be resolved with the default behavior. This means the dependecy will be resolved recursively till a basic type or a interface is reached.

<details>
  <summary>Definition of the greatest constructor</summary>
    <blockquote>The greatest constructor is defined as the constructor with the most parameters. When there are more than one constructor with max parameters, then one is selected over a hash function by Twizzar. The selection is arbitrary but deterministic. This always means the same constructor is selected.
    </blockquote>
</details>

# Override the Default behavior

The default behavior can be overridden by configuring the member. There are two way to configure the member:

- In a CustomBuilder per code or per Twizzar UI
- In the Unit test in the `With` Method

The configuration in the Unit Test is the strongest and will override all other, and the default behavior is the weakest.

```mermaid
flowchart LR;
    cb(Custom Builder) -- overrides --> sd(System Default);
    ut(Unit Test) -- overrides --> cb;
```
