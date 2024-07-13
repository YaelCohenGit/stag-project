import logo from './logo.svg';
import './App.css';
import AptDetailsComponent from './airbnb/displayApartments';

function App() {
  return (
    <div className="App">
      
      <header className="App-header">
        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          Welcome to airbnb!!
        </a>
        <AptDetailsComponent />
      </header>
      
    </div>
  );
}

export default App;
