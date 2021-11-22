const express = require('express')
const router = express()


router.get('/', (req,res) => {
   const ip = req.headers['x-forwarded-for'] || req.socket.remoteAddress 

//    if (forwardedIpsStr) {
//       ip = forwardedIps = forwardedIpsStr.split(',')[0];  
//    }
    
    res.send(ip)
})

module.exports = router