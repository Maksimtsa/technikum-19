public class Konto {
    double stan;

    public Konto(double stan){
        this.stan = stan;
    }

    public synchronized void wplac(double kwota){
        stan += kwota;
    }

    public synchronized void wyplac(double kwota){
        stan -= kwota;
    }

}


