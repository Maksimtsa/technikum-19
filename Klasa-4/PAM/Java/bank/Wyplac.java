public class Wyplac implements Runnable{
    private Konto konto1;

    public Wyplac(Konto konto1) {
        this.konto1 = konto1;
    }

    @Override
    public void run(){
        konto1.wyplac(350);
        System.out.println(konto1.stan);
    }
}
