function AddPattern(){
    const file = document.querySelector("input[type='file']");
    const color = document.querySelector("#colorList").value;
    const price = document.querySelector("input[type='number']").value;

    let fileName = file.value.split('\\').pop();

    alert(`Wzór: ${fileName}, kolor ${color} w cenie ${price} zł`);
 
    const img = document.createElement("img");
    img.className = 'miniatury';
    img.src = fileName;
    img.alt = fileName;
    
    document.querySelector(".secBlock").appendChild(img);
}