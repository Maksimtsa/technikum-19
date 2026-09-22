void main() throws InterruptedException {
    Licznik licznik1 = new Licznik(0);
    Thread watek1 = new Thread(new licznikWatek(licznik1));
    Thread watek2 = new Thread(new licznikWatek1(licznik1));

    watek1.start();
    watek2.join();
    watek2.start();
}

public class Licznik{
    public int Wartosc;

    public Licznik(int wartosc) {
        Wartosc = wartosc;
    }

    public synchronized int increment(){
        return  Wartosc += 1;
    }
}

public class licznikWatek implements Runnable{
    public Licznik licznik;

    public licznikWatek(Licznik licznik) {
        this.licznik = licznik;
    }

    @Override
    public void run(){
        for(int i = 0; i < 100000; i++){
            licznik.increment();
        }
        System.out.println(licznik.Wartosc);
    }
}

public class licznikWatek1 implements Runnable{
    public Licznik licznik;

    public licznikWatek1(Licznik licznik) {
        this.licznik = licznik;
    }

    @Override
    public void run(){
        for(int i = 0; i < 100000; i++){
            licznik.increment();
        }
        System.out.println(licznik.Wartosc);
    }
}
