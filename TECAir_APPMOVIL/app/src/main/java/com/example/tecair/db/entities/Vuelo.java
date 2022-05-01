package com.example.tecair.db.entities;

/**
 * Modelo de Vuelo para almacenar los valores obtenidos de la base de datos
 */
public class Vuelo {
    private int no_vuelo;
    private int origen;
    private int destino;
    private int prt_abordaje;
    private int h_salida;
    private int h_llegada;
    private int v_dia;
    private int v_mes;
    private int v_ano;
    private int coste_vuelo;
    private int matricula;

    public int getNo_vuelo() {
        return no_vuelo;
    }

    public void setNo_vuelo(int no_vuelo) {
        this.no_vuelo = no_vuelo;
    }

    public int getOrigen() {
        return origen;
    }

    public void setOrigen(int origen) {
        this.origen = origen;
    }

    public int getDestino() {
        return destino;
    }

    public void setDestino(int destino) {
        this.destino = destino;
    }

    public int getPrt_abordaje() {
        return prt_abordaje;
    }

    public void setPrt_abordaje(int prt_abordaje) {
        this.prt_abordaje = prt_abordaje;
    }

    public int getH_salida() {
        return h_salida;
    }

    public void setH_salida(int h_salida) {
        this.h_salida = h_salida;
    }

    public int getH_llegada() {
        return h_llegada;
    }

    public void setH_llegada(int h_llegada) {
        this.h_llegada = h_llegada;
    }

    public int getV_dia() {
        return v_dia;
    }

    public void setV_dia(int v_dia) {
        this.v_dia = v_dia;
    }

    public int getV_mes() {
        return v_mes;
    }

    public void setV_mes(int v_mes) {
        this.v_mes = v_mes;
    }

    public int getV_ano() {
        return v_ano;
    }

    public void setV_ano(int v_ano) {
        this.v_ano = v_ano;
    }

    public int getCoste_vuelo() {
        return coste_vuelo;
    }

    public void setCoste_vuelo(int coste_vuelo) {
        this.coste_vuelo = coste_vuelo;
    }

    public int getMatricula() {
        return matricula;
    }

    public void setMatricula(int matricula) {
        this.matricula = matricula;
    }
}
