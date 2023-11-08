<script setup lang="ts">
import DocImg from '../../components/DocImg.vue'
</script>

# Test creation
Twizzar offers a comprehensive set of features and configurations to automate and customize unit test creation:

Twizzar automatically generates unit tests for the current code member using shortcuts or the context menu. It creates projects, test classes, and test methods based on predefined mappings and templates.

Twizzar simplifies the unit testing process in Visual Studio, enhancing productivity by automating much of the test creation and allowing for extensive customization through configuration files and templates. It's a valuable tool for C# developers looking to efficiently create and manage unit tests.

## Unit test generation
Twizzar automatically creates a unit test for the current member, by either using the Shortcut (<kbd>CTRL</kbd>+<kbd>ALT</kbd>+<kbd>N</kbd>, <kbd>CTRL</kbd>+<kbd>ALT</kbd>+<kbd>N</kbd>) or context menu:

<DocImg src="../images/Twizzar_CodeEditor_UnitTest_Generation.png" alt="Create Unit Test"/>

Based on the [mapping](#mapping) and [template](#templating) a new project, a test class and a new test method for the member you want to test are created. Existing projects and test classes are going to be reused, if they match the [mapping](#mapping). Nuget packages or usings may be updated during the creation process.


## Configuration
The Twizzar configuration is used for unit test generation and navigation, and therefore it is separated into two files.
One containing the templates used for controlling the code created, the other is used for defining the destination where the generated tests are located. The configuration files are automatically generated if they don't exist in the moment of test creation. They are located at the same level as the Visual Studio solution file and have to be manually added to the source control.

- [Mapping](#mapping)
- [Templating](#templating)

## Mapping
The configuration file _(twizzar.config)_ serves as a central configuration for mapping configurations and various other settings. Its primary purpose is to define mappings between "Member Under Test" (MUT) and corresponding "Test Methods" for automated unit test creation. Additionally, it specifies NuGet packages to be included in newly created projects.

### Mapping Configurations

The mapping configurations define how MUTs are associated with their corresponding Test Methods. These mappings use placeholders enclosed in `$` symbols that will be dynamically replaced during the automated creation of unit tests. Below are some important details about mapping configurations:

#### Usage Notes

- All paths within this configuration file use forward slashes (`/`) as the directory separator.
- Variables enclosed in `$` symbols will be automatically populated by the Addin based on the context.
- A mapping can have multiple pattern matches, separated by a newline, but the first match encountered will be used.
- The syntax for a mapping is as follows: `<pattern> : <replacement>`
  - The pattern can contain wildcards (`*`), which correspond to any number of characters (greedy matching).
  - The replacement can contain back-references (`$1`, `$2`, etc.), which correspond to wildcard matches.
  - Both the pattern and replacement can contain variables enclosed in `$` symbols.
- To map everything to a given replacement, use the following syntax: `<replacement>`, this is the same as: `* : <replacement>`. This is useful for providing a default after other pattern matches.

#### Available Variables

The following variables are available for use in mapping configurations:

- `$solutionPath$`: The absolute path to the solution directory.
- `$projectUnderTest$`: The name of the project under test.
- `$fileUnderTest$`: The name of the file under test (without the file extension).
- `$namespaceUnderTest$`: The namespace of the class under test.
- `$typeUnderTest$`: The name of the class under test.
- `$memberUnderTest$`: The name of the member under test.

#### Sample Mappings

Here are some sample mappings for different aspects of unit testing:

##### Mapping from the source project name to the test project name.

```
[testProject:]
$projectUnderTest$.Tests
```

##### Mapping from the source project path to the test project path (absolute path to the project directory).

```
[testProjectPath:]
$solutionPath$/$projectUnderTest$.Tests
```

##### Mapping from the source file name to the test file name (without path and extension).

```
[testFile:]
$fileUnderTest$.Tests
```

##### Mapping from the source file path to the test file path (relative path to the test file directory).

```
[testFilePath:]
* : $1
```

##### Mapping from the source namespace to the test namespace.

```
[testNamespace:]
$namespaceUnderTest$.Tests
```

##### Mapping from the source class name to the test class name.

```
[testClass:]
$typeUnderTest$Tests
```

##### Mapping from the source method name to the test method name.

```
[testMethod:]
$memberUnderTest$_Scenario_ExpectedBehavior
```

### Additional Configurations

In addition to mapping configurations, this configuration file also contains settings for NuGet packages to install when a new project is created. These packages are specified in the `[nugetPackages:]` section, with each package listed on a separate line. You can specify the package ID and version if needed, or just the package ID for the latest stable version.

#### Sample NuGet Packages

```
[nugetPackages:]
Twizzar.Api
NUnit
NUnit3TestAdapter
```

## Examples

Example templates are located in the example source:

- [nunit](https://github.com/Twizzar/Twizzar/blob/main/defaultConfigs/NUnit/twizzar.config)
- [xunit](https://github.com/Twizzar/Twizzar/blob/main/defaultConfigs/XUnit/twizzar.config)
- [mstest](https://github.com/Twizzar/Twizzar/blob/main/defaultConfigs/MSTest/twizzar.config)

## Templating
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

::: warning Attention
- You can define and use custom tags as you want.
- Loops are not allowed
- A tag has to start with either upper or lower case alphabetic character. [a..zA..Z]
:::

This code template is designed to help you create unit tests in C# using Twizzar. It includes placeholders for various parts of a unit test, such as the test namespace, test class, test method, and the necessary using statements. Nuget packages to import are specified in [Mapping](./mapping#additional-configurations). Dynamic tags are provided to handle different scenarios, such as arranging objects and invoking methods or properties. Customize this template by replacing the placeholders with your specific code and test logic to efficiantly create unit tests for your C# codebase.

## Examples

Example templates are locatd in the example source:

- [nunit](https://github.com/Twizzar/Twizzar/blob/main/defaultConfigs/NUnit/twizzar.template)
- [xunit](https://github.com/Twizzar/Twizzar/blob/main/defaultConfigs/XUnit/twizzar.template)
- [mstest](https://github.com/Twizzar/Twizzar/blob/main/defaultConfigs/MSTest/twizzar.template)
