package com.example.tecair.db.entities;

/**
 * Modelo de Vuelo para almacenar los valores obtenidos de la base de datos
 */
public class Vuelo {
    private int no_vuelo;
    private String origen;
    private String destino;
    private String prt_abordaje;
    private String h_salida;
    private String h_llegada;
    private String v_dia;
    private String v_mes;
    private String v_ano;
    private int coste_vuelo;
    private int matricula;

    public int getNo_vuelo() {
        return no_vuelo;
    }

    public void setNo_vuelo(int no_vuelo) {
        this.no_vuelo = no_vuelo;
    }

    public String getOrigen() {
        return origen;
    }

    public void setOrigen(String origen) {
        this.origen = origen;
    }

    public String getDestino() {
        return destino;
    }

    public void setDestino(String destino) {
        this.destino = destino;
    }

    public String getPrt_abordaje() {
        return prt_abordaje;
    }

    public void setPrt_abordaje(String prt_abordaje) {
        this.prt_abordaje = prt_abordaje;
    }

    public String getH_salida() {
        return h_salida;
    }

    public void setH_salida(String h_salida) {
        this.h_salida = h_salida;
    }

    public String getH_llegada() {
        return h_llegada;
    }

    public void setH_llegada(String h_llegada) {
        this.h_llegada = h_llegada;
    }

    public String getV_dia() {
        return v_dia;
    }

    public void setV_dia(String v_dia) {
        this.v_dia = v_dia;
    }

    public String getV_mes() {
        return v_mes;
    }

    public void setV_mes(String v_mes) {
        this.v_mes = v_mes;
    }

    public String getV_ano() {
        return v_ano;
    }

    public void setV_ano(String v_ano) {
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
