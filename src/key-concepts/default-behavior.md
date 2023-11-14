<script setup lang="ts">
import DocImg from '../../components/DocImg.vue'

// image source
import TwizzarDefaultBehaviorFlow from '../images/Twizzar_Default_Behavior_Flow.svg';
</script>

# Default behavior

If a required member is not configured, the default behavior will be applied. Required member are all constructor parameters. Other members are not configured in TWIZZAR, we call this state `undefined`.

The default behavior is defined different for the requested type:

## Basic types

Unique will be used, see [Basic types](./basic-types).

## Interfaces

For all interfaces a default [Mock object](https://github.com/moq/moq4) is created. This means:

- All Properties and Methods will return the default value (`default(T)`)

## Structs, classes and records

The greatest constructor is used, and all its parameters are resolved with the default behavior. This means the dependency will be resolved recursively until a basic type or an interface is reached.

::: details Definition of the greatest constructor
The greatest constructor is defined as the constructor with the **most parameters**. When there are more than one constructor with max parameters, then one is selected over a hash function by Twizzar. The selection is arbitrary but deterministic. This always means the same constructor is selected.
:::

# Override the Default behavior

The default behavior can be overridden by configuring the member. There are two ways to configure the member:

- In a CustomBuilder per code or per Twizzar UI
- In the Unit test in the `With` Method

The configuration in the Unit Test is the strongest and will override all other, and the default behavior is the weakest.

<DocImg :src="TwizzarDefaultBehaviorFlow" alt="Default behavior override flow"/>
