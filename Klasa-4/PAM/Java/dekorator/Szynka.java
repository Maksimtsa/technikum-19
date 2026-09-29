public class Szynka extends Dodatek{
    public Szynka(Pizza pizza) {
        super(pizza);
    }

    @Override
    public void Opis() {
        pizza.Opis();
        System.out.println(" z szynką");
    }
}
