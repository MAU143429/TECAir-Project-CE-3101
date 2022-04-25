package com.example.tecair;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        Button bookmenubtn = (Button) findViewById(R.id.bookmenubtn);
        Button promomenubtn = (Button) findViewById(R.id.promomenubtn);

        bookmenubtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                openBookMenu();
            }
        });

        promomenubtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                openPromoMenu();
            }
        });
    }

    public void openBookMenu() {
        Intent intent = new Intent(this, BookTicketActivity.class);
        startActivity(intent);
    }

    public void openPromoMenu() {
        Intent intent = new Intent(this, PromoActivity.class);
        startActivity(intent);
    }
}