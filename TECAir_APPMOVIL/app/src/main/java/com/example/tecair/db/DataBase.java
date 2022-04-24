package com.example.tecair.db;

import android.content.Context;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

import androidx.annotation.Nullable;

public class DataBase extends SQLiteOpenHelper{
    /**
     * Atributos de nombre y version de la base de datos
     */
    public static final String DATABASE = "TECAir";
    private static final int DATABASE_VERSION = 1;
    /**
     * Atributos para la creacion de tablas de la base de datos
     */
    //tabla usuario
    public static final String TABLE_USUARIO = "usuario";
    public static final String ID_USUARIO = "id_usuario";
    public static final String U_NOMBRE = "u_nombre";
    public static final String U_APELLIDO1 = "u_apellido1";
    public static final String U_APELLIDO2 = "u_apellido2";
    public static final String CORREO = "correo";
    public static final String U_CONTRASENA = "u_contrasena";
    public static final String TELEFONO = "telefono";

    // tabla estudiante
    public static final String TABLE_ESTUDIANTE = "estudiante";
    public static final String CARNE = "carne";
    public static final String UNIVERSIDAD = "universidad";
    public static final String E_ID_USUARIO = "id_usuario";


    //Tabla trabajador
    public static final String TABLE_TRABAJADOR = "trabajador";
    public static final String ID_TRABAJADOR = "id_trabajador";
    public static final String T_CONTRASENA = "t_contrasena";
    //Tabla avion
    public static final String TABLE_AVION = "avion";
    public static final String MATRICULA = "matricula";
    public static final String AV_NOMBRE = "av_nombre";
    public static final String CAPACIDAD = "capacidad";

    //Tabla vuelo
    public static final String TABLE_VUELO = "vuelo";
    public static final String NO_VUELO = "no_vuelo";
    public static final String ORIGEN = "origen";
    public static final String DESTINO = "destino";
    public static final String PRT_ABORDAJE = "prt_abordaje";
    public static final String H_SALIDA = "h_salida";
    public static final String H_LLEGADA = "h_llegada";
    public static final String V_DIA = "v_dia";
    public static final String V_MES = "v_mes";
    public static final String V_ANO = "v_ano";
    public static final String COSTE_VUELO = "coste_vuelo";
    public static final String V_MATRICULA = "matricula";
    public static final String CERRADO = "cerrado";

    //Tabla escala
    public static final String TABLE_ESCALA = "escala";
    public static final String NO_ESCALA = "no_escala";
    public static final String ESCALA = "escala";
    public static final String ORDEN = "orden";
    public static final String ESC_NO_VUELO = "no_vuelo";

    //Tabla asiento
    public static final String TABLE_ASIENTO = "asiento";
    public static final String NO_ASIENTO = "no_asiento";
    public static final String UBICACION = "ubicacion";
    public static final String A_NO_VUELO = "no_vuelo";

    //Tabla promocion
    public static final String TABLE_PROMOCION = "promocion";
    public static final String NO_PROMOCION = "no_promocion";
    public static final String PORCENTAJE = "porcentaje";
    public static final String PERIODO = "periodo";
    public static final String URL = "url";
    public static final String P_DIA = "p_dia";
    public static final String P_MES = "p_mes";
    public static final String P_ANO = "p_ano";
    public static final String P_NO_VUELO = "no_vuelo";

    //Tabla reservacion
    public static final String TABLE_RESERVACION = "reservacion";
    public static final String NO_RESERVACION = "no_reservacion";
    public static final String CANCELADO = "cancelado";
    public static final String R_NO_VUELO = "no_vuelo";
    public static final String R_IDUSUARIO = "id_usuario";
    public static final String R_IDTRABAJADOR = "id_trabajador";

    //Tabla tiquete
    public static final String TABLE_TIQUETE = "tiquete";
    public static final String NO_TRANSACCION = "no_transaccion";
    public static final String T_DIA = "t_dia";
    public static final String T_MES = "t_mes";
    public static final String T_ANO = "t_ano";
    public static final String ABORDAJE = "abordaje";
    public static final String T_NO_RESERVACION = "no_reservacion";
    public static final String T_NO_ASIENTO = "no_asiento";

    //Tabla pasajero
    public static final String TABLE_PASAJERO = "pasajero";
    public static final String DNI = "dni";
    public static final String P_NOMBRE = "p_nombre";
    public static final String P_APELLIDO1 = "p_apellido1";
    public static final String P_APELLIDO2 = "p_apellido2";
    public static final String CANT_MALETAS = "cant_maletas";
    public static final String CHEQUEADO = "chequeado";
    public static final String P_NO_TRANSACCION = "no_transaccion";

