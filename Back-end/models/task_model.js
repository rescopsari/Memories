const mongoose = require("mongoose")

const TaskSchema = new mongoose.Schema({
    created_on: {
        type: Date,
        default: Date.now
    },
    remind: {
        type: String
    },
    title: {
        type: String,
        required: true,
        unique: true
    },
    description: {
        type: String,
        required: true
    },
    subtitle: {
        type: String
    },
    thumbnail: {
        type: String
    },
    checked: {
        type: Number
    },
    id_user: [{ type: mongoose.Schema.Types.ObjectId, ref: "User"}],
    id_categorie: [{ type: mongoose.Schema.Types.ObjectId, ref: "Categorie"}],
    id_status: [{ type: mongoose.Schema.Types.ObjectId, ref: 'Status'}]
})

module.exports = mongoose.model('Task', TaskSchema)