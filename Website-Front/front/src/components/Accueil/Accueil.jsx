import React, { useContext } from "react";
import { UserContext } from "../../User.Context";
import "./accueil.css";
import Slider from "./Slider/Slider";

const Accueil = () => {

  const {user, setUser} = useContext(UserContext)

  const logout = async () => {

    await fetch('http://localhost:8000/api/v1/user/logout', {
      method: 'POST',
      headers: {'Content-Type' : 'application/json'},
      credentials: 'include'
    })

    setUser(null)
  }

  let linkUser

  if(user) {
    linkUser = (
      <button className='logout__button' onClick={logout}>Se déconnecter</button>
    )
  }


  return (
    <div className="accueil">
      <div className="div__button_logout">
        {linkUser}
      </div>
      <section className="section__slider"></section>
      <section className="accueil__description">
        <div className="section__content">
          <p className="description">
            MEMORIES est une application créer pour les personnes ayant des
            troubles de la mémoires afin de les aider à se rappeler des
            dernières tâches qu'ils ont pu réaliser grâce aux stockage de leurs
            données. Une voix automatique est inclus afin de leur parler et leur
            rappeler les dernières actions qu'ils ont réalisés. Des quizz sont
            également proposés pour faire travailler leur mémoires
          </p>
          <div className="step__content">
            <h1 className="description__step">Étapes :</h1>

            <ul className="step__list">
              <div className="bubble__link">
                <li className="step__items-one">1. Créer votre comptes</li>
              </div>
              <div className="bubble__link">
                <li className="step__items-two">
                  2. Entrer les tâches que vous devez vous remémorer
                </li>
              </div>
              <div className="bubble__link">
                <li className="step__items-three">
                  3. L'application se charge de vous
                </li>
              </div>
            </ul>
          </div>
        </div>
      </section>
      <section className="play">
        <div className="begin__content">
          <h1 className="begin__title">Commencez l'aventure</h1>
          <p className="begin__description">
            Si vous cliquez sur le bouton ci-dessous, vous serez rediriger vers
            une page qui vous permettra d'effectuer votre liste des évènments à
            vous rememorer          </p>
          <button className="begin__button">
            <a
              href="http://piqueta.pythonanywhere.com/"
              target="blank"
              className="begin__link"
            >
              Commencez
            </a>
          </button>
        </div>
        <div className="play__content">
          <h1 className="play__title">
            Jouer à notre Jeux
          </h1>
          <p className="play__description">
            Jouer à notre jeux pourra faire travailler votre mémoire .
          </p>
          <button className="play__button">
            <a
              href="http://piqueta.pythonanywhere.com/"
              target="blank"
              className="play__link"
            >
              Jouer
            </a>
          </button>
        </div>
      </section>
      
    </div>
  );
};

export default Accueil;
