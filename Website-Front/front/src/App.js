import "./App.css";
import { BrowserRouter as Router, Switch, Route } from "react-router-dom";
import React, { useMemo, useState, useEffect } from 'react'
import { UserContext } from './User.Context'
import Accueil from "./components/Accueil/Accueil";
import Connexion from "./components/Connexion/Connexion";
import Navbar from "./components/Navbar/Navbar";
import Slider from "./components/Accueil/Slider/Slider";
import Register from './components/register/Register'

function App() {

  const [user, setUser] = useState(null)
  const UserValue = useMemo(()=>({user, setUser}), [user, setUser]);

  useEffect(() => {
    (
      async () => {
        const response = await fetch('http://localhost:8000/api/v1/user', {
          headers: {'Content-Type' : "application/json"},
          credentials: 'include'
        })

        const content = await response.json()

        if(content._id) {
          setUser(content)
        }
      }
    )()
  },[])


  return (
    <div className="App">
      <Router>
      <Navbar/>
      <UserContext.Provider value={UserValue}>
        <Switch>
          <Route path="/" exact component={Accueil} />
          <Route path="/connexion" exact component={Connexion}/>
          <Route path="/slider" exact component={Slider}/>
          <Route path="/register" component={Register}/>
        </Switch>
        </UserContext.Provider>
      </Router>
    </div>
  );
}

export default App;
