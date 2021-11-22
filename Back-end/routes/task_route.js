const express = require('express')
const router = express()
const bodyParser = require('body-parser')
router.locals.moment = require('moment')

const Task = require('../models/task_model')
router.use(bodyParser.json())

router.get('/', async (req, res) => {
    try {
        const tasks = await Task.find();
        res.json(tasks);
    } catch (error) {
        console.warn(error);
        res.json({message: error.message});
    }
});

router.post("/", async (req, res) => {
    try {
        const task = new Task({
            remind: req.body.remind,
            title: req.body.title,
            description: req.body.description,
            subtitle: req.body.subtitle,
            thumbnail: req.body.thumbnail,
            checked: req.body.checked
        });

        const savedTask = await task.save();
        res.json(savedTask);
    } catch (error) {
        console.warn(error);
        res.json({message: error.message});
    }
});

router.put("/:id", async (req, res) => {
    try {
        const taskToUpdate = await Task.findById(req.params.id);
        const updateTask = await Task.updateOne(
            {_id: req.params.id},
            {
                $set: {
                    title: req.body.title ?? taskToUpdate.title,
                    description: req.body.description ?? taskToUpdate.description,
                    subtitle: req.body.subtitle ?? taskToUpdate.subtitle,

                }
            }
        );
        res.send(updateTask);
    } catch (error) {
        console.warn(error);
        res.json({message: error.message});
    }
});

router.delete("/:id", async (req, res) => {
    try {
        const taskDeleted = await Task.remove({_id: req.params.id});
        res.json(taskDeleted);
    } catch (error) {
        console.warn(error);
        res.json({message: error.message});
    }
})

module.exports = router;