    //Tabla MALETA
    public static final String TABLE_MALETA = "maleta";
    public static final String NO_MALETA = "no_maleta";
    public static final String COLOR = "color";
    public static final String PESO = "peso";
    public static final String M_DNI = "dni";
    public static final String M_NO_VUELO = "no_vuelo";

    /**
     * Constructor de la clase
     * @param context contexto para la base de datos
     */
    public DataBase(@Nullable Context context) {
        super(context, DATABASE, null, DATABASE_VERSION);
    }

    /**
     * En esta funcion se crean las tablas a partir de los atributos definidos
     * @param sqLiteDatabase
     */
    @Override
    public void onCreate(SQLiteDatabase sqLiteDatabase) {
        /* ORDEN PARA CREAR LAS TABLAS
    -Usuario
    -Estudiante
    -Trabajador
    -Avion
    -Vuelo
    -Escala
    -Asiento
    -Promocion
    -Reservacion
    -Tiquete
    Pasajero
    Maleta
     */
        //Tabla Usuario
        sqLiteDatabase.execSQL("CREATE TABLE " + TABLE_USUARIO + "(" +
                ID_USUARIO + "id_usuario INTEGER PRIMARY KEY NOT NULL, " +
                U_NOMBRE + "u_nombre TEXT NOT NULL, " +
                U_APELLIDO1 + "u_apellido1 TEXT NOT NULL, " +
                U_APELLIDO2 + "u_apellido2 TEXT NOT NULL, " +
                CORREO + "correo TEXT NOT NULL, " +
                U_CONTRASENA + "u_contrasena TEXT NOT NULL, " +
                TELEFONO + "telefono TEXT NOT NULL)");
        //Tabla Estudiante
        sqLiteDatabase.execSQL("CREATE TABLE " + TABLE_ESTUDIANTE + "(" +
                CARNE + "carne INTEGER PRIMARY KEY NOT NULL, " +
                UNIVERSIDAD + "universidad TEXT NOT NULL, " +
                E_ID_USUARIO + "id_usuario INTEGER NOT NULL)");
        // tabla trabajador
        sqLiteDatabase.execSQL("CREATE TABLE " + TABLE_TRABAJADOR + "(" +
                ID_TRABAJADOR + "id_trabajador TEXT PRIMARY KEY NOT NULL, " +
                T_CONTRASENA + "t_contrasena TEXT NOT NULL)");
        //Tabla avion
        sqLiteDatabase.execSQL("CREATE TABLE " + TABLE_AVION + "(" +
                MATRICULA + "matricula TEXT PRIMARY KEY NOT NULL, " +
                AV_NOMBRE + "av_nombre TEXT NOT NULL, " +
                CAPACIDAD + "capacidad INTEGER NOT NULL)");
        //Tabla vuelo
        sqLiteDatabase.execSQL("CREATE TABLE " + TABLE_VUELO + "(" +
                NO_VUELO + "no_vuelo INTEGER PRIMARY KEY NOT NULL, " +
                ORIGEN + "origen TEXT NOT NULL, " +
                DESTINO + "destino TEXT NOT NULL, " +
                PRT_ABORDAJE + "prt_abordaje TEXT NOT NULL, " +
                H_SALIDA + "h_salida TEXT NOT NULL, " +
                H_LLEGADA + "h_llegada TEXT NOT NULL, " +
                V_DIA + "v_dia TEXT NOT NULL, " +
                V_MES + "v_mes TEXT NOT NULL, " +
                V_ANO + "v_ano TEXT NOT NULL, " +
                COSTE_VUELO + "coste_vuelo INTEGER NOT NULL, " +
                CERRADO + "cerrado INTEGER NOT NULL, " +
                "FOREIGN KEY("+V_MATRICULA+") REFERENCES "+TABLE_AVION+"("+MATRICULA+"))");
        //Tabla ESCALA
        sqLiteDatabase.execSQL("CREATE TABLE " + TABLE_ESCALA + "(" +
                NO_ESCALA + "no_escala INTEGER PRIMARY KEY NOT NULL, " +
                ESCALA + "escala TEXT NOT NULL, " +
                ORDEN + "orden INTEGER NOT NULL, " +
                "FOREIGN KEY("+ESC_NO_VUELO+") REFERENCES "+TABLE_VUELO+"("+NO_VUELO+"))");
        //Tabla asiento
        sqLiteDatabase.execSQL("CREATE TABLE " + TABLE_ASIENTO + "(" +
                NO_ASIENTO + "no_asiento INTEGER PRIMARY KEY NOT NULL, " +
                UBICACION + "ubicacion TEXT NOT NULL, " +
                "FOREIGN KEY("+A_NO_VUELO+") REFERENCES "+TABLE_VUELO+"("+NO_VUELO+"))");
        //Tabla promocion
        sqLiteDatabase.execSQL("CREATE TABLE " + TABLE_PROMOCION + "(" +
                NO_PROMOCION + "no_promocion INTEGER PRIMARY KEY NOT NULL, " +
                PORCENTAJE + "porcentaje INTEGER NOT NULL, " +
                PERIODO + "periodo INTEGER NOT NULL, " +
                URL + "url TEXT NOT NULL, " +
                P_DIA + "p_dia TEXT NOT NULL, " +
                P_MES + "p_mes TEXT NOT NULL, " +
                P_ANO + "p_ano TEXT NOT NULL, " +
                "FOREIGN KEY("+P_NO_VUELO+") REFERENCES "+TABLE_VUELO+"("+NO_VUELO+"))");
        // tabla reservacion
        sqLiteDatabase.execSQL("CREATE TABLE " + TABLE_RESERVACION + "(" +
                NO_RESERVACION + "no_reservacion INTEGER PRIMARY KEY NOT NULL, " +
                CANCELADO + "cancelado INTEGER NOT NULL, " +
                "FOREIGN KEY("+R_NO_VUELO+") REFERENCES "+TABLE_VUELO+"("+NO_VUELO+"), " +
                "FOREIGN KEY("+R_IDUSUARIO+") REFERENCES "+TABLE_USUARIO+"("+ID_USUARIO+"), " +
                "FOREIGN KEY("+R_IDTRABAJADOR+") REFERENCES "+TABLE_TRABAJADOR+"("+ID_TRABAJADOR+"))");
        // tabla tiquete
        sqLiteDatabase.execSQL("CREATE TABLE " + TABLE_TIQUETE + "(" +
                NO_TRANSACCION + "no_transaccion INTEGER PRIMARY KEY NOT NULL, " +
                T_DIA + "t_dia TEXT NOT NULL, " +
                T_MES + "t_mes TEXT NOT NULL, " +
                T_ANO + "t_ano TEXT NOT NULL, " +
                ABORDAJE + "abordaje INTEGER NOT NULL, " +
                "FOREIGN KEY("+T_NO_RESERVACION+") REFERENCES "+TABLE_RESERVACION+"("+NO_RESERVACION+"), " +
                "FOREIGN KEY("+T_NO_ASIENTO+") REFERENCES "+TABLE_ASIENTO+"("+NO_ASIENTO+"))");
        // tabla pasajero
        sqLiteDatabase.execSQL("CREATE TABLE " + TABLE_PASAJERO + "(" +
                DNI + "dni INTEGER PRIMARY KEY NOT NULL, " +
                P_NOMBRE + "p_nombre TEXT NOT NULL, " +
                P_APELLIDO1 + "p_apellido1 TEXT NOT NULL, " +
                P_APELLIDO2 + "p_apellido2 TEXT NOT NULL, " +
                CANT_MALETAS + "cant_maletas INTEGER NOT NULL, " +
                CHEQUEADO + "chequeado INTEGER NOT NULL, " +
                "FOREIGN KEY("+P_NO_TRANSACCION+") REFERENCES "+TABLE_TIQUETE+"("+NO_TRANSACCION+"))");
        //Tabla MALETA
        sqLiteDatabase.execSQL("CREATE TABLE " + TABLE_MALETA + "(" +
                NO_MALETA + "no_maleta INTEGER PRIMARY KEY NOT NULL, " +
                COLOR + "color TEXT NOT NULL, " +
                PESO + "peso INTEGER NOT NULL, " +
                "FOREIGN KEY("+M_DNI+") REFERENCES "+TABLE_PASAJERO+"("+DNI+"), " +
                "FOREIGN KEY("+M_NO_VUELO+") REFERENCES "+TABLE_VUELO+"("+NO_VUELO+"))");
    }

    @Override
    public void onUpgrade(SQLiteDatabase sqLiteDatabase, int i, int i1) {

    }

    //Solicitudes a la base de datos
}
