import logo from './a.png';
import Header from './header/Header';
import LeftBlock from './Blocks/LeftBlock';
import './App.css';

function App() {
  return (
    <div className="App">
      <Header Nazwa="Salon samochodowy"/>
      <main>
        <LeftBlock/>
      </main>
    </div>
  );
}

export default App;
