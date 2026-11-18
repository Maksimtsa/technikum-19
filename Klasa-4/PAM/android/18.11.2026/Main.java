package com.example.dodawaniezdjec;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.LinearLayout;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class MainActivity extends AppCompatActivity {

    ImageView img1, img2;
    Button btn1;

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

        img1 = findViewById(R.id.zdjecie1);
        //img2 = findViewById(R.id.zdjecie2);
        btn1 = findViewById(R.id.btn1);

        btn1.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                //img2.setVisibility(View.VISIBLE);
                ImageView iv = new ImageView(getApplicationContext());
                iv.setImageResource(R.drawable.brazil1);
                iv.setScaleType(ImageView.ScaleType.CENTER);

                

                LinearLayout ll = findViewById(R.id.main);
                ll.addView(iv, ll.indexOfChild(btn1));
            }
        });
    }
}
