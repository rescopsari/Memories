const express = require("express")
const router = express()
const bodyParser = require('body-parser')

const Status = require('../models/status.model')
router.use(bodyParser.json())

router.get('/', async (req,res) => {
    try {
        const statu = await Status.find()

        res.json(statu)
    } catch (error) {
        console.warn(error)
        res.send(
            {message: error.message}
        )
    }
})

router.get('/:id', async (req,res) => {
    try {
        const statu = await Status.findOne({_id: req.params.id})

        res.json(statu)
    } catch (error) {
        console.warn(error)
        res.send(
            {message: error.message}
        )
    }
})

router.post('/', async (req,res) => {
    try {
        const newStatus = new Status({
            title: req.body.title,
            slug: req.body.slug
        })

        const statusSaved = await newStatus.save()

        res.json(statusSaved)
    } catch (error) {
        console.warn(error)
        res.send(
            {message: error.message}
        )
    }
})

router.put('/:id', async (req,res) => {
    try {
        const updateStatus = await Status.findOne({_id: req.params.id})
        const statusToUpdate = await Status.updateOne(
            {_id: req.params.id},
            {
                $set: {
                    title: req.body.title ?? updateStatus.title,
                    slug: req.body.slug ?? updateStatus.slug
                }
            }
        )

        res.json(statusToUpdate)
    } catch (error) {
        console.warn(error)
        res.send(
            {message: error.message}
        )
    }
})

router.delete('/:id', async (req,res) => {
    try {
        const statusDelete = await Status.remove({_id: req.params.id})

        res.json(statusDelete)
    } catch (error) {
        console.warn(error)
        res.send(
            {message: error.message}
        )
    }
})

module.exports = router