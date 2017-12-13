if (document.getElementById("front_page_wrapper")) {
    document.getElementById("general-search").style.display = "none";
}

if (document.getElementById("front_page_wrapper")) {
    document.getElementById("body-wrapper").style.backgroundImage = "url(../../Content/Image/background.jpeg)";
} else if (document.getElementById("games")) {
    document.getElementById("body-wrapper").style.backgroundPosition = "top center";
    document.getElementById("body-wrapper").style.backgroundImage = "url(../../Content/Image/background1.jpg)";
}