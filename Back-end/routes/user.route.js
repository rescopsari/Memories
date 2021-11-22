const router = require('express').Router()
const bcrypt = require('bcryptjs')
const jwt = require('jsonwebtoken')

const User = require('../models/user.models')

// ? Register to the DB
router.post('/register', async (req,res) => {
    try {
        const sal = await bcrypt.genSaltSync(10);
        const hashedPassword = await bcrypt.hash(req.body.password, sal);

        const user = new User({
            email: req.body.email,
            password: hashedPassword,
            phone_number: req.body.phone_number,
            last_name: req.body.last_name,
            first_name: req.body.first_name

        })

        const result = await user.save();

        const {password, ...data} = await result.toJSON();

        res.send(data)
    } catch (error) {
        console.warn(error)
        res.send({message: error.message})
    }
})

router.post('/login', async (req,res) => {
    const user = await User.findOne({email: req.body.email})

    if(!user) {
        return res.status(404).send({
            message: "Aucun utilisateur trouvé"
        });
    }

    if(!await bcrypt.compare(req.body.password, user.password)) {
        return res.status(404).send({
            message: "Mot de passe non valide"
        });
    }

    const token = jwt.sign({_id: user._id}, 'secret');

    res.cookie('user', token, {
        httpOnly: true,
        maxAge: 24 * 60 * 60 * 1000
    });

    res.send({
        message: "Vous êtes bien connecté"
    })
})

router.get('/', async (req,res) => {
    try {
        const cookie = req.cookies['user'];

        const claims = await jwt.verify(cookie, 'secret');

        if(!claims) {
            return res.status(404).send({
                message: "Pas d'authentification"
            });
        }

        const user = await User.findOne({_id: claims.id});

        const {password, ...data} = await user.toJSON()

        res.send(data);
    } catch (error) {
        return res.status(404).send({
            message: "Pas d'authentification"
        })
    }
})

router.post('/logout', async (req,res) => {
    res.cookie('user', '', {maxAge:0});

    res.send({
        message: "Vous êtes bien déconnecté"
    })
})

module.exports = router