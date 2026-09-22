import './App.css';

const bryly = [
  {
    id: 0,
    nazwa: "sześcian",
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
    nazwa: "prostopadłościan",
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
    nazwa: "kula",
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
  if(bryly.nazwa == "sześcian"){
    return 6 * Math.pow(w.a, 2);
  }
  else if(bryly.nazwa == "prostopadłościan"){
    return 2 * w.c * w.b + 2 * w.c * w.h + 2 * w.h * w.b;
  }
  else if(bryly.nazwa == "kula"){
    return 4 * Math.PI * Math.pow(w.r, 2);
  }
}

function OblicObjetosc(bryly) {
  const w = bryly.wymiary;
  if (bryly.nazwa === "sześcian") {
    return Math.pow(w.a, 3);
  } 
  else if (bryly.nazwa === "prostopadłościan") {
    return w.c * w.b *w.h;
  } 
  else if (bryly.nazwa === "kula") {
    return (4 / 3) * Math.PI * Math.pow(w.r, 3);
  }
}

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <table>
          <thead>
            <tr>
              <th>BRYŁA</th>
              <th>ILUSTRACJA</th>
              <th>WZORY</th>
              <th>PRZYKŁAD</th>
            </tr>
          </thead>

          <tbody>
            {bryly.map((figura) => (
              <tr key={figura.id}>
                <td>{figura.nazwa}</td>

                <td>
                  <img src={figura.obraz} alt={figura.nazwa} />
                </td>

                <td>
                  <div>{figura.wzoryPole}</div>
                  <div>{figura.wzoryObjetosc}</div>
                </td>

                <td>
                      {figura.wymiary.a && <div>a = {figura.wymiary.a}</div>}
                      {figura.wymiary.c && <div>c = {figura.wymiary.c}</div>}
                      {figura.wymiary.b && <div>b = {figura.wymiary.b}</div>}
                      {figura.wymiary.h && <div>h = {figura.wymiary.h}</div>}
                      {figura.wymiary.r && <div>r = {figura.wymiary.r}</div>}               
                <p>POLE:{ObliczPole(figura)}</p>
                <p>OBJETOSC:{OblicObjetosc(figura)}</p>
                </td>
              </tr>
            ))}
          </tbody>
        </table>
      </header>
    </div>
  );
}

export default App;
