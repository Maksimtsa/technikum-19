public class Plik extends systemPlikow{
    public Plik(String nazwa) {
        super(nazwa);
    }

    @Override
    public void wyswietl(){
        System.out.println(getNazwa());
    }
}
