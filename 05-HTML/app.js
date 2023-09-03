let dataBase = [
  {
    name: "qurban",
    parol: 123,
  },
  {
    name: "kenan",
    parol: 321,
  },
];
console.log("baslangic baza", dataBase);
const nameINP = document.querySelector(".nameINP");
const pasINP = document.querySelector("#pasINP");
const submitBTN = document.querySelector(".submitBTN");
const form = document.querySelector(".form");

form.addEventListener("submit", function (e) {
  e.preventDefault();

  if (nameINP.value.length > 3) {
    console.log("ugurlu");

    for (let i = 0; i < nameINP.value.length; i++) {
      console.log(nameINP.value[i]);
      if (nameINP.value[i] * 1 == +nameINP.value[i]) {
        alert("adda bir reqem var");
        break;
      } else {
        // funkisiya buradadir
        validation(nameINP.value, pasINP.value);
      }
    }
  } else {
    // console.log("ugursuzdur");
    alert("ugursuzdur");
    nameINP.value = "";
    pasINP.value = "";
  }
});

function validation(x, y) {
  console.log("ugurludur");
  // yeni bir obyekt yaratdiq
  let obj = {};
  // obyektimize deyerler menimsetdik
  //   obj.name = nameINP.value;
  obj.name = x;
  //   obj.parol = pasINP.value;
  obj.parol = y;
  // bazaya push etdik
  dataBase.push(obj);
  console.log("son hali=", dataBase);
  // inputlari bosaltdiq
  document.querySelector(".customLabel").innerHTML = x;
  document.querySelector("body").innerHTML = "";
  nameINP.value = "";
  pasINP.value = "";
}
