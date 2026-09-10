import photo from './a.png';
import './App.css';

function Hello(){
  let name = prompt("Jak masz na imie?");
  let surname = prompt("Podaj nazwisko");

  return <p className='App-p'>{name} {surname} witaj w funkcji Witaj()</p>;
}

function SumaFu(){
  let start = prompt("Podaj 1 element ciągu");
  start = parseInt(start);
  let end = prompt("Podaj ostatni element ciągu");
  end = parseInt(end);
  let step = prompt("Podaj o ile będzie się zwiększać się");
  step = parseInt(step);
  
  let element = "";
  let suma = 0;
  for(let i = start; i <= end; i += step){
    element = element+i+"+";
    suma += i;
  }

  element = element + 0 + "=" + suma;
  return <p className='App-p'>Suma ciągu: {element}</p>;
}

function App() {
  return (
    <div className='App-strona'>
      <img src={photo} className='App-szkola' alt="photo"></img>
      <h2>Hello world</h2>
      <Hello/>
      <SumaFu/>
    </div>
  );
}

export default App;
