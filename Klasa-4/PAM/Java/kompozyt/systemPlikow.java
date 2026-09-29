public abstract class systemPlikow {
    private String Nazwa;

    public systemPlikow(String nazwa) {
        Nazwa = nazwa;
    }

    public abstract void wyswietl();

    public String getNazwa() {
        return Nazwa;
    }
}
