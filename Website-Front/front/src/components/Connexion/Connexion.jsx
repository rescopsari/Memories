import React, { useState } from "react";
import { Link } from 'react-router-dom'
import { Redirect } from "react-router-dom";
import "./connexion.css";

const Connexion = () => {

  const [redirect, setRedirect] = useState(false)
  const [email, setEmail] = useState('')
  const [password, setPassword] = useState('')


  const Submit = async (e) => {
    e.preventDefault();
    
    await fetch('http://localhost:8000/api/v1/user/login', {
      method: "POST",
      headers: {"Content-Type" : "application/json"},
      credentials: "include",
      body: JSON.stringify({
        email,
        password
      })
    })

    setRedirect(true)
  };

  if(redirect) {
    return <Redirect to='/'/>
  }

  return (
    <div className="connexion">
      <div className="connexion__title-content">
        <h1 className="connexion__title">Bienvenue sur Memories</h1>
      </div>
      <div className="connexion__form-box">
        <h1 className="connexion__form-title">Connexion</h1>
        <form onSubmit={Submit} className="connexion__form">
          <label htmlFor="email" className="connexion__label">
            Email :
          </label>
          <input
            type="email"
            placeholder="Jicé.védé@gmail.com"
            name="email"
            onChange={e => setEmail(e.target.value)}
            className="connexion__input"
          />
          <label htmlFor="password" className="connexion__label">
            {" "}
            Mot de passe :
          </label>
          <input
            type="password"
            placeholder="Mot de passe"
            name="password"
            onChange={e => setPassword(e.target.value)}
            className="connexion__input"
          />
          <div className="connexion__button-box">
            <input
              type="submit"
              className="connexion__button"
              value="Connexion"
            />
            <Link to='/register'><button className="connexion__button" >Inscription</button></Link>
          </div>
        </form>
      </div>
    </div>
  );
};

export default Connexion;