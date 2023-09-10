const express = require("express");
const mysql = require("mysql2");

const app = express();
app.use(express.json());

let db = [
  {
    actor_id: 1,
    first_name: "PENELOPE",
    last_name: "GUINESS",
    last_update: "2006-02-15T00:34:33.000Z",
  },
  {
    actor_id: 2,
    first_name: "NICK",
    last_name: "WAHLBERG",
    last_update: "2006-02-15T00:34:33.000Z",
  },
  {
    actor_id: 3,
    first_name: "ED",
    last_name: "CHASE",
    last_update: "2006-02-15T00:34:33.000Z",
  },
];
let connection = mysql.createConnection({
  host: "localhost",
  user: "root",
  password: "300793mm",
  database: "students",
});
// app.get("/student", function (req, res) {
//   res.send(db);
// });

// // api get method
connection.query("select * from student", function (err, result, fields) {
  //   console.log(err);
  //   console.log(result);
  //   console.log(fields);
  app.get("/student", function (req, res) {
    res.send(result);
  });
});

// app.get("/student", (req, res) => {
//   res.send(db);
// });

// id get
app.get("/student/:id", (req, res) => {
  const elem = req.params;
  // sql id get method
  connection.query("select * from student", function (err, result, fields) {
    // console.log(result);
    for (let i = 0; i < result.length; i++) {
      if (elem.id == result[i].ID) {
        res.send(result[i]);
      }
    }
  });
});
// delete method
app.delete("/student/:id", (req, res) => {
  const elem = req.params.id;
  const silininenElementArray = db.filter(
    (element) => element.actor_id != elem
  );
  connection.query(
    `DELETE FROM student WHERE ID=${elem}`,
    function (err, result, fields) {
      console.log(result);
    }
  );
});

// post method
app.post("/student/", (req, res) => {
  let obj = req.body;
  console.log(obj);
  connection.query(
    `INSERT INTO student (ID, ad, soyad, unvanid)
    VALUES ("${obj.ID}", "${obj.ad}", "${obj.soyad}", "${obj.unvanId}")`,
    function (err, result, fields) {
      app.get("/student", function (req, res) {
        res.send(result);
      });
    }
  );
});

app.listen(3000);
