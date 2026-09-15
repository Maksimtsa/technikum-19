public class Wplac implements Runnable{
    private Konto konto1;

    public Wplac(Konto konto1) {
        this.konto1 = konto1;
    }

    @Override
    public void run(){
        konto1.wplac(350);
        System.out.println(konto1.stan);
    }
}
