import React, {useState} from "react";


function Main(){
    const [buty, setButy] = useState([
        {id: 0, sezon: "lato", foto: foto, nazwa: "sandaly", stanMagazynowy: 15},
        {id: 1, sezon: "lato", foto: foto, nazwa: "klapki", stanMagazynowy: 20},
        {id: 3, sezon: "zima", foto: foto, nazwa: "kozaki", stanMagazynowy: 5},
        {id: 4, sezon: "zima", foto: foto, nazwa: "trapery", stanMagazynowy: 10}
    ]);

    const przyjecieButowLetnich = () => {
        const noweLetnieButy = [
            { id: 4, sezon: "letnie", foto: japonkiFoto, nazwa: "japonki", stanMagazynowy: 15 },
            { id: 5, sezon: "letnie", foto: rzymiankiFoto, nazwa: "rzymianki", stanMagazynowy: 12 }]
        if(!buty.some(but => but.id === 4)){
            setButy(...buty, ...noweLetnieButy);
        }
        
    };

    const przyjecieButowZimowych = () => {
        const noweZimoweButy = [
            { id: 6, sezon: "zimowe", foto: kozakiFoto, nazwa: "kozaki", stanMagazynowy: 0 },
            { id: 7, sezon: "zimowe", foto: traperyFoto, nazwa: "trapery", stanMagazynowy: 22 }
        ];
        if(!buty.some(but => but.id === 6)){
            setButy(...buty, ...noweZimoweButy);
        }
    }

    const usuwanieWyprzedanych = () => {
        const przefiltrowanie = buty.filter(buty => but.stanMagazynowy >= 0);
        setButy(przefiltrowanie);
    }

    const sprzedanieParyButow = (id) => {
        const zaktualizowane = buty.map(but => {});
    }
}