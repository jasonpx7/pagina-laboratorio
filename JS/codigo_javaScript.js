var sue; var boni; var tb; var ch; var bhi; var pbh;
function sueldo() {
    var index = document.getElementById("cbocargo").selectedIndex;

    if (index == 0) {
        sue = 0;
    }

    if (index == 1) {
        sue = 2000;
    }

    if (index == 2) {
        sue = 2500;
    }

    if (index == 3) {
        sue = 3000;
    }

    if (index == 4) {
        sue = 1000;
    }

    if (index == 5) {
        sue = 1500;
    }

    document.getElementById('txtsueldo').value = sue;
}

function estado_civil() {
    var index = document.getElementById("cboec").selectedIndex;

    if (index == 1) {
        boni = 15;
        tb = sueldo * 0.15;
    }

    if (index == 2) {
        boni = 10;
        tb = sueldo * 0.10;
    }

    if (index == 3) {
        boni = 8;
        tb = sueldo * 0.08;
    }

    if (index == 4) {
        boni = 5;
        tb = sueldo * 0.05;
    }

    document.getElementById('txtpec').value = boni;
    document.getElementById('txttec').value = tb;
}