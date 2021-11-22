const mongoose = require('mongoose')

const IpSchema = mongoose.Schema({
    address: {
        type: String
    }
})

module.exports = mongoose.model('Ip', IpSchema)