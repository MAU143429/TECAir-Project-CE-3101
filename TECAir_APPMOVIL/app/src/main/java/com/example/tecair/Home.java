package com.example.tecair;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TableLayout;
import android.widget.TableRow;
import android.widget.TextView;

import java.util.Random;

public class Home extends AppCompatActivity {

    private static final String TAG = "HomeActivity";
    public TableLayout table;
    private String username;
    private boolean tableBool;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_home);
        table = (TableLayout) findViewById(R.id.table);
        Button luggagebtn = (Button) findViewById(R.id.luggagebtn);
        Bundle extras = getIntent().getExtras();
        tableBool = false;
        if (extras != null) {
            username = extras.getString("user");
            //The key argument here must match that used in the other activity
        }

        luggagebtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (!tableBool) {
                    Random r = new Random();
                    int luggage_count = r.nextInt(6);
                    for (int i = 0; i < 10; i++) {
                        add2Table(genID());
                    }
                    tableBool = true;
                }
            }
        });
    }

    public void add2Table (String luggage_id) {
        TableRow row = new TableRow(this);
        TextView id = new TextView(this);
        Button lbtn = new Button(this);
        lbtn.setText("Info");
        id.setText(luggage_id);
        row.addView(id);
        row.addView(lbtn);
        table.addView(row);
    }

    public String genID () {
        String id = "";
        Random r = new Random();
        String[] characters = new String[16];
        characters[0] = "0";
        characters[1] = "1";
        characters[2] = "2";
        characters[3] = "3";
        characters[4] = "4";
        characters[5] = "5";
        characters[6] = "6";
        characters[7] = "7";
        characters[8] = "8";
        characters[9] = "9";
        characters[10] = "A";
        characters[11] = "B";
        characters[12] = "C";
        characters[13] = "D";
        characters[14] = "E";
        characters[15] = "F";
        id += characters[r.nextInt(15)];
        id += characters[r.nextInt(15)];
        id += characters[r.nextInt(15)];
        return id;
    }

}