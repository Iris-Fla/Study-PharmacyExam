export default defineEventHandler(async () => {
  try {
    const response = await fetch('http://localhost:5143/WeatherForecast',
      { method: 'GET',
        headers: {
          'Content-Type': 'application/json',
         }
     }
    );
    if (!response.ok) {
      throw new Error(`HTTP error! status: ${response.status}`);
    }
    const datajs = await response.json();
    return datajs;
  } catch (error) {
    console.error('Error fetching :', error);
    return { error: 'Failed to fetch data' };
  }
});