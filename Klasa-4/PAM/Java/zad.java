import java.util.Scanner;

void main() {
    Scanner input = new Scanner(System.in);

    //zad 1
    System.out.println("Podaj dwie liczby");
    int a = input.nextInt();
    int b = input.nextInt();

    System.out.println(a+b);
    System.out.println(a-b);
    System.out.println(a*b);
    System.out.println(a/b);

    //zad 2
    System.out.println("Podaj dwa boki");
    int bokA = input.nextInt();
    int bokB = input.nextInt();


    System.out.println(bokA * bokB);
    System.out.println((bokA + bokB)*2);

    //zad 3
    double t = input.nextDouble();
    System.out.println((t * 1.8) + 32);

    //zad 4
    System.out.println("podaj dwie liczby do znalezienia nwd");
    int a4 = input.nextInt();
    int b4 = input.nextInt();
    
    while (a4 != b4){
        if(a4 > b4){
            a4 -= b4;
        }
        else{
            b4 -= a4;
        }
    }
    System.out.println(a4);
}

