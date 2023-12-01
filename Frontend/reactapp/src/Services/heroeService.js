import axios from "axios";

const baseEndpoint = "/WeatherForecast";

export async function getHeroesAsync() {
    try {
      const result = await axios.get(`${baseEndpoint}`);
      console.log(result.data)
      return result.data;
     
    } catch (error) {
      return "Unknown error";
    }
  }