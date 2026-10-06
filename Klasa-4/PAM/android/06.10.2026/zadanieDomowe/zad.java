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

    EditText login, haslo, haslo2, kod;
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
        haslo = findViewById(R.id.inputPassword);
        haslo2 = findViewById(R.id.inputPassword2);
        kod = findViewById(R.id.inputCode);
        but1 = findViewById(R.id.but1);

        but1.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                String login_napis = login.getText().toString();
                String haslo_napis = haslo.getText().toString();
                String hasloPowt_napis = haslo2.getText().toString();
                String kod_napis = kod.getText().toString();


                if(login_napis.matches("^[A-Za-z0-9._]+@[A-Za-z0-9.]+\\.[A-Za-z]{2,}$") && haslo_napis.matches("^(?=.*[0-9])(?=.*[!@#$%^&*]).{8,}$") && haslo_napis.equals(hasloPowt_napis)
                && kod_napis.matches("^[A-Z]-[0-9]{4}$")){
                    Toast.makeText(MainActivity.this, "OK", Toast.LENGTH_SHORT).show();
                }
                else{
                    Toast.makeText(MainActivity.this, "ZLE", Toast.LENGTH_SHORT).show();
                }
            }
        });
    }
}
