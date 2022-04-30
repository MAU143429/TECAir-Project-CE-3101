package com.example.tecair;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

import androidx.appcompat.app.AppCompatActivity;

public class PromoActivity extends AppCompatActivity {

    Button promobtn;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_promo);

        promobtn = findViewById(R.id.promobtn);
        promobtn.setOnClickListener(view -> bookTicket());
    }
    public void bookTicket() {
        Intent intent = new Intent(this, PassengerActivity.class);
        startActivity(intent);
    }
}