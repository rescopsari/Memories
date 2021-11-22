import React from 'react'
import "./contact.css"


const Contact = () => {
    return(
        <div className="main-contact">
             <h1>CONTACT</h1>
        <section class="section-contact">
            <form action="" method="post">  
                <p>
                    <label for="name">VOTRE NOM</label>
                    <input id="name" name="name" type="text" placeholder="Ecrivez votre nom ici..." required/>
                </p>
                <p>
                    <label for="email">VOTRE EMAIL</label>
                    <input id="email" name="email" type="text" placeholder="Ecrivez votre email ici..." required/>
                </p>
                <p>
                    <label for="object">OBJET DE VOTRE MESSAGE</label>
                    <input id="object" name="object" type="text" placeholder="Ecrivez votre nom ici..." required/>
                </p>
                <p>
                    <label for="message">VOTRE MESSAGE</label>
                    <textarea id="message" name="message" type="text" placeholder="Ecrivez votre nom ici..." rows="5" required></textarea>
                </p>
                <p>
                    <label for="phone">VOTRE NUMERO DE TELEPHONE</label>
                    <input id="phone" name="phone" type="text" placeholder="Ecrivez votre téléphone ici..." required/>
                </p>
                <p class="text-center">
                    <input type="submit" value="Envoyer"/>
                </p>
            </form>
        </section>

        </div>
    )
}



export default Contact