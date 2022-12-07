let sidebarToggle = document.querySelector(".sidebar-toggle");
let sidebarClose = document.querySelector(".sidebar .fa-close");
let showSideBar = document.querySelector(".sidebar");

sidebarToggle.addEventListener("click", function () {
    // if (nav.classList.contains("show-sidebar")) {
    //     nav.classList.remove("show-sidebar");
    // } else {
    //     nav.classList.add("show-sidebar");
    // }
    showSideBar.classList.toggle("show-sidebar");
});

sidebarClose.addEventListener("click" , function(){
    showSideBar.classList.remove("show-sidebar")
});




