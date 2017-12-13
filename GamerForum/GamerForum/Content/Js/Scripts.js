if (document.getElementById("front-page")) {
    document.getElementById("general-search").style.display = "none";
    document.getElementById("navigation-circles").style.display = "none";
    
}

if (document.getElementById("front-page")) {
    document.getElementById("body-wrapper").style.backgroundImage = "url(../../Content/Image/background.jpeg)";
} else if (document.getElementById("wanted-games-create")) {
    document.getElementById("body-wrapper").style.backgroundPosition = "top center";
    document.getElementById("body-wrapper").style.backgroundImage = "url(../../Content/Image/boardgameBackground1.jpg)";
} else if (document.getElementById("user-create")) {
    document.getElementById("body-wrapper").style.backgroundImage = "url(../../Content/Image/boardgameBackground1.jpg)";
} else if (document.getElementById("user-profile")) {
    document.getElementById("body-wrapper").style.backgroundImage = "url(../../Content/Image/boardgameBackground1.jpg)";
}