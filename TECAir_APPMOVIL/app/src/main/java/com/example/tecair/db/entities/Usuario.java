package com.example.tecair.db.entities;

public class Usuario {
    private int id_usuario;
    private String u_nombre;
    private String u_apellido1;
    private String u_apellido2;
    private String correo;
    private String u_contrasena;
    private int telefono;

    public int getId_usuario() {
        return id_usuario;
    }

    public void setId_usuario(int id_usuario) {
        this.id_usuario = id_usuario;
    }

    public String getU_nombre() {
        return u_nombre;
    }

    public void setU_nombre(String u_nombre) {
        this.u_nombre = u_nombre;
    }

    public String getU_apellido1() {
        return u_apellido1;
    }

    public void setU_apellido1(String u_apellido1) {
        this.u_apellido1 = u_apellido1;
    }

    public String getU_apellido2() {
        return u_apellido2;
    }

    public void setU_apellido2(String u_apellido2) {
        this.u_apellido2 = u_apellido2;
    }

    public String getCorreo() {
        return correo;
    }

    public void setCorreo(String correo) {
        this.correo = correo;
    }

    public String getU_contrasena() {
        return u_contrasena;
    }

    public void setU_contrasena(String u_contrasena) {
        this.u_contrasena = u_contrasena;
    }

    public int getTelefono() {
        return telefono;
    }

    public void setTelefono(int telefono) {
        this.telefono = telefono;
    }
}
