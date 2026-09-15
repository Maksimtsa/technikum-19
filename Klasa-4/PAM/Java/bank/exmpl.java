void main() throws InterruptedException {
    var konto = new KontoBankowe("Ivan", 0);
    System.out.println(konto.Saldo);
    Thread t1 = new Thread(new Uruchamialny1(konto));
    Thread t2 = new Thread(new Uruchamialny2(konto));
    t1.start();
//    System.out.println(konto.Saldo);
    t2.start();
//    t2.join();
//    System.out.println(konto.Saldo);
}

public class KontoBankowe {
    public String Imie;
    public Integer Saldo;

    public KontoBankowe(String imie, Integer saldo) {
        Imie = imie;
        Saldo = saldo;
    }

    public void Wplac(int kwota) {
        Saldo += kwota;
    }

    public void Wyplac(int kwota) {
        Saldo -= kwota;
    }
}


public class Uruchamialny1 implements Runnable {
    public KontoBankowe kontoBankowe;

    public Uruchamialny1(KontoBankowe kontoBankowe) {
        this.kontoBankowe = kontoBankowe;
    }

    @Override
    public void run() {
        for (int i = 0; i < 10000; i++)
            kontoBankowe.Wplac(2);
        System.out.println(kontoBankowe.Saldo);
    }
}

public class Uruchamialny2 implements Runnable {
    public KontoBankowe kontoBankowe;

    public Uruchamialny2(KontoBankowe kontoBankowe) {
        this.kontoBankowe = kontoBankowe;
    }

    @Override
    public void run() {
        for (int i = 0; i < 10000; i++)
            kontoBankowe.Wyplac(1);
        System.out.println(kontoBankowe.Saldo);
    }
}
