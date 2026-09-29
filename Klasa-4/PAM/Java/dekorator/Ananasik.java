public class Ananasik extends Dodatek{
    public Ananasik(Pizza pizza) {
        super(pizza);
    }

    @Override
    public void Opis() {
        pizza.Opis();
        System.out.println("z ananasikiem");
    }
}
