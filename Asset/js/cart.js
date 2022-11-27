
let addCart = document.querySelector(".content-right .addCart");
let removeCart = document.querySelector(".content-right .remove-cart");
let BtnAddCart = document.querySelector(".btn-add-cart");
let BtnBy = document.querySelector(".btn-by");
let cart = document.querySelector(".cart");
let amount = document.querySelector(".amount");
let count = 0;

console.log(BtnBy)
addCart.addEventListener("click", () => {

    count++;
    amount.value = count;
})
removeCart.addEventListener("click", () => {
    count--;
    if (count < 0)
        count = 0;
    amount.value = count;
})

let des = document.querySelector(".des");
let pay = document.querySelector(".pay");
BtnBy.addEventListener("click", function () {
    var price = parseFloat($(".price").text());
    var sl = document.querySelector(".amount").value;
    pay.classList.toggle("show");
    des.innerHTML = `<label>Thanh toán :  ${price * sl} </label>`
})

/*let close = document.querySelector(".pay .closePay")
close.addEventListener("click", function () {
    pay.classList.remove("show1");
})
*/

