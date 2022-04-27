const express = require('express');
const app     = express();

const portNum = 6969;

app.get('/get-p', function (req, res) {
  console.log("here-p >>>>>>>>>>>>>>>>>>>>");
  res.send(JSON.stringify(1));
  console.log("here-p <<<<<<<<<<<<<<<<<<<<");
})

app.get('/get-o', function (req, res) {
  console.log("here-o >>>>>>>>>>>>>>>>>>>>");
  res.send(JSON.stringify({}));
  console.log("here-o <<<<<<<<<<<<<<<<<<<<");
})

app.get('/get-a', function (req, res) {
  console.log("here-a >>>>>>>>>>>>>>>>>>>>");
  res.send(JSON.stringify([{},{},{}]));
  console.log("here-a <<<<<<<<<<<<<<<<<<<<");
})

app.listen(portNum, function () {
  console.log(`Listening on port ${portNum}...`);
})

