public class Klient {
    public void main(){
        Folder f = new Folder("DYSK C");

        Folder f1 = new Folder("PUSTY");
        Folder f2 = new Folder("fotos");
        Folder f3 = new Folder("docd");

        Plik p1 = new Plik("foto1.jpg");
        Plik p2 = new Plik("foto2.jpg");
        Plik p3 = new Plik("dok1.txt");

        f.adPlik(f1);
        f.adPlik(f2);
        f.adPlik(f3);

        f2.adPlik(p1);
        f2.adPlik(p2);

        f3.adPlik(p3);

        f.wyswietl();
    }
}
