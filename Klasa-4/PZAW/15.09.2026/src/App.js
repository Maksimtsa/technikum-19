import photo from './Fibonacci.jpg';
import './App.css';

function Ciag(){
  let n = prompt("Podaj długość ciągu");
  let Iloczyn = 1;
  let ciag = "1";
  let a = 1; 
  let b = 1;
  let c = 1;

  for(let i = 1; i < n; i++){
    ciag += " * " + c;
    Iloczyn *= c;

    c = a + b;   
    a = b;
    b = c;
  }

  return (
    <div>
      <div className='mainFib'>
        <h3>Ciąg Fibbonacciego</h3>
        <p>Iloczyn pierwszych {n} elementów ciągu Fibbonacciego:</p>
        <p>{ciag} = {Iloczyn}</p>
      </div>
    </div>
  );

}

function App() {
  return (
    <div className="App">
      <header>
        <h1>Obliczanie iloczynu n elementów ciagu Fibbonacciego</h1>
        <img src={photo} alt="ciag"></img>
      </header>
      <Ciag />
    </div>
  );
}

export default App;
