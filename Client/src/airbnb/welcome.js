import React, { useState } from "react";
import { Link } from 'react-router-dom';
import '../App.css';
import axios from 'axios';

const Welcome = () => {
  const [showForm, setShowForm] = useState(false);
  const [formData, setFormData] = useState({
    country: '',
    city: '',
    street: '',
    aptStyle: '',
    beds: '',
    pricePerNight: ''
  });

  const handleAddApartmentClick = () => {
    setShowForm(!showForm);
  };

  const handleChange = (e) => {
    const { name, value } = e.target;
    setFormData({ ...formData, [name]: value });
  };

  const handleSubmit = (e) => {
    e.preventDefault();
    axios.post('https://localhost:7190/api/AddApartment', formData)
      .then(response => {
        console.log('Apartment added successfully:', response.data);
        setShowForm(false); // Hide the form after successful submission
      })
      .catch(error => {
        console.error('There was an error adding the apartment:', error);
      });
  };

  return (
    <div>
      <div className="floating-buttons">
        <Link to="/add-apartment">
          <button className="floating-button">Add apartment</button>
        </Link>
        <Link to="/all-apartments">
          <button className="floating-button">All apartments</button>
        </Link>
        <button className="floating-button" onClick={handleAddApartmentClick}>Add apartment</button>
      </div>

      {showForm && (
        <div className="form-container">
          <div className="apartment-form">
            <h2>Add New Apartment</h2>
            <form onSubmit={handleSubmit}>
              <label>
                Country:
                <input type="text" name="country" value={formData.country} onChange={handleChange} />
              </label>
              <label>
                City:
                <input type="text" name="city" value={formData.city} onChange={handleChange} />
              </label>
              <label>
                Street:
                <input type="text" name="street" value={formData.street} onChange={handleChange} />
              </label>
              <label>
                Apartment Style:
                <input type="text" name="aptStyle" value={formData.aptStyle} onChange={handleChange} />
              </label>
              <label>
                Beds:
                <input type="number" name="beds" value={formData.beds} onChange={handleChange} />
              </label>
              <label>
                Price per Night:
                <input type="number" name="pricePerNight" value={formData.pricePerNight} onChange={handleChange} />
              </label>
              <button type="submit">Submit</button>
            </form>
          </div>
        </div>
      )}
    </div>
  );
};

export default Welcome;