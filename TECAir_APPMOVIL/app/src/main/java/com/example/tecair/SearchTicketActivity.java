package com.example.tecair;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.CalendarView;
import android.widget.Toast;

public class SearchTicketActivity extends AppCompatActivity {

    private static final String TAG = "BookTicketActivity";
    CalendarView calendarView;
    Button searchbtn;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_search_ticket);

        calendarView = findViewById(R.id.calendarView);
        calendarView.setMinDate(System.currentTimeMillis());

        searchbtn = findViewById(R.id.searchbtn);

        searchbtn.setOnClickListener(view -> searchTicket());
    }

    public void searchTicket() {
        Intent intent = new Intent(this, BookTicketActivity.class);
        startActivity(intent);
    }
}