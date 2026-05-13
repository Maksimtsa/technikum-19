bnt1 = document.querySelector("#send");

bnt1.addEventListener("click", function(){
    let name = document.querySelector("#name").value;
    let surname = document.querySelector("#surname").value;
    let email =  document.querySelector("#email").value;
    let appl = document.querySelector("#application").value;
    let result = document.querySelector("#result");
    let show = document.querySelector("#show");

    if(show.checked){
        result.innerHTML = `${name} ${surname}<br>${email.toLowerCase()}<br>Usługa: ${appl}`;
    }
})