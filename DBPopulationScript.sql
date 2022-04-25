-- Usuarios
INSERT INTO usuario(id_usuario, u_nombre, u_apellido1, u_apellido2, correo, u_contrasena, telefono) 
VALUES(1, 'Jose', 'Campos', 'Gutierrez', 'jcampos@gmail.com', 'contrasena1', '89803806');

INSERT INTO usuario(id_usuario, u_nombre, u_apellido1, u_apellido2, correo, u_contrasena, telefono) 
VALUES(2, 'Cinthya', 'Gutierrez', 'Vargas', 'cinthya@yahoo.com', 'contrasena2', '83983371');

INSERT INTO usuario(id_usuario, u_nombre, u_apellido1, u_apellido2, correo, u_contrasena, telefono) 
VALUES(3, 'Ingrid', 'Ruiz', 'Madrigal', 'ingrid@gmail.com', 'contrasena3', '87090199');

INSERT INTO usuario(id_usuario, u_nombre, u_apellido1, u_apellido2, correo, u_contrasena, telefono) 
VALUES(4, 'Gabriel', 'Vargas', 'Lopez', 'gabo@gmail.com', 'contrasena4', '85962556');

INSERT INTO usuario(id_usuario, u_nombre, u_apellido1, u_apellido2, correo, u_contrasena, telefono) 
VALUES(5, 'Mauricio', 'Calderon', 'Chavarria', 'mau@gmail.com', 'contrasena5', '88770380');

INSERT INTO usuario(id_usuario, u_nombre, u_apellido1, u_apellido2, correo, u_contrasena, telefono) 
VALUES(6, 'Mario', 'Solano', 'Salazar', 'msolano@gmail.com', 'contrasena6', '86304896');

INSERT INTO usuario(id_usuario, u_nombre, u_apellido1, u_apellido2, correo, u_contrasena, telefono) 
VALUES(7, 'Alexandra', 'Lopez', 'Segura', 'alelopez@yahoo.com', 'contrasena7', '88029355');

INSERT INTO usuario(id_usuario, u_nombre, u_apellido1, u_apellido2, correo, u_contrasena, telefono) 
VALUES(8, 'Natalia', 'Cruz', 'Ruiz', 'natycr@gmail.com', 'contrasena8', '60168842');



-- Estudiantes
INSERT INTO estudiante(carne, universidad, id_usuario) 
VALUES(1, 'TEC', 1);

INSERT INTO estudiante(carne, universidad, id_usuario) 
VALUES(2, 'UCR', 2);

INSERT INTO estudiante(carne, universidad, id_usuario) 
VALUES(3, 'UTN', 5);

INSERT INTO estudiante(carne, universidad, id_usuario) 
VALUES(4, 'UNA', 8);



-- Trabajadores
INSERT INTO trabajador(id_trabajador, t_contrasena)
VALUES('admin','admin');

INSERT INTO trabajador(id_trabajador, t_contrasena)
VALUES('mrivera','mrivera');

INSERT INTO trabajador(id_trabajador, t_contrasena)
VALUES('trabajador','contrasena');



-- Aviones
INSERT INTO avion(matricula, av_nombre, capacidad) 
VALUES('737-300', 'Boeing 737', 140);

INSERT INTO avion(matricula, av_nombre, capacidad) 
VALUES('717-200', 'Boeing 717', 140);

INSERT INTO avion(matricula, av_nombre, capacidad) 
VALUES('737-100', 'Boeing 737', 124);

INSERT INTO avion(matricula, av_nombre, capacidad) 
VALUES('318-256', 'Airbus A318', 132);

INSERT INTO avion(matricula, av_nombre, capacidad) 
VALUES('319-444', 'Airbus A319 Neo', 156);

INSERT INTO avion(matricula, av_nombre, capacidad) 
VALUES('737-800', 'Boeing 737', 184);

INSERT INTO avion(matricula, av_nombre, capacidad) 
VALUES('321-997', 'Airbus A321', 236);

INSERT INTO avion(matricula, av_nombre, capacidad) 
VALUES('787-987', 'Boeing 787-9 Dreamliner', 300);

INSERT INTO avion(matricula, av_nombre, capacidad) 
VALUES('350-1000', 'Airbus A350', 356);



-- Vuelos
INSERT INTO vuelo(no_vuelo, origen, destino, prt_abordaje, h_salida, h_llegada, v_dia, v_mes, v_ano, coste_vuelo, matricula)
VALUES(1, 'Juan Santamaria Intl', 'Licenciado Benito Juarez Intl', 'G7', '11:50', '16:10', '30', '04', '2022', 1400,'737-100');

INSERT INTO vuelo(no_vuelo, origen, destino, prt_abordaje, h_salida, h_llegada, v_dia, v_mes, v_ano, coste_vuelo, matricula)
VALUES(2, 'Juan Santamaria Intl', 'Eldorado Intl', 'G1', '14:45', '16:00', '05', '05', '2022', 213,'318-256');

