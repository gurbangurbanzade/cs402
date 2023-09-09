const ad = document.querySelector(".ad");
const soyad = document.querySelector(".soyad");
const form = document.querySelector(".form");

form.addEventListener("submit", function (e) {
  e.preventDefault();
  console.log(ad.value);
  console.log(soyad.value);
  let azerinObyekti = {};
  azerinObyekti.ad = ad.value;
  azerinObyekti.soyad = soyad.value;
  console.log(azerinObyekti);
});
