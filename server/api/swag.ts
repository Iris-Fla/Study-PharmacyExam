export default defineEventHandler(async () => {
    const weather = await fetch("https://localhost:7086/WeatherForecast")
    return weather
  });