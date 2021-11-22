const express = require("express")
const cors = require("cors")
const mongoose = require('mongoose')
const cookieParser = require('cookie-parser')


const tasksRoute = require('./routes/task_route')
const userRoute = require('./routes/user.route')
const messageRoute = require('./routes/message.route')
const contactRoute = require('./routes/contact.route')
const statusRoute = require('./routes/status.route')
const ipRoute = require('./routes/ip_route')

require('dotenv/config')

mongoose.connect(
    process.env.DB_CONNECTION,
    {useNewUrlParser: true, useUnifiedTopology: true},
    () => {
        return console.log('Connection à MongoDB')
    }
)


const app = express()

app.use(cookieParser());
app.use(cors({
    credentials: true,
    origin: ["http://localhost:8000", "http://localhost:3001", "http://localhost:3000"]
}));

app.use(express.json())

app.use("/api/v1/tasks", tasksRoute)
app.use("/api/v1/user", userRoute)
app.use('/api/v1/message', messageRoute)
app.use('/api/v1/contact', contactRoute)
app.use('/api/v1/status', statusRoute)
app.use('/api/v1/ip', ipRoute)

app.listen(8000)