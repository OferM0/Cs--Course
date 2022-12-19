import axios from "axios";

export const getRandomNumberFromAzureFunction = async () => {
  let endpoint = "http://localhost:7167/api/Function1?min=1&max=10";
  let reaponse = await axios.get(endpoint);
  if (reaponse.status === 200) {
    console.log(reaponse.data);
    return reaponse.data;
  }
};
