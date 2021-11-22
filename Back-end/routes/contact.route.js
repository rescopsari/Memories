const express = require('express')
const router = express()
const bodyParser = require('body-parser')

const Contact = require('../models/contact.model')
router.use(bodyParser.json())

router.get('/', async (req,res) => {
    try {
        const contact = await Contact.find()

        res.json(contact)
    } catch (error) {
        console.warn(error)
        res.send({
            message: error.message
        })
    }
})

router.get('/:id', async (req,res) => {
    try {
        const contact = await Contact.findOne({_id: req.params.id})

        res.json(contact)
    } catch (error) {
        console.warn(error)
        res.send({
            message: error.message
        })
    }
})

router.post('/', async (req,res) => {
    try {
        const contact = new Contact({
            firstname: req.body.firstname,
            lastname: req.body.lastname,
            email: req.body.email,
            phone: req.body.phone
        })

        const savedContact = await contact.save()

        res.json(savedContact)
    } catch (error) {
        console.warn(error)
        res.send({
            message: error.message
        })
    }
})

router.put('/:id', async (req,res) => {
    try {
        const updateContact = await Contact.findOne({_id: req.params.id});
        const contactToUpdate = await Contact.updateOne(
            {_id: req.params.id},
            {
                $set: {
                    firstname: req.body.firstname ?? updateContact.firstname,
                    lastname: req.body.lastname ?? updateContact.lastname,
                    email: req.body.email ?? updateContact.email,
                    phone: req.body.phone ?? updateContact.phone
                }
            }
        )

        res.send(contactToUpdate)
    } catch (error) {
        console.warn(error)
        res.send({
            message: error.message
        })
    }
})

router.delete('/:id', async (req,res) => {
    try {
        const deletedContact = await Contact.remove({_id: req.params.id})

        res.json(deletedContact)
    } catch (error) {
        console.warn(error)
        res.send({
            message: error.message
        })
    }
})

module.exports = router