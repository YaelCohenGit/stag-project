import React from 'react';
import { BrowserRouter as Router, Route, Routes, Link } from 'react-router-dom';
import './App.css';
import AptDetailsComponent from './airbnb/displayApartments';
import Welcome from './airbnb/welcome';
import AddApartment from './airbnb/addApartment';

function App() {
  return (
    <Router>
      <div className="App">
        <header className="App-header">
          <h2>Welcome to airbnb!!</h2>
          <Routes>
            <Route path="/add-apartment" element={<AddApartment />} />
            <Route path="/all-apartments" element={<AptDetailsComponent />} />
            <Route path="/" element={<Welcome />} />
          </Routes>
        </header>
      </div>
    </Router>
  );
}

export default App;