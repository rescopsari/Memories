const express = require('express')
const router = express()
const bodyParser = require('body-parser')

const Message = require('../models/message_model')
router.use(bodyParser.json())

router.get('/', async (req,res) => {
    try {
        const messages = await Message.find()
        res.json(messages)
    } catch (error) {
        console.warn(error)
        res.send({message: error.message})
    }
})

router.get('/:id', async (req,res) => {
    try {
        const message = await Message.findById({_id: req.params.id})
        res.json(message)
    } catch (error) {
        console.warn(error)
        res.send({message: error.message})
    }
})

router.post('/', async (req,res) => {
    try {
        const message = new Message({
            title: req.body.title,
            content: req.body.content,
            replyied: req.body.replyied
        })

        const savedMessage = await message.save()

        res.json(savedMessage)
    } catch (error) {
        console.warn(error)
        res.send({message: error.message})
    }
})

module.exports = router