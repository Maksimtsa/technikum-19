let btn1 = document.querySelector("#btn1");
let btn2_1 = document.querySelector("#btn2_1");
let btn2_2 = document.querySelector("#btn2_2");
let btn3 = document.querySelector("#btn3");
let btn4 = document.querySelector("#btn4");

btn1.addEventListener("click", function(){
    let radio = document.querySelectorAll("input[name='effect']");
    let img = document.querySelector("img[src='pszczola.jpg']");
    radio.forEach((e) => {
        if(e.checked){
            img.style.filter = e.value; 
        }
    });
});

btn2_1.addEventListener("click", function(){
    let img = document.querySelector("img[src='pomarancza.jpg']");
    img.style.filter = "none";
});

btn2_2.addEventListener("click", function(){
    let img = document.querySelector("img[src='pomarancza.jpg']");
    img.style.filter = "grayscale(100%)";
});

btn3.addEventListener("click", function(){
    let img = document.querySelector("img[src='owoce.jpg']");
    let val = document.querySelector("#range3").value;
    img.style.filter = `opacity(${val}%)`;
});

btn4.addEventListener("click", function(){
    let img = document.querySelector("img[src='zolw.jpg']");
    let val = document.querySelector("#range4").value;
    img.style.filter = `brightness(${val}%)`;
});