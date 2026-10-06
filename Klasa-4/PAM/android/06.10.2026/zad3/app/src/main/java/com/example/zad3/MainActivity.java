package com.example.zad3;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class MainActivity extends AppCompatActivity {

    EditText login, wiek;
    Button but1;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });

        login = findViewById(R.id.inputLogin);
        wiek = findViewById(R.id.inputAge);
        but1 = findViewById(R.id.but1);

        but1.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                String login_napis = login.getText().toString();
                String wiek_napis = wiek.getText().toString();

                //Egzamin
                int wiek = Integer.parseInt(wiek_napis);
                if(login_napis.length() >= 5 && wiek >= 0 && wiek <= 100){
                    Toast.makeText(MainActivity.this, "OK", Toast.LENGTH_SHORT).show();
                }
                else{
                    Toast.makeText(MainActivity.this, "ZLE", Toast.LENGTH_SHORT).show();
                }

                //Życiowo
                if(login_napis.matches("\\w{5,}") && wiek_napis.matches("\\d{1,2}")){
                    Toast.makeText(MainActivity.this, "OK", Toast.LENGTH_SHORT).show();
                }
                else{
                    Toast.makeText(MainActivity.this, "ŹLE", Toast.LENGTH_SHORT).show();
                }
            }
        });
    }
}