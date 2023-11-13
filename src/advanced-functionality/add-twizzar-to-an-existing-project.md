<script setup lang="ts">
import DocImg from '../../components/DocImg.vue'

// image source
import TwizzarProject from '../images/Twizzar_Project.png';
</script>

# How to add Twizzar to an existing project
The NuGet packages is available at: [https://www.nuget.org/packages/Twizzar.Api/](https://www.nuget.org/packages/Twizzar.Api/)

To install the package in your unit test project, use the [Package Manager Console](https://learn.microsoft.com/en-us/nuget/consume-packages/install-use-packages-powershell) in Visual Studio:

```Powershell
NuGet\Install-Package Twizzar.Api
```

The package should now be installed in Visual Studio:

<DocImg :src="TwizzarProject" alt="Project with Twizzar.Api installed"/>

::: info Note
After installing the NuGet packages, we recommend closing all Visual Studio instances and restart them to ensure the Twizzar Analyzer which generates source code is working correctly.
:::
