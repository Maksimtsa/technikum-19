import java.util.Scanner;
import java.util.Random;
import java.util.ArrayList;
import java.util.Collection;

void main() {
    Scanner input = new Scanner(System.in);
    ArrayList<Integer> nums = new ArrayList<Integer>();
    //zad 1


    int n = input.nextInt();
    for(int i = 0; i < n; i++){
        int numberToAdd = input.nextInt();
        nums.add(numberToAdd);
    }
    System.out.println(nums);

    int sum = 0;
    for (int i = 0; i < nums.toArray().length; i++) {
        sum += nums.get(i);
    }
    int avg = sum/nums.toArray().length;

    System.out.println("Suma: " + sum + ", Średnia: " + avg);

    //zad 2

    System.out.println("Podaj liczbę do usunięcia: ");
    int toRemove = input.nextInt();
    for (int i = 0; i < nums.toArray().length; i++) {
        if(nums.get(i) == toRemove){
            nums.remove(i);
        }
    }
    System.out.println(nums);

    //zad 3
    int min = nums.get(0);
    for (int i = 0; i < nums.toArray().length; i++) {
        if(min > nums.get(i)){
            min = nums.get(i);
        }
    }
    int max = nums.get(0);
    for (int i = 0; i < nums.toArray().length; i++) {
        if(max < nums.get(i)){
            max = nums.get(i);
        }
    }
    System.out.println("Najmniejsza liczba to: " + min + ",\nNajwiększa liczba to: " + max);

    //zad 4
    Collections.sort(nums);
    System.out.println("Posortowana rosnąca: " + nums);
    Collections.reverse(nums);
    System.out.println("Posortowana rosnąca: " + nums);

    //zad 5
    for(int i = 0; i < nums.size()/2; i++){
        int j = nums.size() - 1 - i;

        int tmp = nums.get(i);
        nums.set(i, nums.get(j));
        nums.set(j, tmp);
    }
    System.out.println("Odwrócona lista: " + nums);

    //zad 6
    for(int i = 0; i < nums.size(); i++){
        for(int j = i + 1; j < nums.size(); j++){
            if(nums.get(i) == nums.get(j)){
                nums.remove(j);
                j--;
            }
        }
    }
    System.out.println("Lista po usunięciu duplikatów: " + nums);

    //zad 7
    HashMap<Integer, Integer> mapa = new HashMap<>();
    for (int i = 0; i < nums.size(); i++) {
        mapa.put(i, mapa.getOrDefault(i, 0) + 1);
    }
    System.out.println("Ile występuje każda liczba: \n" + mapa);

}
