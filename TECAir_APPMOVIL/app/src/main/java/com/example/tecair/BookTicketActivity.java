package com.example.tecair;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class BookTicketActivity extends AppCompatActivity {

    Button bookingbtn;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_book_ticket);

        bookingbtn = findViewById(R.id.promobtn);
        bookingbtn.setOnClickListener(view -> bookTicket());
    }
    public void bookTicket() {
        Intent intent = new Intent(this, PassengerActivity.class);
        startActivity(intent);
    }
}