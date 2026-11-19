
function Header(props){
    return(
        <header>
            <h1>Witamy na stronie: Matematyka dla każdego</h1>
            <h3>Pomozemy zrozumieć i rozwiązać: {props.rodzaj}</h3>
            <hr/>
            
        </header>
    );
}

export default Header;