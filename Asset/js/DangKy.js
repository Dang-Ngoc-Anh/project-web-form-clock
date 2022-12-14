let btncloseSignUp = document.querySelector(".fa-closeSignUp");
let formSignUp = document.querySelector(".from-signUp");

btncloseSignUp.addEventListener("click", function () {
    formSignUp.classList.add("show")
})
var form = document.querySelector(".form");
let useName = document.querySelector(".useName");
let passWord = document.querySelector(".passWord");
let conFirmPassWord = document.querySelector(".ConfirmpassWord");
let btnSignUp = document.querySelector(".btnSignUp");

function showErr(input , message) {
    let parent = input.parentElement;
    let small = parent.querySelector("small");

    small.classList.add('showStringErr');
    small.innerText = message;
}
function showSucces(input) {
    let parent = input.parentElement;
    let small = parent.querySelector("small");
    small.classList.remove('showStringErr');
    small.innerText = "";
}


function checkEmail(input) {
    let regexemail = /^[a-z][a-z0-9_\.]{5,32}@[a-z0-9]{2,}(\.[a-z0-9]{2,4}){1,2}$/

    input.value = input.value.trim();

    let isEmailErr = !regexemail.test(input.value);

    if (regexemail.test(input.value)) {
        showSucces(input);
    }
    else {
        showErr(input , "Email invalid")
    }

    return isEmailErr;
}
function checkValueEmpty(ListInput) {
    let isEmptyErr = false;
    ListInput.forEach(input => {
        input.value = input.value.trim();

        if (!input.value) {
            isEmptyErr = true;
            showErr(input, "Không được để trống");
        }
        else {
            showSucces(input);
        }
    });

    return isEmptyErr;
        
}

function checkLengthErr(input, min, max) {

    input.value = input.value.trim();

    if (input.value.length < min) {
        showErr( input ,`Mật khẩu phải có ít nhất ${min}`)
        return true;
    }
    if (input.value.length > max) {
        showErr(input, `Phải có ít nhất ${max} ký tự`)
        return true;
    }
    alert
    showSucces(input);
    return false;
}

btnSignUp.addEventListener('click', function (e) {
     let  b1 = checkValueEmpty([useName, passWord, conFirmPassWord]);
     let b2 = checkEmail(useName);
     let b3 = checkLengthErr(passWord, 4, 10);
    /*let b4 = checkLengthErr(conFirmPassWord, 4, 10);*/

    if (b1 == 1) e.preventDefault();


})




