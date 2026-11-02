
function Footer(){
    const dataBiezaca = new Date();
    const dzien = dataBiezaca.getDate();
    const miesiac = dataBiezaca.getMonth() + 1;
    const rok = dataBiezaca.getFullYear();

    return (
        <footer>
            <div>
                <p className="footer-data">
                    Dzisiejsza data: {dzien}.{miesiac}.{rok}
                </p>
            </div>
        </footer>
    );
}

export default Footer;