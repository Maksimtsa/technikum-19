import React, {useState} from "react";
import sandaly from "./letnie/sandaly.jpg"
import klapki from "./letnie/klapki.jpg"
import kozaki from "./zimowe/kozaki.jpg"
import trapery from "./zimowe/trapery.jpg"
import japonki from "./letnie/japonki.png"
import rzymianki from "./letnie/rzymianki.jpg"
import sniegowce from "./zimowe/sniegowce.jpg"
import sztybletyZimowe from "./zimowe/sztybletyZimowe.jpg"


function Main(){
    const [buty, setButy] = useState([
        {id: 0, sezon: "letnie", foto: sandaly, nazwa: "sandaly", stanMagazynowy: 15},
        {id: 1, sezon: "letnie", foto: klapki, nazwa: "klapki", stanMagazynowy: 20},
        {id: 3, sezon: "zimowe", foto: kozaki, nazwa: "kozaki", stanMagazynowy: 5},
        {id: 4, sezon: "zimowe", foto: trapery, nazwa: "trapery", stanMagazynowy: 10}
    ]);

    const przyjecieButowLetnich = () => {
        const noweLetnieButy = [
            { id: 5, sezon: "letnie", foto: japonki, nazwa: "japonki", stanMagazynowy: 15 },
            { id: 6, sezon: "letnie", foto: rzymianki, nazwa: "rzymianki", stanMagazynowy: 12 }]
        if(!buty.some(but => but.id === 5)){
            setButy([...buty, ...noweLetnieButy]);
        }
        
    };

    const przyjecieButowZimowych = () => {
        const noweZimoweButy = [
            { id: 7, sezon: "zimowe", foto: sniegowce, nazwa: "sniegowce", stanMagazynowy: 0 },
            { id: 8, sezon: "zimowe", foto: sztybletyZimowe, nazwa: "sztyblety zimowe", stanMagazynowy: 22 }
        ];
        if(!buty.some(but => but.id === 7)){
            setButy([...buty, ...noweZimoweButy]);
        }
    }

    const usuwanieWyprzedanych = () => {
        const przefiltrowanie = buty.filter(but => but.stanMagazynowy > 0);
        setButy(przefiltrowanie);
    }

    const sprzedanieParyButow = (id) => {
        const zaktualizowane = buty.map(but => {
            if (but.id === id && but.stanMagazynowy > 0) {
                return { ...but, stanMagazynowy: but.stanMagazynowy - 1 };
            }
            return but;
        });
        setButy(zaktualizowane);
    };

    const przyjecieParyButow = (id, ilosc) => {
        const zaktualizowane = buty.map(but => {
            if (but.id === id) {
                return { ...but, stanMagazynowy: but.stanMagazynowy + ilosc };
            }
            return but;
        });
        setButy(zaktualizowane);
    };

    return (
        <main>
            <div className="buttonsBlock">
                <button onClick={przyjecieButowLetnich}>
                Przyjmij obuwie letnie
                </button>

                <button onClick={przyjecieButowZimowych}>
                    Przyjmij obuwie zimowe
                </button>

                <button onClick={usuwanieWyprzedanych}>
                    Usuń wyprzedane
                </button>
            </div>
            

            <h2>Obuwie letnie</h2>

            {buty.map(but => {
                if (but.sezon === "letnie") {
                    return (
                        <div key={but.id} className="ofertaBLock">
                            <img src={but.foto} alt={but.nazwa} />
                            <div className="ofertaDane ">
                                <div className="naglowekh3">
                                    <h3>Rodzaj: {but.nazwa}</h3>
                                </div>
                                <p>Stan magazynowy: {but.stanMagazynowy}</p><br/>
                                <div>
                                    <button onClick={() => sprzedanieParyButow(but.id)}>
                                        Sprzedaż detaliczna
                                    </button>
                    
                                    <button onClick={() => {
                                        const ilosc = Number(prompt("Podaj liczbę par:"));
                                        if (ilosc > 0) {
                                            przyjecieParyButow(but.id, ilosc);
                                        }
                                    }}>
                                        Przyjęcie tych butów
                                    </button>
                                </div>
                            </div>
                        </div>
                    );
                }
            })}
            
            <h2>Obuwie zimowe</h2>
            
            {buty.map(but => {
                if (but.sezon === "zimowe") {
                    return (
                        <div key={but.id} className="ofertaBLock">
                            <img src={but.foto} alt={but.nazwa} />
                            <div className="ofertaDane ">
                                <div className="naglowekh3">
                                    <h3>Rodzaj: {but.nazwa}</h3>
                                </div>
                                <p>Stan magazynowy: {but.stanMagazynowy}</p><br/>
                                <div>
                                    <button onClick={() => sprzedanieParyButow(but.id)}>
                                        Sprzedaż detaliczna
                                    </button>
                    
                                    <button onClick={() => {
                                        const ilosc = Number(prompt("Podaj liczbę par:"));
                                        if (ilosc > 0) {
                                            przyjecieParyButow(but.id, ilosc);
                                        }
                                    }}>
                                        Przyjęcie tych butów
                                    </button>
                                </div>
                            </div>
                        </div>
                    );
                }
            })}
        </main>
    );

    
}

export default Main;