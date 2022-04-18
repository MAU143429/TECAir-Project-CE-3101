package com.example.tecair;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.CheckBox;
import android.widget.EditText;

public class PassengerActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_passenger);

        CheckBox studentCheckBox = findViewById(R.id.studentCheckBox);
        EditText uniEditText = findViewById(R.id.uniEditText);
        EditText idUniEditText = findViewById(R.id.idUniEditText);

        studentCheckBox.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (studentCheckBox.isChecked()) {
                    uniEditText.setVisibility(View.VISIBLE);
                    idUniEditText.setVisibility(View.VISIBLE);
                } else {
                    uniEditText.setVisibility(View.INVISIBLE);
                    idUniEditText.setVisibility(View.INVISIBLE);
                }
            }
        });
    }
}