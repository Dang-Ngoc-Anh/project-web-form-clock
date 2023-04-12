
const btnCloseLogin = document.querySelector(".fa-closeLogin")
let fromLogin = document.querySelector(".from-login")

btnCloseLogin.addEventListener("click", function () {
    fromLogin.classList.add("show")
})

let btnCheckLogin = document.querySelector('.btnCheckLogin');
let userName = document.querySelector('#userName');
let passWord = document.querySelector('#passWord');


console.log(userName.value , passWord.value , btnCheckLogin.value)
btnCheckLogin.addEventListener("click", function (e) {
    let cnt = 0;
    if ((userName.value.trim() == "")) {
        alert("Email không được bỏ trống");
        cnt++;
    }
    else if (passWord.value.trim() == "") {
        alert("Bạn chưa nhập mật khẩu");
        cnt++;
    }

})

