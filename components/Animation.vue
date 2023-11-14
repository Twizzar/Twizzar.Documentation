<script setup lang="ts">
import type {
    Project,
    PlayerSettings,
    StageSettings,
    Slide,
} from "@motion-canvas/core";
import { Stage, Player } from "@motion-canvas/core";
import { onMounted, ref } from "vue";

const props = defineProps<{project: string}>();

const stage = new Stage();
const player = ref<Player>();
const canvasContainer = ref<HTMLDivElement>();
const defaultSettings = ref<PlayerSettings & StageSettings>();
const slides = ref<Slide[] | undefined>(undefined);
const currentSlide = ref<Slide | null>();

onMounted(() => {
    loadProject(props.project).then((project) => {
        if (!project) return;
        player.value = initPlayer(project);
        updateSettings();
        play();
    });
});

const initProject = async (project: Project) => {
    const canvas = stage.finalBuffer;
    canvas.classList.add("canvas");
    canvasContainer.value?.appendChild(canvas);
    const ro = new ResizeObserver(updateSettings);
    ro.observe(canvasContainer.value!);
    defaultSettings.value = project.meta.getFullRenderingSettings();
};

const loadProject = async (source: string) => {
    const canvas = stage.finalBuffer;
    canvas.classList.add("canvas");
    canvasContainer.value?.appendChild(canvas);
    const ro = new ResizeObserver(updateSettings);
    ro.observe(canvasContainer.value!);

    let project: Project;
    try {
        const promise = import(
            /* webpackIgnore: true */ /* @vite-ignore */ source
        );
        const delay = new Promise((resolve) => setTimeout(resolve, 200));
        await Promise.any([delay, promise]);
        project = (await promise).default;
    } catch (e) {
        console.error(e);
        return;
    }

    defaultSettings.value = project.meta.getFullRenderingSettings();
    return project;
};

const onRender = async () => {
    if (!player.value) return;
    if (!stage) return;
    if (slides.value == undefined) {
        slides.value = player.value.playback.slides;
        currentSlide.value =
            player.value.playback.currentScene.slides.getCurrent();
    }

    stage.render(
        player.value?.playback.currentScene,
        player.value?.playback.previousScene
    );
};

const updateSettings = () => {
    if (!defaultSettings.value) return;

    const settings = {
        ...defaultSettings.value,
    };
    stage.configure(settings);
    player.value?.configure(settings);
};

const initPlayer = (project: Project) => {
    const player = new Player(project);
    player.onRender.subscribe(onRender);
    player.togglePlayback(false);
    player.toggleLoop(false);

    if (import.meta.env.DEV) {
        player.logger.onLogged.subscribe(console.log);
    }

    return player;
};

const play = () => {
    player.value?.togglePlayback(true);
};

const playSlide = (slide: Slide) => {
    currentSlide.value = slide;
    player.value?.requestSeek(slide.time * player.value.playback.fps);
    setTimeout(play, 100);
};
</script>

<template>
    <div class="canvas-container" ref="canvasContainer"></div>
    <div class="player-control">
        <button
            v-for="slide in slides"
            :class="{ active: slide.name == currentSlide?.name }"
            @click="() => playSlide(slide as Slide)"
        >
            {{ slide.name }}
        </button>
    </div>
</template>

<style lang="scss">
.canvas-container {
    width: 100%;
    position: relative;
    display: block;
    aspect-ratio: 16 / 9;
}

.player-control {
    display: flex;
    justify-content: space-evenly;

    button {
        border: 1px solid gray;
        border-radius: 5px;
        background-color: var(--vp-c-brand-1);
        color: white;
        padding: 10px;
        margin-top: 10px;
        text-decoration: none;
    }

    button.active {
        border: 2px solid white;
    }
}

.canvas {
    width: 100%;
    display: block;
    opacity: 1;
    transition: opacity 0.1s;
}
</style>
