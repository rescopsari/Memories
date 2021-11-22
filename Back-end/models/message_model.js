const mongoose = require("mongoose")

const MessageSchema = new mongoose.Schema({
    title: {
        type: String,
        required: true
    },
    content: {
        type: String,
        required: true
    },
    send_on: {
        type: Date,
        default: Date.now
    },
    replyied: {
        type: String
    }
})

module.exports = mongoose.model('Message', MessageSchema)