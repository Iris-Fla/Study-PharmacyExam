export default defineEventHandler(async () => {
    const weather = await fetch("https://dummyjson.com/todos/1")
    return weather
  });