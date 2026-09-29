import java.util.ArrayList;
import java.util.List;

public class Folder extends systemPlikow{
    private List<systemPlikow> pliki;

    public Folder(String nazwa) {
        super(nazwa);
        pliki = new ArrayList<>();
    }

    @Override
    public void wyswietl() {
        System.out.println(getNazwa());
        for(systemPlikow item : pliki){
            item.wyswietl();
        }
    }

    public void adPlik(systemPlikow sp){
        pliki.add(sp);
    }
}
