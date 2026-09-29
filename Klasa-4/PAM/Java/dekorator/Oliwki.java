public class Oliwki extends Dodatek{
    public Oliwki(Pizza pizza) {
        super(pizza);
    }

    @Override
    public void Opis() {
        pizza.Opis();
        System.out.println(" z oliwkami");
    }
}
