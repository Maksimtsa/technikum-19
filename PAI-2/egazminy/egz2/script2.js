function backColor(color) {
    let rightBlock = document.getElementById("rightBlock");
    rightBlock.style.background = color;
}

function fontColor() {
    let rightBlock = document.getElementById("rightBlock");
    let color = document.getElementById("selectColor");
    rightBlock.style.color = color.value;
}

function fontSize() {
    let rightBlock = document.getElementById("rightBlock");
    let size = document.getElementById("size").value;
    rightBlock.style = "font-size: " + size + "%";
}

function imgBorder() {
    let img = document.getElementById("img");
    let choice = document.getElementById("cbBorder").checked;
    if (choice) {
        img.style.border = "1px solid white";
    }
    else {
        img.style.border = "none";
    }
}

function mark(type) {
    let list = document.getElementById("list");
    list.style.listStyleType = type;
}