package com.example.tecair;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class MainActivity extends AppCompatActivity {

    Button bookmenubtn, promomenubtn;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        bookmenubtn = findViewById(R.id.bookmenubtn);
        promomenubtn = findViewById(R.id.promomenubtn);

        bookmenubtn.setOnClickListener(view -> openBookMenu());

        promomenubtn.setOnClickListener(view -> openPromoMenu());
    }

    public void openBookMenu() {
        Intent intent = new Intent(this, SearchTicketActivity.class);
        startActivity(intent);
    }

    public void openPromoMenu() {
        Intent intent = new Intent(this, PromoActivity.class);
        startActivity(intent);
    }
}