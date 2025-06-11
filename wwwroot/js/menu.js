window.toggleNavbar = function () {
    const navbar = document.getElementById("navbar");
    if (navbar) {
        navbar.classList.toggle("active");
    }
};

window.closeNavbar = function () {
    const navbar = document.getElementById("navbar");
    if (navbar) {
        navbar.classList.remove("active");
    }
};
