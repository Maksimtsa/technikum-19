import './App.css';

function FormatNapisu(text){
  return text.toLowerCase().charAt(0).toUpperCase()+text.slice(1).toLowerCase();
}

const pisarze = [
{"imie":"adam","nazwisko":"mickiewicz","kraj":"polska",
  "utwory":[
    {"tytul":"Pan Tadeusz","rodzaj":"epika"},
    {"tytul":"Ballady i romanse","rodzaj":"liryka"},
    {"tytul":"Dziady","rodzaj":"dramat"}
  ]
},
{"imie":"jan", "nazwisko":"kochanowski","kraj":"polska",
 "utwory":[
  {"tytul":"Odprawa poslow greckich","rodzaj":"dramat"},
  {"tytul":"Fraszki","rodzaj":"liryka"}
 ]
},
{"imie":"wiliam","nazwisko":"shakespeare","kraj":"anglia",
 "utwory":[
  {"tytul":"Hamlet","rodzaj":"dramat"},
  {"tytul":"Romeo i Julia","rodzaj":"dramat"},
  {"tytul":"Juliusz Cezar","rodzaj":"dramat"}
 ]
},
{"imie":"isaak","nazwisko":"asimow","kraj":"stany zjednoczone",
 "utwory":[
  {"tytul":"Ja, robot", "rodzaj":"epika"},
  {"tytul":"Koniec wiecznosci","rodzaj":"epika"}
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
          //tu uzupełnić
        </tbody>
      </table>
    </div>
  );
}

export default App;
