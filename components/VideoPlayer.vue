<script setup lang="ts">
import { computed } from "vue";

const props = defineProps({
    src: {
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

const getExtension = (path: string) => {
    const parts = path.split(".");
    return parts[parts.length - 1];
};

const sources = computed(() =>
    props.src.split(",")
        .map((src: string) => ({
            src: src,
            type: `video/${getExtension(src)}`
        }))
);
</script>

<template>
    <div class="video-container">
        <video :width="props.width" :height="props.height" controls>
            <source v-for="source in sources" :src="source.src" :type="source.type" />
            Your browser does not support the video tag.
        </video>
    </div>
</template>

<style scoped>
.video-container {
    width: 100%;
    display: flex;
    justify-content: center;
}
</style>
