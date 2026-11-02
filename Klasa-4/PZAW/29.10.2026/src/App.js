import './App.css';
import Header from './naglowek/Header';
import Main from './oferta/Main';
import Footer from './stopka/Footer';

function App() {
  return (
    <div className="App">
      <header>
        <Header nazwaFirmy="Moje Obowie"/>
      </header>
      <Main />
      <Footer />
    </div>
  );
}

export default App;
