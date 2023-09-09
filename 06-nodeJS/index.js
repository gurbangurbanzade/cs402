let express = require("express");
let mysql = require("mysql2");
// console.log("hello");
const db = [
  {
    name: "qurban",
    surname: "qurbanzada",
  },
  {
    name: "qurban",
    surname: "qurbanzada",
  },
  {
    name: "qurban",
    surname: "qurbanzada",
  },
  {
    name: "qurban",
    surname: "qurbanzada",
  },
];
let app = express();

let connection = mysql.createConnection({
  host: "localhost",
  user: "root",
  password: "300793mm",
  database: "telebeler",
});

// connection.connect(function (err) {
//   if (err) {
//     return console.error("error: " + err.message);
//   }
//   //   console.log(res);
//   console.log("Connected to the MySQL server.");
// });

connection.query(
  "select * from telebeinfo where PersonID != 1",
  function (err, result, fields) {
    console.log(err);
    console.log(result);
    console.log(fields);

    app.get("/:id", function (req, res) {
      res.send(result);
    });
  }
);

app.listen(3000);
