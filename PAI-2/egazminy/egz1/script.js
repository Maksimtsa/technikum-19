function btn(name) {
    document.querySelector('#mainImg').src = name + ".jpg";
}

function iconBtn() {
    const icn = document.getElementById('icon');
    const weq = 'icon-off.png';
    if (weq == 'icon-off.png') {
        icn.src = 'icon-on.png';
    }
    else {
        icn.src = 'icon-off.png';
    }

}
