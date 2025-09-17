const btn1 = document.querySelectorAll(".btn1");
const btn2 = document.querySelectorAll(".btn2");
const nameStuff = document.querySelectorAll(".name")
const check = document.querySelectorAll(".check");

let orderId = 0;

colorCheck();

function colorCheck() {
    check.forEach((element) => {
        if (element.textContent == 0) {
            element.style.backgroundColor = "Red";
        }
        else if (element.textContent >= 1 && element.textContent <= 5) {
            element.style.backgroundColor = "Yellow";
        }
        else {
            element.style.backgroundColor = "Honeydew";
        }
    });
}

btn1.forEach((btn, index) => {
    btn.addEventListener("click", function () {
        const newValue = window.prompt("Podaj nową ilość: ");
        check[index].textContent = newValue;
        colorCheck();
    });
});

btn2.forEach((btn, index) => {
    btn.addEventListener("click", function () {
        orderId++;
        window.alert(`Zamówienie nr: ${orderId} Produkt: ${nameStuff[index].textContent}`);
    });
});
