import React, {useEffect, useState} from 'react';
import {getHeroesAsync} from './Services/heroeService';
import Button from 'react-bootstrap/Button';



export default function App() {
const [data, setData] = useState(false);

  useEffect(() => {
    (async () => {
      const heroes = await getHeroesAsync();
      setData(heroes)
    })();
  }, [setData])

  return (
    <div className="App">
      <header className="App-header">
        <p>
          GetCreator
        </p>
      </header>
    </div>
  );
}


