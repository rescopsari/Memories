import React from "react";
import "./about.css";
import image1 from "../../images/image_1.jpg";
import image2 from "../../images/image_2.jpg";
import imageMaps from "../../images/maps.jpg"

const About = () => {
  return (
    <div className="main-about">
      <h1>A PROPOS</h1>
      <section class="section-about">
        <div>
          <h2>QUI SOMMES-NOUS?</h2>
          <p>
            Notre application a été créée par notre équipe afin d'aider les
            personnes ayant des troubles de la mémoire. Grâce à des exercices,
            nous proposons des quizz et des histoires à lire sur leur propre
            journée afin qu'ils se souviennent des différentes tâches à
            accomplir durant leurs journées et des tâches qu'ils ont accomplies.{" "}
          </p>
        </div>
        <div class="img-about">
          <img
            class="resp-about"
            src={image2}
            alt="cerveau avec des engrenages"
            title="image de cerveau"
          />
        </div>
      </section>
      <hr />
      <section class="section-about">
        <h2 class="display-none">NOTRE EQUIPE</h2>
        <div class="img-about">
          <img
            class="resp-about"
            src={image1}
            alt="étudiants travaillant en équipe"
            title="image de cerveau"
          />
        </div>
        <div>
          <h2 class="display-block">NOTRE EQUIPE</h2>
          <p>
            Notre équipe se compose de vrais talents dans leur domaine, c'est
            une équipe expérimentée. Plus précisement, nos talents ont déjà
            travaillé avec de grandes entreprises et par conséquent, de grands
            budgets, l'expertise est au rendez-vous.
          </p>
        </div>
      </section>
      <hr />
      <div class="img-about-last">
        <img
          class="resp-about"
          src={imageMaps}
          alt="carte de l'emplacement de l'entreprise"
          title="Image de map"
        />
      </div>
    </div>
  );
};

export default About;
