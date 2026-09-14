import java.util.Scanner;
import java.util.Collection;

void main() {
    Scanner input = new Scanner(System.in);
    List<Integer> list = new ArrayList<Integer>();
    Random rand = new Random();



    //12. Napisz program wczytujący imiona i wieki osób do HashMap<String, Integer> i wypisujący osobę o najwyższym wieku.
    //13. Napisz program zliczający częstość występowania każdego słowa w podanym tekście za pomocą HashMap.
    //14. Napisz program sortujący mapę HashMap<String, Integer> po wartościach malejąco.

    //zad 13

    HashMap<String, Integer> person = new HashMap<>();
    System.out.println("Ile osób chesz doać?");

    int n = input.nextInt();

    for(int i = 0; i < n; i++){
        String name = input.next();
        int age = input.nextInt();
        person.put(name, age);
    }

    System.out.println(person);

    String oldest = "";
    int highestAge = 0;

    for(String name : person.keySet()){
        int age = person.get(name);

        if(age > highestAge){
            highestAge = age;
            oldest = name;
        }
    }

    System.out.println("Najstarsza osoba: " + oldest + " - " + highestAge);


}
