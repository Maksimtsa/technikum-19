interface Czajnik {
    public void ustawTemperature(double temperaturaF);
}

class StaryCzajnik{
    public void UstawTemeperature(double temperaturaC){
        System.out.println("Temp C: " + temperaturaC);
    }
}

class AdapterCzajnika implements Czajnik{
    private StaryCzajnik staryCzajnik;

    public AdapterCzajnika(StaryCzajnik staryCzajnik){
        this.staryCzajnik = staryCzajnik;
    }

    @Override
    public void ustawTemperature(double temperaturaF){
        double temperaturaC = (temperaturaF - 32) * 5 / 9;

        staryCzajnik.UstawTemeperature(temperaturaC);
    }
}

public static void main(String[] args) {

}
