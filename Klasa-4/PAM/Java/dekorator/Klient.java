public class Klient {

    public void main(){
        Pizza p1 = new PizzaNormal();
        p1.Opis();

        Pizza p2 = new Ananasik(new PizzaNormal());
        p2.Opis();

        Pizza p3 = new Oliwki(new Szynka(new Ananasik(new PizzaNaGrubym())));
        p3.Opis();
    }
}
