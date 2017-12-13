if (document.getElementById("front-page")) {
    document.getElementById("general-search").style.display = "none";
    document.getElementById("navigation-circles").style.display = "none";
    
}

if (document.getElementById("front-page")) {
    document.getElementById("body-wrapper").style.backgroundImage = "url(../../Content/Image/frontpage.jpg)";
    document.getElementById("body-wrapper").style.backgroundPosition = "center center";
} else if (document.getElementById("wanted-games-create")) {
    document.getElementById("body-wrapper").style.backgroundPosition = "top center";
    document.getElementById("body-wrapper").style.backgroundImage = "url(../../Content/Image/boardgameBackground1.jpg)";
} else if (document.getElementById("user-create")) {
    document.getElementById("body-wrapper").style.backgroundImage = "url(../../Content/Image/usercreate_new.jpg)";
} else if (document.getElementById("user-profile")) {
    document.getElementById("body-wrapper").style.backgroundImage = "url(../../Content/Image/usercreate_new.jpg)";
} else if (document.getElementById("games")) {
    document.getElementById("body-wrapper").style.backgroundImage = "url(../../Content/Image/boardgameBackground3.jpg)";
} else if (document.getElementById("create-games")) {
    document.getElementById("body-wrapper").style.backgroundImage = "url(../../Content/Image/boardgameBackground3.jpg)";
}