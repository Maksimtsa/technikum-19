const btn1 = document.querySelector("#btn1");
const btn2 = document.querySelector("#btn2");
const btn3 = document.querySelector("#btn3");


btn1.addEventListener("click", function () {
    const name = document.querySelector('#name').value;
    const surname = document.querySelector('#surname').value;

    if (name && surname) { }
    else {
        alert('Proszę wypełnić wszystkie pola');
        return;
    }
    const frm1 = document.querySelector("#form1");
    const frm2 = document.querySelector("#form2");
    frm1.classList.remove('active');
    frm2.classList.add('active');
});

btn2.addEventListener("click", function () {
    const email = document.querySelector('#email').value;
    const phone = document.querySelector('#phone').value;

    if (email && phone) { }
    else {
        alert('Proszę wypełnić wszystkie pola');
        return;
    }
    const frm2 = document.querySelector("#form2");
    const frm3 = document.querySelector("#form3");
    frm2.classList.remove('active');
    frm3.classList.add('active');
});

btn3.addEventListener("click", function () {
    const pas = document.querySelector('#pas').value;
    const pasEx = document.querySelector('#pasEx').value;
    const name = document.querySelector('#name').value;
    const surname = document.querySelector('#surname').value;

    if (pas == pasEx) {
        console.log(`Witaj ${name} ${surname}`);
        alert('Formularz zakończony');
    }
    else {
        alert('Podane hasła różnią się');
    }

});
