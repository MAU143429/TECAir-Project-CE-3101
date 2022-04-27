package com.example.tecair.db.entities;

public class Usuario {
    private int id_usuario;
    private int u_nombre;
    private int u_apellido1;
    private int u_apellido2;
    private int correo;
    private int u_contrasena;
    private int telefono;

    public int getId_usuario() {
        return id_usuario;
    }

    public void setId_usuario(int id_usuario) {
        this.id_usuario = id_usuario;
    }

    public int getU_nombre() {
        return u_nombre;
    }

    public void setU_nombre(int u_nombre) {
        this.u_nombre = u_nombre;
    }

    public int getU_apellido1() {
        return u_apellido1;
    }

    public void setU_apellido1(int u_apellido1) {
        this.u_apellido1 = u_apellido1;
    }

    public int getU_apellido2() {
        return u_apellido2;
    }

    public void setU_apellido2(int u_apellido2) {
        this.u_apellido2 = u_apellido2;
    }

    public int getCorreo() {
        return correo;
    }

    public void setCorreo(int correo) {
        this.correo = correo;
    }

    public int getU_contrasena() {
        return u_contrasena;
    }

    public void setU_contrasena(int u_contrasena) {
        this.u_contrasena = u_contrasena;
    }

    public int getTelefono() {
        return telefono;
    }

    public void setTelefono(int telefono) {
        this.telefono = telefono;
    }
}
