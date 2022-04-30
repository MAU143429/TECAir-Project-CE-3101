package com.example.tecair;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

import androidx.appcompat.app.AppCompatActivity;

public class PassengerActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_passenger);

        Button returnbtn = (Button) findViewById(R.id.registrarbtn);
        returnbtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                returnMenu();
            }
        });
    }

    public void returnMenu() {
        Intent intent = new Intent(this, MainActivity.class);
        startActivity(intent);
    }
}