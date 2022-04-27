package com.example.tecair;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.database.sqlite.SQLiteDatabase;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.TextView;
import android.widget.Toast;

import com.example.tecair.db.DBHelper;
import com.example.tecair.db.DBRequest;

public class LoginActivity extends AppCompatActivity {

    private static final String TAG = "LoginActivity";
    private String user;
    private DBRequest dbRequest;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login);

        EditText userEditText = (EditText) findViewById(R.id.userEditText);
        EditText passwordEditText = (EditText) findViewById(R.id.passwordEditText);

        TextView registerTextView = findViewById(R.id.registerTextView);
        registerTextView.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                register();
            }
        });

        Button loginbtn = (Button) findViewById(R.id.loginbtn);
        loginbtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                dbRequest = new DBRequest(LoginActivity.this);
                String usuario = userEditText.getText().toString();
                String password = passwordEditText.getText().toString();
                if (userEditText.getText().toString().equals("admin") && passwordEditText.getText().toString().equals("test")) {
                    user = userEditText.getText().toString();
                    login();
                }
                else if(dbRequest.verificarUsuario(usuario,password)){
                    user = userEditText.getText().toString();
                    login();
                }
                else if(userEditText.getText ().toString().equals ("") ||  passwordEditText.getText().toString().equals ("")) {
                    Toast.makeText(LoginActivity.this, "Debe ingresar ambos datos", Toast.LENGTH_SHORT).show();
                }else {
                    Toast.makeText(LoginActivity.this, "Fallo de inicio de sesión, verifique los datos", Toast.LENGTH_SHORT).show();
                }
            }
        });

        ImageView logo = (ImageView) findViewById(R.id.logo);
        logo.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                DBHelper dataBase = new DBHelper(LoginActivity.this);
                SQLiteDatabase db = dataBase.getWritableDatabase();
                if (db != null) {
                    Toast.makeText(LoginActivity.this, "Base de datos creada", Toast.LENGTH_LONG).show();
                } else {
                    Toast.makeText(LoginActivity.this, "Error al crear base de datos", Toast.LENGTH_LONG).show();
                }
            }
        });
    }

    public void register() {
        Intent intent = new Intent(this, RegisterActivity.class);
        startActivity(intent);
    }

    public void login() {
        Intent intent = new Intent(this, MainActivity.class);
        intent.putExtra("user", user);
        startActivity(intent);
    }

}