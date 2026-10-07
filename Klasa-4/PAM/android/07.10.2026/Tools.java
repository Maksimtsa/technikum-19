package com.example.a0712zad1;

public class Tools {
    public int NWD(int a, int b){
        while (a != b){
            if(a > b){
                a -= b;
            }
            else{
                b -= a;
            }
        }
        return a;
    }

    public int Suma(int a, int b){
        return a + b;
    }
}
