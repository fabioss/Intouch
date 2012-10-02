function horizontal() {

    if (document.getElementById("menu_dropdown") != null) {
        var navItems = document.getElementById("menu_dropdown").getElementsByTagName("li");


        for (var i = 0; i < navItems.length; i++) {
            if (navItems[i].className == "submenu") {
                if (navItems[i].getElementsByTagName('ul')[0] != null) {
                    navItems[i].onmouseover = function() { this.getElementsByTagName('ul')[0].style.display = "block"; this.style.backgroundColor = "#244F7B"; }
                    navItems[i].onmouseout = function() { this.getElementsByTagName('ul')[0].style.display = "none"; this.style.backgroundColor = "#244F7B"; }
                }
            }
        }

        var navItems2 = document.getElementById("menu_dropdown2").getElementsByTagName("li");

        for (var i = 0; i < navItems2.length; i++) {
            if (navItems2[i].className == "submenu") {
                if (navItems2[i].getElementsByTagName('ul')[0] != null) {
                    navItems2[i].onmouseover = function() { this.getElementsByTagName('ul')[0].style.display = "block"; this.style.backgroundColor = "#244F7B"; }
                    navItems2[i].onmouseout = function() { this.getElementsByTagName('ul')[0].style.display = "none"; this.style.backgroundColor = "#244F7B"; }
                }
            }
        }
    }
 
}