INSERT INTO vuelo(no_vuelo, origen, destino, prt_abordaje, h_salida, h_llegada, v_dia, v_mes, v_ano, coste_vuelo, matricula)
VALUES(3, 'Juan Santamaria Intl', 'Galeao Antonio Carlos Jobim', 'G9', '16:55', '06:15', '10', '08', '2022', 222,'737-800');

INSERT INTO vuelo(no_vuelo, origen, destino, prt_abordaje, h_salida, h_llegada, v_dia, v_mes, v_ano, coste_vuelo, matricula)
VALUES(4, 'Juan Santamaria Intl', 'John F Kennedy Intl', 'G5', '08:42', '01:01', '12', '07', '2022', 274,'737-100');

INSERT INTO vuelo(no_vuelo, origen, destino, prt_abordaje, h_salida, h_llegada, v_dia, v_mes, v_ano, coste_vuelo, matricula)
VALUES(5, 'Juan Santamaria Intl', 'Franz Josef Strauss', 'G19', '13:40', '18:40', '23', '11', '2022', 500,'350-1000');

INSERT INTO vuelo(no_vuelo, origen, destino, prt_abordaje, h_salida, h_llegada, v_dia, v_mes, v_ano, coste_vuelo, matricula)
VALUES(6, 'Juan Santamaria Intl', 'Mc Carran Intl', 'G19', '01:00', '06:05', '01', '07', '2022', 714,'737-800');

INSERT INTO vuelo(no_vuelo, origen, destino, prt_abordaje, h_salida, h_llegada, v_dia, v_mes, v_ano, coste_vuelo, matricula)
VALUES(7, 'Congonhas', 'Brussels Natl', 'G19', '07:00', '21:23', '11', '11', '2022', 952,'319-444');

INSERT INTO vuelo(no_vuelo, origen, destino, prt_abordaje, h_salida, h_llegada, v_dia, v_mes, v_ano, coste_vuelo, matricula)
VALUES(8, 'Barajas', 'Ruzyne', 'G3', '15:15', '17:23', '08', '06', '2022', 150,'737-300');

INSERT INTO vuelo(no_vuelo, origen, destino, prt_abordaje, h_salida, h_llegada, v_dia, v_mes, v_ano, coste_vuelo, matricula)
VALUES(9, 'Gatwick', 'Mc Carran Intl', 'G15', '11:00', '15:20', '05', '07', '2022', 894,'319-444');

INSERT INTO vuelo(no_vuelo, origen, destino, prt_abordaje, h_salida, h_llegada, v_dia, v_mes, v_ano, coste_vuelo, matricula)
VALUES(10, 'Brussels Natl', 'Lisboa', 'G17', '16:00', '17:50', '13', '09', '2022', 99,'717-200');

INSERT INTO vuelo(no_vuelo, origen, destino, prt_abordaje, h_salida, h_llegada, v_dia, v_mes, v_ano, coste_vuelo, matricula)
VALUES(11, 'John F Kennedy Intl', 'Charles De Gaulle', 'G14', '21:00', '05:20', '06', '07', '2022', 916,'321-997');

INSERT INTO vuelo(no_vuelo, origen, destino, prt_abordaje, h_salida, h_llegada, v_dia, v_mes, v_ano, coste_vuelo, matricula)
VALUES(12, 'Miami Intl', 'Juan Santamaria Intl', 'A3', '06:20', '08:50', '23', '04', '2022', 700,'321-997');



-- Promociones
INSERT INTO promocion(no_promocion, porcentaje, periodo, url, p_dia, p_mes, p_ano, no_vuelo)
VALUES(1, 30, 14, 'https://elviajista.com/wp-content/uploads/2021/04/alojarseenpraga-730x487.jpg', '08', '06', '2022', 8);

INSERT INTO promocion(no_promocion, porcentaje, periodo, url, p_dia, p_mes, p_ano, no_vuelo)
VALUES(2, 10, 7, 'https://estaticos.muyinteresante.es/uploads/images/test/60b4a8d15cafe819e843397a/empire-state-redes.jpg', '12', '07', '2022', 4);

INSERT INTO promocion(no_promocion, porcentaje, periodo, url, p_dia, p_mes, p_ano, no_vuelo)
VALUES(3, 15, 14, 'https://rvca738f6h5tbwmj3mxylox3-wpengine.netdna-ssl.com/es/wp-content/uploads/sites/2/2021/11/Mexico-City-GI-1064279806.jpg', '30', '04', '2022', 1);

INSERT INTO promocion(no_promocion, porcentaje, periodo, url, p_dia, p_mes, p_ano, no_vuelo)
VALUES(4, 20, 7, 'https://cdn.getyourguide.com/img/location/5e6a1a4570c88.jpeg/99.jpg', '23', '04', '2022', 12);

INSERT INTO promocion(no_promocion, porcentaje, periodo, url, p_dia, p_mes, p_ano, no_vuelo)
VALUES(5, 25, 14, 'https://la.network/wp-content/uploads/2021/07/Emprendimientos-en-Bogota%CC%81.jpg', '05', '05', '2022', 2);

INSERT INTO promocion(no_promocion, porcentaje, periodo, url, p_dia, p_mes, p_ano, no_vuelo)
VALUES(6, 10, 7, 'https://www.avianca.com/content/dam/avianca_new/destinos/semana/gig/1-porque-visitarla/destino-rio-de-janeiro-brazil-para-conocer-el-cerro-del-corcovado.jpg', '10', '08', '2022', 3);

