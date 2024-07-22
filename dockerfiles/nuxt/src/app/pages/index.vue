<script setup>
const { data } = await useFetch("/api/test", {
    method: "GET",
});
console.log(data);
</script>
<template>
    <h1>Hellaaaaaaaaaaa</h1>
    <p>{{ data }}</p>
</template>