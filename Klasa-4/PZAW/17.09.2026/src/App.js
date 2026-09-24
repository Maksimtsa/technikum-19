import './App.css';

const bryly = [
  {
    id: 0,
    nazwa: "SZEŚCIAN",
    obraz: "/obrazy/szescian.png",
    wzoryPole: "P = 6 · a²",
    wzoryObjetosc: "V = a³",
    wymiary: 
      {
        a: 2
      }
    
  },
  {
    id: 1,
    nazwa: "PROSTOPADŁOŚCIAN",
    obraz: "/obrazy/prostopadloscian.png",
    wzoryPole: "P = 2ab + 2ah + 2bh",
    wzoryObjetosc: "V = a · b · h",
    wymiary: 
      {
        c: 3,
        b: 4,
        h: 5
      }
    
  },
  {
    id: 2,
    nazwa: "KULA",
    obraz: "/obrazy/kula.png",
    wzoryPole: "P = 4 · π · r²",
    wzoryObjetosc: "V = 4/3 · π · r³",
    wymiary: 
      {
        r: 4
      }
    
  }
];

function ObliczPole(bryly){
  const w = bryly.wymiary;
  if(bryly.nazwa == "SZEŚCIAN"){
    return 6 * Math.pow(w.a, 2);
  }
  else if(bryly.nazwa == "PROSTOPADŁOŚCIAN"){
    return 2 * w.c * w.b + 2 * w.c * w.h + 2 * w.h * w.b;
  }
  else if(bryly.nazwa == "KULA"){
    return 4 * Math.PI * Math.pow(w.r, 2);
  }
}

function OblicObjetosc(bryly) {
  const w = bryly.wymiary;
  if (bryly.nazwa === "SZEŚCIAN") {
    return Math.pow(w.a, 3);
  } 
  else if (bryly.nazwa === "PROSTOPADŁOŚCIAN") {
    return w.c * w.b *w.h;
  } 
  else if (bryly.nazwa === "KULA") {
    return (4 / 3) * Math.PI * Math.pow(w.r, 3);
  }
}

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <h1>Bryły</h1>
      </header>
      <div className='tableBlock'>
        <table align='center'>
          <thead>
            <tr className='figury'>
              <th><h3>BRYŁA</h3></th>
              <th><h3>ILUSTRACJA</h3></th>
              <th><h3>WZORY</h3></th>
              <th><h3>PRZYKŁAD</h3></th>
            </tr>
          </thead>

          <tbody>
            {bryly.map((figura) => (
              <tr key={figura.id}>
                <td className='poleNazwa'>{figura.nazwa}</td>

                <td>
                  <img src={figura.obraz} alt={figura.nazwa} />
                </td>

                <td className='poleObjet'>
                  <div>Pole: {figura.wzoryPole}</div>
                  <div>Objetosc: {figura.wzoryObjetosc}</div>
                </td>

                <td>
                  <ol>
                      {figura.wymiary.a && <li>a = {figura.wymiary.a}</li>}
                      {figura.wymiary.c && <li>c = {figura.wymiary.c}</li>}
                      {figura.wymiary.b && <li>b = {figura.wymiary.b}</li>}
                      {figura.wymiary.h && <li>h = {figura.wymiary.h}</li>}
                      {figura.wymiary.r && <li>r = {figura.wymiary.r}</li>}   
                  </ol>            
                <p className='Pole'>POLE:{ObliczPole(figura)}</p>
                <p className='Objetosc'>OBJETOSC:{OblicObjetosc(figura)}</p>
                </td>
              </tr>
            ))}
          </tbody>
        </table>
      </div>
    </div>
  );
}

export default App;
