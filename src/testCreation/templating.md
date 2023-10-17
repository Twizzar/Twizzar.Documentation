The file _(twizzar.template)_ serves as a template for generating the content of a unit test. It contains placeholders and code snippets that can be customized to create comprehensive unit tests.

### Usage

- Utilize the code snippets and sections to structure your unit test as needed.
- When `<MyTag>` is used in a code snippet, it will be replaced with the code written under the `[MyTag:]` section.
- Some tags are dynamic and will be replaced by another tag depending on the context:

  - if a dynamic tag isn't defined, an internal default value is used
  - `<arrange>` will be replaced by:
    - `<sut-arrange>` if the type under test is non-static.
    - nothing if the type under test is static.
  - `<arguments-arrange>` will be replaced by:

    - `<method-arguments-arrange>` if the member under test is a method.
    - `<property-field-setter-arrange>` if the member under test is a property or field.

  - `<act>` will be replaced by:
    - `<void-method-act>` if the member under test is a non-static void method.
    - `<non-void-method-act>` if the member under test is a non-static non-void method.
    - `<static-void-method-act>` if the member under test is a static void method.
    - `<static-non-void-method-act>` if the member under test is a static non-void method.
    - `<property-field-getter-act>` if the member under test is a property without a setter.
    - `<property-field-setter-act>` if the member under test is a property with a setter.
    - `<async-method-act:>` if the member under test is an async method that returns a task without result.
    - `<async-result-method-act:>` if the member under test is an async method that returns a task with result.
    - `<static-async-method-act:>` if the member is a static async method that returns a task without result.
    - `<static-async-result-method-act:>` if the member is a static async method that returns a task with result.

> **Attention:**
>
> - You can define and use custom tags as you want.
> - Loops are not allowed
> - A tag has to start with either upper or lower case alphabetic character. [a..zA..Z]

This code template is designed to help you create unit tests in C# using Twizzar. It includes placeholders for various parts of a unit test, such as the test namespace, test class, test method, and the necessary using statements. Nuget packages to import are specified in [Mapping](./mapping#additional-configurations). Dynamic tags are provided to handle different scenarios, such as arranging objects and invoking methods or properties. Customize this template by replacing the placeholders with your specific code and test logic to efficiantly create unit tests for your C# codebase.

## Examples

Example templates are locatd in the example source:

- [nunit](https://github.com/Twizzar/Twizzar/blob/main/defaultConfigs/NUnit/twizzar.template)
- [xunit](https://github.com/Twizzar/Twizzar/blob/main/defaultConfigs/XUnit/twizzar.template)
- [mstest](https://github.com/Twizzar/Twizzar/blob/main/defaultConfigs/MSTest/twizzar.template)
