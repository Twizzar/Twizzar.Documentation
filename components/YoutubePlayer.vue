<script setup lang="ts">
import { defineProps } from "vue";

const props = defineProps({
    url: {
        type: String,
        required: true,
    },
    height: {
        type: String,
        default: "315",
        required: false,
    },
    width: {
        type: String,
        default: "560",
        required: false,
    },
});
</script>

<template>
    <div class="yt-container">
        <iframe
            :width="props.width"
            :height="props.height"
            :src="props.url"
            frameborder="0"
            title="YouTube video player"
            allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share"
            allowfullscreen
        ></iframe>
    </div>
</template>

<style scoped>
.yt-container {
    width: 100%;
    display: flex;
    justify-content: center;
}
</style>
