import './App.css';

function FormatNapisu(text){
  return text.toLowerCase().charAt(0).toUpperCase()+text.slice(1).toLowerCase();
}

function UtworyDruk(dzielo){
  return dzielo.utwory[0].tytul
}

function GatunekLiter(gatunek){
  return gatunek.utwory[0].rodzaj
}

const pisarze = [
{"id":0, "imie":"adam","nazwisko":"mickiewicz","kraj":"polska",
  "utwory":[
    {"id":0, "tytul":"Pan Tadeusz","rodzaj":"epika"},
    {"id":1, "tytul":"Ballady i romanse","rodzaj":"liryka"},
    {"id":2, "tytul":"Dziady","rodzaj":"dramat"}
  ]
},
{"id":1, "imie":"jan", "nazwisko":"kochanowski","kraj":"polska",
 "utwory":[
  {"id":0, "tytul":"Odprawa poslow greckich","rodzaj":"dramat"},
  {"id":1, "tytul":"Fraszki","rodzaj":"liryka"}
 ]
},
{"id":2, "imie":"wiliam","nazwisko":"shakespeare","kraj":"anglia",
 "utwory":[
  {"id":0, "tytul":"Hamlet","rodzaj":"dramat"},
  {"id":1, "tytul":"Romeo i Julia","rodzaj":"dramat"},
  {"id":2, "tytul":"Juliusz Cezar","rodzaj":"dramat"}
 ]
},
{"id":3, "imie":"isaak","nazwisko":"asimow","kraj":"stany zjednoczone",
 "utwory":[
  {"id":0, "tytul":"Ja, robot", "rodzaj":"epika"},
  {"id":1, "tytul":"Koniec wiecznosci","rodzaj":"epika"}
 ]

}
];

function App() {
  return (
    <div className="App">
      <table cellpadding="0" cellspacing="0">
        <thead>
          <tr>
            <th>AUTOR</th>
            <th>KRAJ</th>
            <th>UTWORY</th>
          </tr>
        </thead>
        <tbody>
          {pisarze.map((pisarz, indexP) => 
            <tr key = {pisarz.id}>
              <td><b><i>{FormatNapisu(pisarze[indexP].imie)} {FormatNapisu(pisarze[indexP].nazwisko)}</i></b></td>
              <td>{pisarz.kraj.toUpperCase()}</td>
              <td>
                <ol>
                  {pisarz.utwory.map((utwor, indexU) => 
                  <li key={pisarz.id}><b>{pisarze[indexP].utwory[indexU].tytul}</b> to  {pisarze[indexP].utwory[indexU].rodzaj}</li>)}
                </ol>
                FUNKCJA UtworyDruk: {UtworyDruk(pisarz)} FUNKCJA GatunekLiter: {GatunekLiter(pisarz)}
              </td>
            </tr>
          )}
        </tbody>
      </table>
    </div>
  );
}

export default App;
