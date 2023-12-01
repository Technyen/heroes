import axios from "axios";

const baseEndpoint = "api/Marvel/getCreators";

export async function getHeroesAsync() {
    try {
      const result = await axios.get(`${baseEndpoint}`);
      console.log(result.data)
      return result.data;
     
    } catch (error) {
      return "Unknown error";
    }
  }