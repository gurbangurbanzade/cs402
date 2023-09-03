const getBTN = document.querySelector(".getBTN");
const sendBTN = document.querySelector(".sendBTN");

const nameINP = document.querySelector(".nameINP");
const pasINP = document.querySelector("#pasINP");

// get data

getBTN.addEventListener("click", function () {
  console.log("salam");
  // fetch
  //   fetch("https://northwind.vercel.app/api/products/")
  //     .then((res) => res.json())
  //     .then((data) => {
  //       console.log(data[5].name);

  //       //   for (let i = 0; i < data.length; i++) {
  //       //     console.log(data[i].name);
  //       //   }
  //     });

  // axios
  axios("https://northwind.vercel.app/api/products/").then(function (response) {
    // handle success
    console.log(response.status);
  });
});

// post
sendBTN.addEventListener("click", function () {
  let obj = {
    name: nameINP.value,
    parol: pasINP.value,
  };

  fetch("https://northwind.vercel.app/api/products/", {
    headers: {
      Accept: "application/json",
      "Content-Type": "application/json",
    },
    method: "POST",
    body: JSON.stringify(obj),
  }).then(function (res) {
    console.log(res);
  });
});

// delete method

let a = 5;
axios
  .delete(`https://northwind.vercel.app/api/products/${a}`)
  .then(function (response) {
    // handle success
    console.log(response.status);
  });
