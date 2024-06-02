<script setup>
const { data } = await useFetch("http://localhost:5143/WeatherForecast")
console.log(data);
</script>
<template>
    <h1>Hello</h1>
    <p>{{ data[0].date }}</p>
</template>