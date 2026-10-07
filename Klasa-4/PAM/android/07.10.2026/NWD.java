package com.example.a0712zad1;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class NWD extends AppCompatActivity {

    EditText inputA, inputB;

    Button but1;
    TextView res;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_nwd);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });

        inputA = findViewById(R.id.inputNWDA);
        inputB = findViewById(R.id.inputNWDB);
        res = findViewById(R.id.result);
        but1 = findViewById(R.id.butNWD);

        but1.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                int a = Integer.parseInt(inputA.getText().toString());
                int b = Integer.parseInt(inputB.getText().toString());

                Tools tool = new Tools();
                int wynik = tool.NWD(a, b);
                res.setText(String.valueOf(wynik));
            }
        });
    }
}