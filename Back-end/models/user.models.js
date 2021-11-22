const mongoose = require("mongoose")

const userSchema = new mongoose.Schema({
    email: {
        type: String,
        required: true,
        unique: true
    },
    password: {
        type: String,
        required: true
    },
    // is_activ: {
    //     type: String,
    //     required: true
    // },
    // last_login: {
    //     type: String,
    //     required: true
    // },
    phone_number: {
        type: String,
        required: true
    },
    last_name: {
        type: String,
        required: true
    },
    first_name: {
        type: String,
        required: true
    },
    contact: [{ type: mongoose.Types.ObjectId, ref: "Contact"}],
    message: [{ type: mongoose.Types.ObjectId, ref: "Message"}],
    ip: [{ type: mongoose.Types.ObjectId, ref: "Ip"}],
    tasks: [{ type: mongoose.Types.ObjectId, ref: "Task"}]
})

module.exports = mongoose.model('User', userSchema)