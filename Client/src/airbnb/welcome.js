import React from "react";
import { Link } from 'react-router-dom';
import '../App.css'; // Assuming your App.css is in src folder

const Welcome = () => {
  return (
    <div className="floating-buttons">
      <Link to="/add-apartment">
        <button className="floating-button">Add apartment</button>
      </Link>
      <Link to="/all-apartments">
        <button className="floating-button">All apartments</button>
      </Link>
      <button className="floating-button">3</button>
    </div>
  );
};

export default Welcome;