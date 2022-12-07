let btncloseSignUp = document.querySelector(".fa-closeSignUp");
let formSignUp = document.querySelector(".from-signUp");

btncloseSignUp.addEventListener("click", function () {
    formSignUp.classList.add("show")
})

let useName = document.getElementById("useName");
let passWord = document.getElementById("passWord");
let conFirmPassWord = document.getElementById("ConfirmpassWord");
let btnSignUp = document.querySelector(".btnSignUp");
let form = document.querySelector('form');


function showErr(input , message) {
    let parent = input.parentElement;
    let small = parent.querySelector("small")

    small.classList.add('showStringErr');
    small.innerText = message;
}
function showSucces(input) {
    let parent = input.parentElement;
    let small = parent.querySelector('small')
    small.classList.remove('showStringErr')
    small.innerText = "";
}


function checkEmail(input) {
    const regexemail =
        /^(([^<>()[\]\.,;:\s@\"]+(\.[^<>()[\]\.,;:\s@\"]+)*)|(\".+\"))@(([^<>()[\]\.,;:\s@\"]+\.)+[^<>()[\]\.,;:\s@\"]{2,})$/i;

    input.value = input.value.trim();

    let isEmailErr = !(regexemail.test(input));
    if (regexemail.test(input)) {
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



form.addEventListener("submit", function (e) {
    let isEmptyErr = checkValueEmpty([useName, passWord, conFirmPassWord]);
    let EmailErr = checkEmail(useName);
})



