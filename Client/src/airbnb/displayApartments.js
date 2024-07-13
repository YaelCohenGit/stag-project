import axios from "axios";
import React, {useEffect, useState} from "react";


const AptDetailsComponent = ()=>{
    const[data, setData]= useState(null);
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
        <div>
          <h1>Apt Details</h1>
          <pre>{JSON.stringify(data, null, 2)}</pre>
        </div>
      );
    };

    
export default AptDetailsComponent;
