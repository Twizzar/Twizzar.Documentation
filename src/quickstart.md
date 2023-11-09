<script setup lang="ts">
import DocImg from '../components/DocImg.vue'
import VideoPlayer from '../components/VideoPlayer.vue'

import TwizzarExtensionMenu from './images/Twizzar_Extension_Menu.png';

</script>

# Quickstart

## Installation
Download and install the extension from the Visual Studio Marketplace: [https://marketplace.visualstudio.com/items?itemName=vi-sit.twizzar-vs22](https://marketplace.visualstudio.com/items?itemName=vi-sit.twizzar-vs22).

After the installation, restart Visual Studio.
The Extension should now be available under the Extension Menu:

<DocImg :src="TwizzarExtensionMenu" alt="Extensions menu"/>

## Create your first test with TWIZZAR

TODO Video

### 1. Create a new Unit Test

After the installation of the extension, you can create your first test with TWIZZAR. To do this, right-click on the method you want to test and select "Create Unit Test" from the context menu. Alternative you also can use the shortcut <kbd>Ctrl</kbd> + <kbd>Alt</kbd> + <kbd>N</kbd>, <kbd>Ctrl</kbd> + <kbd>Alt</kbd> + <kbd>N</kbd>.

::: info Note
To use the create command, the editor cursor must be on the method signature or in the method block.
:::

<DocImg src="../images/Twizzar_Create_Unit_Test.png" alt="Create Unit Test"/>

TWIZZAR will now create a test class for you and insert the necessary code to create a test with Twizzar. If TWIZZAR cannot find the test project, it will ask if TWIZZAR should create one for you.

::: info Note
To customize the test generation process please see [Key concepts > Test creation > Configuration](key-concepts/test-creation.html#configuration).
:::

```c#:line-numbers
using NUnit.Framework;
using Twizzar.Fixture;
using PotionDeliveryService.Interfaces;
using PotionDeliveryService;
using System;

namespace PotionDeliveryService.Tests
{
    [TestFixture]
    public class StorageTests
    {
        [Test]
        [TestSource(nameof(Storage.Store))]
        public void Store_Scenario_ExpectedBehavior()
        {
            // Arrange
            var sut = new ItemBuilder<Storage>().Build();
            var ingredient = new ItemBuilder<IIngredient>().Build();

            // Act
            sut.Store(ingredient);

            // Assert
            Assert.Fail();
        }
    }
}
```

TWIZZAR creates an arrange block (Line 17-18) for you, the `sut` on line 17 is the System Under Test, this is the class which is tested. The `ingredient` on line 18 is the parameter of the method which is tested. They all use the `ItemBuilder` to create a new instance of the type. The `ItemBuilder` is a class of the TWIZZAR API it is used to create a new instance of a type and configure it. For more information about the `ItemBuilder` see [Item Builder](./key-concepts/item-builder.html).

In the act block (Line 21), the method which is tested is called with the parameters created in the arrange block.

The assert block (Line 24) only has a fail condition, this is because TWIZZAR does not know what should be asserted.

### 2. Rename the test
Twizzar generates a placeholder name for the unit test, this name should be changed to a meaningful name.

```c#:line-numbers=11{4}
⋯
[Test]
[TestSource(nameof(Storage.Store))]
public void Store_OnStore_IngredientIsAvailable()
⋯
```

### 3. Setup the System Under Test
The `ItemBuilder` class of TWIZZAR uses the builder pattern to set up an instance. It can be configured with the TWIZZAR UI or by code. 

::: info Note
The UI and the code both use the dependency tree to select members to set up. To learn more about the dependency tree see [ItemBuilder > Dependency Tree](./key-concepts/item-builder.html#dependency-tree).
:::

#### TWIZZAR UI
To open the TWIZZAR UI use the arrow behind the `ItemBuilder` or use the TWIZZAR open/close shortcut (<kbd>Ctrl</kbd> + <kbd>Alt</kbd> + <kbd>N</kbd>, <kbd>Ctrl</kbd> + <kbd>Alt</kbd> + <kbd>V</kbd>). Configure the member by entering a value in the input field.

<DocImg src="../images/Twizzar_UI.png" alt="Twizzar UI"/>

TWIZZAR will create a builder class inheriting from `new ItemBuilder<IIngredient>()`. Rename this class to something meaningful, for example, `WaterBuilder`.

#### Configure by code
To configure the `ItemBuilder` by code, use the `With` method. The `With` method accepts a function which returns a `MemberConfig` to create this `MemberConfig` Twizzar provides a path class as a parameter to the function to select and then configure a member.
```c#{2}
var ingredient = new ItemBuilder<IIngredient>()
    .With(p => p.Name.Value("Water"))
    .Build();
```

### 4. Assert the test
To finish the test we can now write the assertion.

```c#{3}
⋯
// Assert
Assert.IsTrue(sut.CheckAvailable(ingredient.Name));
```

::: info Note
TWIZZAR provides a `Verify` method for method or property verification. For more information see [Verify](./advanced-functionality/verify.html).
:::

### 5. Run the test

The test can now be run with the standard Visual Studio test runner or any other test runner of your choice. This was all needed for this test to run successfully.

## Examples

An example project can be found under [examples/PotionDeliveryService](https://github.com/Twizzar/Twizzar/tree/main/examples/PotionDeliveryService), this is a good starting point to get familiar with Twizzar.
