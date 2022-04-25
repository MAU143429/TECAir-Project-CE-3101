package com.example.tecair;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

import androidx.appcompat.app.AppCompatActivity;

public class PromoActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_promo);

        Button promobtn = (Button) findViewById(R.id.promobtn);
        promobtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                bookTicket();
            }
        });
    }
    public void bookTicket() {
        Intent intent = new Intent(this, PassengerActivity.class);
        startActivity(intent);
    }
}