const mongoose = require('mongoose')

const CategorieSchema = mongoose.Schema({
    title: {
        type: String,
        required: true,
        unique: true
    },
    color: {
        type: String
    },
    thumbail: {
        type: String
    }
})

module.exports = mongoose.model('Categorie', CategorieSchema)