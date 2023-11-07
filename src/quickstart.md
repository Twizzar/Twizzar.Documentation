<script setup lang="ts">
import DocImg from '../components/DocImg.vue'
import VideoPlayer from '../components/VideoPlayer.vue'
</script>

# Quickstart

## Installation
Download and install the extension from the Visual Studio Marketplace: [https://marketplace.visualstudio.com/items?itemName=vi-sit.twizzar-vs22](https://marketplace.visualstudio.com/items?itemName=vi-sit.twizzar-vs22).

After the installation, restart Visual Studio.
The Extension should now be available under the Extension Menu:

<DocImg src="../images/Twizzar_Extension_Menu.png" alt="Extensions menu"/>

## Create your first test with TWIZZAR
After the installation of the extension, you can create your first test with TWIZZAR. To do this, right-click on the method you want to test and select "Create Unit Test" from the context menu.

<DocImg src="../images/Twizzar_Create_Unit_Test.png" alt="Create Unit Test"/>

TWIZZAR will now create a test class for you and insert the necessary code to create a test with Twizzar. If TWIZZAR cannot find the test project, it will ask if TWIZZAR should create one for you.

::: info Note
To customize the test generation process please see [Test Creation](./testCreation/mapping.html#mapping-configurations).
:::

<DockImg src="../images/Twizzar_Test_Class.png" alt="Test Class"/>


<VideoPlayer src="../videos/Hero.mp4" />

## Examples

An example project can be found under [examples/PotionDeliveryService](https://github.com/Twizzar/Twizzar/tree/main/examples/PotionDeliveryService), this is a good starting point to get familiar with Twizzar.
