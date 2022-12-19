import React, { useState } from "react";
import "./App.css";
import { getRandomNumberFromAzureFunction } from "./services/service";

function App() {
  const [randNumber, setRandNumber] = useState([]);

  const handleData = async () => {
    let data = await getRandomNumberFromAzureFunction();
    setRandNumber(data);
  };
  return (
    <div className="app">
      <button onClick={handleData}>Get rand num</button>

      <input type="text" value={randNumber}></input>
    </div>
  );
}

export default App;
