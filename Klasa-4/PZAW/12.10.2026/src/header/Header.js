import logo from '../logo.png';

function Header(props) {
    return (
        <div className='header-block'>
            <h1>Witamy na stronie firmy: {props.Nazwa}</h1>
            <img src={logo} alt="logo" />
        </div>
    );
}

export default Header;