# Twizzar Documentation

- [Twizzar Documentation](#twizzar-documentation)
  - [Requirements](#requirements)
  - [Get started](#get-started)
  - [VitePress](#vitepress)
  - [Mermaid diagrams](#mermaid-diagrams)
  - [Api documentation](#api-documentation)
  - [How do I change the left side bar?](#how-do-i-change-the-left-side-bar)
  - [Where do I put the images?](#where-do-i-put-the-images)
  - [How do I add a video?](#how-do-i-add-a-video)

## Requirements
- [Node.js](https://nodejs.org/en/) >= 19.0.0
- [Yarn](https://yarnpkg.com/) >= 3.0.0

## Get started
To get startet run:

```bash
yarn
yarn docs:dev
```

## VitePress
The documentation is build with VitePress. For more information see:
[https://vitepress.dev/guide/getting-started](https://vitepress.dev/guide/getting-started)

## Mermaid diagrams

To generate mermaid diagrams install mermaid cli
```bash
npm install -g @mermaid-js/mermaid-cli
```

Then generate the diagrams with
```bash
yarn mermaid
```

The diagrams need to be in the `src/mermaid` directory and need to have the `.mmd` extension.

## Api documentation
To generate the markdown files for the api documentation:
1. install https://ejball.com/XmlDocMarkdown
2. nagiavate to the project bin folder where the dll is located
3. run `xmldocmd .\Twizzar.Api.dll docs --visibility public`
4. put the generated markdown files in the `src/api` folder

## How do I change the left side bar?
Open the file `.vitepress/config.Mts` and change the `themeConfig.sidebar` property.

## Where do I put the images?
Put the images in the `src/images` directory. Then you can use them in the markdown files with the following syntax:
```md
<script setup lang="ts">
import DocImg from '../components/DocImg.vue'

// image source
import MyImgSrc from './images/MyImgSrc.png';
</script>

<DocImg :src="MyImgSrc" alt="Some text describing your image."/>
```
The `DocImg` is a component which is used to display the images. It is located in the `components/DocImg.vue` file. Use the ts import and not add the src directly to the `DocImg` component. This is because the images will be only bundled when they are imported in the ts file. A direct import works when using the `docs:dev` command, but not when using the `docs:build` command.

Images used for the theme should be places under `src/public/images` all files in the public folder will be copied to the root of the build folder.

## How do I add a video?
**Youtube**
```md
<script setup lang="ts">
import YoutubeVideo from '../components/YoutubeVideo.vue'
</script>

<YoutubeVideo url="https://www.youtube.com/embed/<id>"/>
```
**Local**
```md
<script setup lang="ts">
import VideoPlayer from '../components/VideoPlayer.vue'
</script>


