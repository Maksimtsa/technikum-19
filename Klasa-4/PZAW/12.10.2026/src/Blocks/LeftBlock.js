import React, { Component } from "react";
import fordNew from "./newCar/ford.png";
import ferrariNew from "./newCar/ferrari.jpg"


class LeftBlock extends Component{
    constructor(props){
        super(props);
        this.state = {
            newCar: [
                {id: 0, Marka: "Ford", Zjęcie: fordNew},
                {id: 0, Marka: "Ferrari", Zjęcie: ferrariNew},
                {id: 0, Marka: "", Zjęcie: ""}
            ]
        }
    }

    render(){
        return(
            <div className="left-block">
                <h3>Polecamy nowe samochody w najlepszej cenie</h3>
                {this.state.newCar.map((item, index) => (
                    <div>
                        <h4>Marka: {item.Marka}</h4>
                        <p>Zdjęcie</p>
                        <img src={item.Zjęcie} alt={item.Marka}></img>
                    </div>
                ))}
            </div>
        )
    }
}

export default LeftBlock;