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

```plaintext
[testProject:]
$projectUnderTest$.Tests
```

##### Mapping from the source project path to the test project path (absolute path to the project directory).

```plaintext
[testProjectPath:]
$solutionPath$/$projectUnderTest$.Tests
```

##### Mapping from the source file name to the test file name (without path and extension).

```plaintext
[testFile:]
$fileUnderTest$.Tests
```

##### Mapping from the source file path to the test file path (relative path to the test file directory).

```plaintext
[testFilePath:]
* : $1
```

##### Mapping from the source namespace to the test namespace.

```plaintext
[testNamespace:]
$namespaceUnderTest$.Tests
```

##### Mapping from the source class name to the test class name.

```plaintext
[testClass:]
$typeUnderTest$Tests
```

##### Mapping from the source method name to the test method name.

```plaintext
[testMethod:]
$memberUnderTest$_Scenario_ExpectedBehavior
```

### Additional Configurations

In addition to mapping configurations, this configuration file also contains settings for NuGet packages to install when a new project is created. These packages are specified in the `[nugetPackages:]` section, with each package listed on a separate line. You can specify the package ID and version if needed, or just the package ID for the latest stable version.

#### Sample NuGet Packages

```plaintext
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