INSERT INTO promocion(no_promocion, porcentaje, periodo, url, p_dia, p_mes, p_ano, no_vuelo)
VALUES(7, 30, 14, 'https://cdn2.civitatis.com/portugal/lisboa/guia/lisboa-card-m.jpg', '13', '09', '2022', 10);

INSERT INTO promocion(no_promocion, porcentaje, periodo, url, p_dia, p_mes, p_ano, no_vuelo)
VALUES(8, 10, 7, 'https://www.eluniversal.com.mx/sites/default/files/2019/10/11/bruselas-grand-place_22.jpg', '11', '11', '2022', 7);



-- Escalas
INSERT INTO escala(no_escala, escala, orden, no_vuelo) 
VALUES(1, 'Tocumen Intl', 1, 1);

INSERT INTO escala(no_escala, escala, orden, no_vuelo) 
VALUES(2, 'Tocumen Intl', 1, 2);

INSERT INTO escala(no_escala, escala, orden, no_vuelo) 
VALUES(3, 'Licenciado Benito Juarez Intl', 2, 2);

INSERT INTO escala(no_escala, escala, orden, no_vuelo) 
VALUES(4, 'Jose Maria Cordova', 3, 2);

INSERT INTO escala(no_escala, escala, orden, no_vuelo) 
VALUES(5, 'Jose Maria Cordova', 1, 12);



-- Reservaciones
INSERT INTO reservacion(no_reservacion, cancelado, no_vuelo, id_usuario, id_trabajador)
VALUES(1, false, 2, 1, NULL);

INSERT INTO reservacion(no_reservacion, cancelado, no_vuelo, id_usuario, id_trabajador)
VALUES(2, true, 11, 1, NULL);

INSERT INTO reservacion(no_reservacion, cancelado, no_vuelo, id_usuario, id_trabajador)
VALUES(3, false, 6, NULL, 'admin');

INSERT INTO reservacion(no_reservacion, cancelado, no_vuelo, id_usuario, id_trabajador)
VALUES(4, true, 7, NULL, 'mrivera');

INSERT INTO reservacion(no_reservacion, cancelado, no_vuelo, id_usuario, id_trabajador)
VALUES(5, false, 12, 2, NULL);

INSERT INTO reservacion(no_reservacion, cancelado, no_vuelo, id_usuario, id_trabajador)
VALUES(6, true, 8, 5, NULL);

INSERT INTO reservacion(no_reservacion, cancelado, no_vuelo, id_usuario, id_trabajador)
VALUES(7, false, 1, NULL, 'trabajador');

INSERT INTO reservacion(no_reservacion, cancelado, no_vuelo, id_usuario, id_trabajador)
VALUES(8, false, 2, NULL, 'mrivera');



-- Asientos
INSERT INTO public.asiento(no_asiento, no_vuelo, ubicacion)
VALUES(0, 11, 'F5');



-- Tiquete
INSERT INTO tiquete(no_transaccion, t_dia, t_mes, t_ano, abordaje, no_reservacion, no_asiento)
VALUES(1, '06', '07', '2022', false, 2, 0);

INSERT INTO tiquete(no_transaccion, t_dia, t_mes, t_ano, abordaje, no_reservacion, no_asiento)
VALUES(2, '12', '07', '2022', false, 4, 0);

INSERT INTO tiquete(no_transaccion, t_dia, t_mes, t_ano, abordaje, no_reservacion, no_asiento)
VALUES(3, '01', '07', '2022', false, 6, 0);



-- Pasajeros
INSERT INTO pasajero(dni, p_nombre, p_apellido1, p_apellido2, cant_maletas, chequeado, no_transaccion)
VALUES(116558830, 'Ingrid', 'Ruiz', 'Madrigal', 2, false, 1);

INSERT INTO pasajero(dni, p_nombre, p_apellido1, p_apellido2, cant_maletas, chequeado, no_transaccion)
VALUES(117486602, 'Gabriel', 'Vargas', 'Lopez', 1, false, 2);

INSERT INTO pasajero(dni, p_nombre, p_apellido1, p_apellido2, cant_maletas, chequeado, no_transaccion)
VALUES(105690475, 'Mauricio', 'Calderon', 'Chavarria', 2, false, 3);


-- Maletas
INSERT INTO maleta(no_maleta, color, peso, dni, no_vuelo)
VALUES(1, 'negro', 20, 116558830, 11);

INSERT INTO maleta(no_maleta, color, peso, dni, no_vuelo)
VALUES(2, 'rosado', 12, 116558830, 11);

INSERT INTO maleta(no_maleta, color, peso, dni, no_vuelo)
VALUES(3, 'verde', 16, 117486602, 7);

INSERT INTO maleta(no_maleta, color, peso, dni, no_vuelo)
VALUES(4, 'azul', 22, 105690475, 8);

INSERT INTO maleta(no_maleta, color, peso, dni, no_vuelo)
VALUES(5, 'verde', 10, 105690475, 8);