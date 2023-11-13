<script setup lang="ts">
import { ref } from "vue";

const props = defineProps({
    src: {
        type: String,
        required: true,
    },
    alt: {
        type: String,
        required: false,
        default: "Image",
    },
});

const overlayIsVisible = ref(false);

const toggleOverlayIsVisible = () => {
    overlayIsVisible.value = !overlayIsVisible.value;
};
</script>

<template>
    <div
        class="overlay"
        @click="() => (overlayIsVisible = false)"
        v-if="overlayIsVisible"
    >
        <img :src="props.src" :alt="props.alt" />
        <cite v-if="props.alt != undefined">{{ props.alt }}</cite>
    </div>
    <div class="img-container" @click="toggleOverlayIsVisible">
        <img :src="props.src" :alt="props.alt" />
        <cite v-if="props.alt != undefined">{{ props.alt }}</cite>
    </div>
</template>

<style scoped>
.overlay {
    background-color: #3f3f3fde;
    position: fixed;
    left: 0px;
    top: 0px;
    width: 100vw;
    height: 100vh;
    z-index: 999;
    display: flex;
    align-items: center;
    align-content: center;
    justify-content: center;
    flex-direction: column;
    gap: 1rem;
    cursor: pointer;
}

.overlay img {
    max-width: 90%;
    max-height: 90%;
    min-width: 20%;
}

.img-container {
    display: block;
    gap: 0.5rem;
    margin: auto;
    text-align: center;
    cursor: pointer;
}

.img-container img {
    max-width: 100%;
    max-height: 100%;
    margin: auto;
}

.img-container cite {
    display: block;
    margin-top: 1rem;
    text-align: center;
}
</style>
