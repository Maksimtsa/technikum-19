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
            setButy([...buty, ...noweLetnieButy]);
        }
        
    };

    const przyjecieButowZimowych = () => {
        const noweZimoweButy = [
            { id: 6, sezon: "zimowe", foto: kozakiFoto, nazwa: "kozaki", stanMagazynowy: 0 },
            { id: 7, sezon: "zimowe", foto: traperyFoto, nazwa: "trapery", stanMagazynowy: 22 }
        ];
        if(!buty.some(but => but.id === 6)){
            setButy([...buty, ...noweZimoweButy]);
        }
    }

    const usuwanieWyprzedanych = () => {
        const przefiltrowanie = buty.filter(buty => but.stanMagazynowy >= 0);
        setButy(przefiltrowanie);
    }

    const sprzedanieParyButow = (id) => {
        const zaktualizowane = buty.map(but => {});
    }

    const przyjecieParyButow = (id, ilosc) => {
        const zaktualizowane = buty.map(but => {
            if (but.id === id) {
                but.stanMagazynowy = but.stanMagazynowy + ilosc;
            }
            return but;
        });
        setButy(zaktualizowane);
    };

    return (
        <main>
            <button onClick={przyjecieButowLetnich}>
                Przyjmij obuwie letnie
            </button>

            <button onClick={przyjecieButowZimowych}>
                Przyjmij obuwie zimowe
            </button>

            <button onClick={usuwanieWyprzedanych}>
                Usuń wyprzedane
            </button>

            <h2>Obuwie letnie</h2>

            {buty.map(but => {
                if (but.sezon === "lato") {
                    return (
                        <article key={but.id}>
                            <img src={but.foto} alt={but.nazwa} />
                            <h3>Rodzaj: {but.nazwa}</h3>
                            <p>Stan magazynowy: {but.stanMagazynowy}</p>
            
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
                        </article>
                    );
                }
            })}
            
            <h2>Obuwie zimowe</h2>
            
            {buty.map(but => {
                if (but.sezon === "zima") {
                    return (
                        <article key={but.id}>
                            <img src={but.foto} alt={but.nazwa} />
                            <h3>Rodzaj: {but.nazwa}</h3>
                            <p>Stan magazynowy: {but.stanMagazynowy}</p>
            
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
                        </article>
                    );
                }
            })}
        </main>
    );

    
}
