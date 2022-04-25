package com.example.tecair;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class BookTicketActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_book_ticket);

        Button bookingbtn = (Button) findViewById(R.id.promobtn);
        bookingbtn.setOnClickListener(new View.OnClickListener() {
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