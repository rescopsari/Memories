import React, { useState } from 'react'
import { Redirect } from 'react-router-dom'
import './register.css'


const Register = () => {

    const [redirect, setRedirect] = useState(false)

    const [email, setEmail] = useState('')
    const [password, setPassword] = useState('')
    const [phone_number, setPhone_number] = useState('')
    const [first_name, setFirst_name] = useState('')
    const [last_name, setLast_name] = useState('')


    const Submit = async (e) => {
        e.preventDefault();

        console.log({email, password, phone_number, first_name, last_name})
        
        await fetch('http://localhost:8000/api/v1/user/register', {
            method: 'POST',
            headers: {'Content-Type' : 'application/json'},
            body: JSON.stringify({
                email,
                password,
                phone_number,
                first_name,
                last_name
            })
        })

        setRedirect(true)
    }

    if(redirect) {
        return <Redirect to='/connexion'/>
    }

    return (
        <main className='register'>
            <div className="register__title-content">
                <h1 className="register__title">Bienvenue sur Memories</h1>
            </div>
            <div className="register__content-form">
                <h1 className="register__title">Enregistrement</h1>
                <form onSubmit={Submit} className='register__form'>

                    <label htmlFor="email" className="register__label">Email:</label>
                    <input type="email" name="email" className="register__input" value={email} onChange={e => setEmail(e.target.value)}/>

                    <label htmlFor="password" className="register__label">Password:</label>
                    <input type="password" name="password" className="register__input" value={password} onChange={e => setPassword(e.target.value)}/>

                    <label htmlFor="phone_number" className="register__label">Numéro de téléphone:</label>
                    <input type="text" name="phone_number" className="register__input" value={phone_number} onChange={e => setPhone_number(e.target.value)}/>

                    <label htmlFor="first_name" className="register__label">Prénom:</label>
                    <input type="text" name="first_name" className="register__input" value={first_name} onChange={e => setFirst_name(e.target.value)} />

                    <label htmlFor="last_name" className="register__label">Nom de famille:</label>
                    <input type="text" name="last_name" className="register__input" value={last_name} onChange={e => setLast_name(e.target.value)}/>

                    <div className="register__button-box">
                    <button type='submit' className="register__button">Créer</button>
                    </div>
                </form>
            </div>
        </main>
    )
}

export default Register
