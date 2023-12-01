import React, {useEffect, useState} from 'react';
import {getHeroesAsync} from './Services/heroeService';



export default function App() {
const [data, setData] = useState([]);

  useEffect(() => {
    (async () => {
      const heroes = await getHeroesAsync();
      setData(heroes)
    })();
  }, [setData])

  return (
    <div className="App">
      <header className="App-header">
       <div>
        {data.map(item => (
          <p key={item.id}>{item.title}</p>
        ))}
       </div>
        <p>
          Hola mundo
        </p>
       
      </header>
    </div>
  );
}


