import React, { useState } from 'react';

function MainProgram(){

    const [a, setA] = useState('');
    const [b, setB] = useState('');
    const [c, setC] = useState('');

    const [blad, setBlad] = useState('');
    const [wynik, setWynik] = useState(null);

    function oblicz() {

        if (a === '' || b === '' || c === '' || isNaN(a) || isNaN(b) || isNaN(c)) {
            setBlad('Błędne dane!');
            setWynik(null);
            return;
        }

        setBlad('');

        let A = Number(a);
        let B = Number(b);
        let C = Number(c);

        if (A === 0) {
            setBlad('Błędne dane!');
            setWynik(null);
            return;
        }

        let delta = B * B - 4 * A * C;

        if (delta > 0) {

            let x1 = (-B - Math.sqrt(delta)) / (2 * A);
            let x2 = (-B + Math.sqrt(delta)) / (2 * A);

            setWynik({
                delta: delta,
                x1: x1,
                x2: x2,
                typ: 2,
                a: A
            });

        } else if (delta === 0) {

            let x0 = -B / (2 * A);

            setWynik({
                delta: delta,
                x0: x0,
                typ: 1,
                a: A
            });

        } else {

            setWynik({
                delta: delta,
                typ: 0,
                a: A
            });

        }
    }


    return(
        <div className="mainProgram-block">
            <div className="info-block">
                <h3>Postać ogólna:</h3>

                <h4>ax² + bx + c = 0</h4>

                <h4>Wyróżnik równania kwadratowego</h4>

                <p>Delta = b² - 4ac</p>

                <ul>
                    <li>Jeśli delta &gt; 0 równanie ma dwa rozwiązania:</li>
                    x1 = (-b - sqrt(delta)) / 2a<br/>
                    x2 = (-b + sqrt(delta)) / 2a
                    <li>Jeśli delta = 0 równanie ma jedno rozwiązanie:</li>
                    x0 = (-b) / (2a)
                    <li>Jeśli delta &lt; 0 równanie nie ma rozwiązań.</li>
                </ul>
                <hr/>

            </div>
            <div className="calculation-block">
                <div className="formularz">
                    <label>Proszę podać a:
                        <input type="number" value={a} onChange={(e) => setA(e.target.value)}/></label>
                    <label>Proszę podać b:
                        <input type="number" value={b} onChange={(e) => setA(e.target.value)}/></label>
                    <label>Proszę podać c:
                        <input type="number" value={c} onChange={(e) => setA(e.target.value)}/></label>

                </div> 
                <div className="photo-block">

                </div>
            </div>
        </div>
    );
}

export default MainProgram;