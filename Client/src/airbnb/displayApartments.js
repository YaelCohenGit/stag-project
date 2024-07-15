// import axios from "axios";
// import React, {useEffect, useState} from "react";


// const AptDetailsComponent = ()=>{
//     const[data, setData]= useState(null);
//     const [error, setError] = useState(null);

//     useEffect(() => {
//         axios.get('https://localhost:7190/api/AptDetails')
//           .then(response => {
//             setData(response.data);
//           })
//           .catch(error => {
//             setError('There was an error!', error);
//           });
//       }, []); // ריק כדי שהבקשה תבוצע רק פעם אחת כשהמרכיב נטען
    
//       if (error) return <div>{error}</div>;
//       if (!data) return <div>Loading...</div>;
    
//       return (
//         <div>
//           <h1>Apt Details</h1>
//           <pre>{JSON.stringify(data, null, 2)}</pre>
//         </div>
//       );
//     };

    
// export default AptDetailsComponent;


import axios from "axios";
import React, { useEffect, useState } from "react";
import '../App.css'; // Assuming you have some basic styling

const AptDetailsComponent = () => {
  const [data, setData] = useState(null);
  const [error, setError] = useState(null);

  useEffect(() => {
    axios.get('https://localhost:7190/api/AptDetails')
      .then(response => {
        setData(response.data);
      })
      .catch(error => {
        setError('There was an error!', error);
      });
  }, []); // ריק כדי שהבקשה תבוצע רק פעם אחת כשהמרכיב נטען

  if (error) return <div>{error}</div>;
  if (!data) return <div>Loading...</div>;

  return (
    <div className="app">
      <h1>Apt Details</h1>
      <div className="cards-container">
        {data.map((apartment, index) => (
          <div className="card" key={index}>
            <p><strong>Country:</strong> {apartment.country}</p>
            <p><strong>City:</strong> {apartment.city}</p>
            <p><strong>Street:</strong> {apartment.street}</p>
            <p><strong>Apartment Style:</strong> {apartment.aptStyle}</p>
            <p><strong>Beds:</strong> {apartment.beds}</p>
            <p><strong>Price per Night:</strong> {apartment.pricePerNight}</p>
          </div>
        ))}
      </div>
      <div className="floating-buttons">
        <button className="floating-button">Add apartment</button>
        <button className="floating-button">Add apartment</button>
        <button className="floating-button">3</button>
      </div>
    </div>
  );
};

export default AptDetailsComponent;