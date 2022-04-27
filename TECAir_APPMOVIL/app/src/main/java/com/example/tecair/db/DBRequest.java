package com.example.tecair.db;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;

import androidx.annotation.Nullable;

import com.example.tecair.db.entities.Usuario;

public class DBRequest extends DBHelper{
    Context context;

    public DBRequest(@Nullable Context context) {
        super(context);
        this.context = context;
    }

    /**
     * Obtiene un usuario de la tabla, seleccionando por el correo
     * @return true o false, dependiendo de si coincide la contrasena y correo del usuario
     */
    public boolean verificarUsuario(String uCorreo, String uContrasena){
        // Se lee la base de datos
        DBHelper dbHelper = new DBHelper(context);
        SQLiteDatabase db = dbHelper.getWritableDatabase();

        // Se crea una instancia del modelo de Usuario
        Usuario usuario = new Usuario();
        // Se crea una instancia de cursor, ya que es lo que devuelve la consulta a la base
        Cursor cursorUsuario = null;

        //----Consulta a la base de datos---//
        // Columnas que se van a seleccionar
        String fromColumns[] = {CORREO, U_CONTRASENA};
        cursorUsuario = db.rawQuery("SELECT " + fromColumns + " FROM " + TABLE_USUARIO
                + " WHERE correo = " + uCorreo + " AND contrasena = " + uContrasena, null);
        if(cursorUsuario != null){
            return true;
        }
        else{
            return false;
        }
    }

    //bases de datos movil:
    // tabla usuario:
        // insertar usuario
        // buscar usuario por correo
        // buscar usuario por contrasena
        // enviar datos del registro a tabla de usuario, cuando me hagan un registro
        // tengo que generar un id_usuario automatico

        // obtener datos de un usuario para el login

    // tabla vuelo:
        // insertar vuelo
        // obtener datos de vuelo para mostrar en la seccion de elegir vuelo


    //- tabla reservacion:
        // Cuando elijo un vuelo y le doy reservar, tengo que ir a guardar a la tabla:
        // un id reservacion que quiero agregar automatico, cancelado en false, obtener id_usuario
        // de la tabla de usuario y un numero de vuelo que obtengo de tabla vuelo
        // esta reservacion hay que agregarla en el carrito
        // tal vez se podria poner un toast que diga que se agrego al carrito y que lo mande a
        // main activity, en vez de que lo lleve a meter los datos de pasajero de una vez.

        // La otra opcion es que cuando le de reservar vaya a guardar los datos a la tabla reservacion,
        // lo mande a poner los datos de pasajero y pago y que guarde esos datos en la tabla pasajero,
        // genere numero de transaccion para la tabla tiquete y guarde lo que ocupe esa tabla tiquete.
        // con esta opcion, se eliminaria el carrito, o se le podria cambiar a que sea una seccion donde
        // pueda ver los vuelos comprados.

    //- promociones:
        // obtener datos de tabla promocion para mostrar en la seccion de promos

        // Cuando elijo una promo y le doy reservar, tengo que ir a guardar a la tabla:
        // un id reservacion que quiero agregar automatico, cancelado en false, obtener id_usuario
        // de la tabla de usuario y un numero de vuelo que obtengo de tabla vuelo
        // esta reservacion de promo hay que agregarla en el carrito
        // tal vez se podria poner un toast que diga que se agrego al carrito
        // aqui tambien se podria aplicar la segunda opcion que escribi arriba.

    //- tabla pasajero:
        // en el carrito tiene que haber opcion de pagar una reservacion o tocarla y que
        // lo lleve a la seccion de poner los datos del pasajero e info de pago y agregar
        // los datos del pasajero a la tabla
        // y tabla tiquete:
        // cuando se hace el pago, se debe generar solo un numero de transaccion y meter a la tabla
        // los datos
}
