void main() throws InterruptedException {
//    Thread t1 = new Thread(
//            () -> {
//                System.out.println("Działa watek1");
//            }
//    );
//    t1.start();
//
//    Thread t2 = new Thread(new Watek1());
//    t2.start();
//
//    Thread t3 = new Thread(new Watek2());
//    t3.start();

    Thread cyfry = new Thread(new zadWatek1());
    Thread liczby = new Thread(new zadWatek2());

    cyfry.start();
    cyfry.join();
    liczby.start();
}