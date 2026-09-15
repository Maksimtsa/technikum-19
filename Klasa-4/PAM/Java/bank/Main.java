void main() {

    Konto konto1 = new Konto(500);
    Thread wplac = new Thread(new Wplac(konto1));
    Thread wyplac = new Thread(new Wyplac(konto1));

    wplac.start();
    wyplac.start();
}
