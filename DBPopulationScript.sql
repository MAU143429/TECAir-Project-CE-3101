-- INSERT INTO

-- Insertar usuarios en tabla Usuario
INSERT INTO usuario(id_usuario, u_nombre, u_apellido1, u_apellido2, correo, u_contrasena, telefono) 
VALUES(1487418, 'Jose', 'Campos', 'Gutierrez', 'jcampos@gmail.com', 'contrasena1', '89803806');

INSERT INTO usuario(id_usuario, u_nombre, u_apellido1, u_apellido2, correo, u_contrasena, telefono) 
VALUES(2597413, 'Cinthya', 'Gutierrez', 'Vargas', 'cinthya@yahoo.com', 'contrasena2', '83983371');

INSERT INTO usuario(id_usuario, u_nombre, u_apellido1, u_apellido2, correo, u_contrasena, telefono) 
VALUES(1376556, 'Ingrid', 'Ruiz', 'Madrigal', 'ingrid@gmail.com', 'contrasena3', '87090199');

INSERT INTO usuario(id_usuario, u_nombre, u_apellido1, u_apellido2, correo, u_contrasena, telefono) 
VALUES(2486520, 'Gabriel', 'Vargas', 'Lopez', 'gabo@gmail.com', 'contrasena4', '85962556');

INSERT INTO usuario(id_usuario, u_nombre, u_apellido1, u_apellido2, correo, u_contrasena, telefono) 
VALUES(1897025, 'Mauricio', 'Calderon', 'Chavarria', 'mau@gmail.com', 'contrasena5', '88770380');

-- Insertar usuarios que son estudiantes en tabla Estudiante
INSERT INTO estudiante(carne, universidad, id_usuario) 
VALUES(60136, 'Universidad de Costa Rica', 1376556);

INSERT INTO estudiante(carne, universidad, id_usuario) 
VALUES(2017000000, 'Tecnologico de Costa Rica', 2486520);

INSERT INTO estudiante(carne, universidad, id_usuario)
VALUES(2019000000, 'Tecnologico de Costa Rica', 1897025);

-- Insertar aviones
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

-- Insertar vuelos
INSERT INTO vuelo(no_vuelo, origen, destino, prt_abordaje, h_salida, h_llegada, v_dia, v_mes, v_ano, coste_vuelo, matricula)
VALUES(13568999, 'San José', 'Ciudad de México', 'G7', '11:50', '16:10', '30', '04', '2022', 1400,'737-100');

INSERT INTO vuelo(no_vuelo, origen, destino, prt_abordaje, h_salida, h_llegada, v_dia, v_mes, v_ano, coste_vuelo, matricula)
VALUES(298519, 'San José', 'Bogotá', 'G1', '14:45', '16:00', '05', '05', '2022', 213,'318-256');

INSERT INTO vuelo(no_vuelo, origen, destino, prt_abordaje, h_salida, h_llegada, v_dia, v_mes, v_ano, coste_vuelo, matricula)
VALUES(568999, 'San José', 'Rio de Janeiro', 'G9', '16:55', '06:15', '10', '08', '2022', 222,'737-800');

INSERT INTO vuelo(no_vuelo, origen, destino, prt_abordaje, h_salida, h_llegada, v_dia, v_mes, v_ano, coste_vuelo, matricula)
VALUES(85279, 'San José', 'Medellin', 'G5', '08:42', '01:01', '12', '07', '2022', 274,'737-100');

INSERT INTO vuelo(no_vuelo, origen, destino, prt_abordaje, h_salida, h_llegada, v_dia, v_mes, v_ano, coste_vuelo, matricula)
VALUES(21479, 'San José', 'Cairo', 'G19', '13:40', '18:40', '23', '11', '2022', 1687,'350-1000');

INSERT INTO vuelo(no_vuelo, origen, destino, prt_abordaje, h_salida, h_llegada, v_dia, v_mes, v_ano, coste_vuelo, matricula)
VALUES(798562, 'San José', 'Los Ángeles', 'G19', '01:00', '06:05', '01', '07', '2022', 714,'737-800');

INSERT INTO vuelo(no_vuelo, origen, destino, prt_abordaje, h_salida, h_llegada, v_dia, v_mes, v_ano, coste_vuelo, matricula)
VALUES(996479, 'Sao Paulo', 'New York', 'G19', '07:00', '21:23', '11', '11', '2022', 952,'319-444');

INSERT INTO vuelo(no_vuelo, origen, destino, prt_abordaje, h_salida, h_llegada, v_dia, v_mes, v_ano, coste_vuelo, matricula)
VALUES(569246, 'Madrid', 'Praga', 'G3', '15:15', '17:23', '08', '06', '2022', 150,'737-300');

INSERT INTO vuelo(no_vuelo, origen, destino, prt_abordaje, h_salida, h_llegada, v_dia, v_mes, v_ano, coste_vuelo, matricula)
VALUES(75803, 'Londres', 'Las Vegas', 'G15', '11:00', '15:20', '05', '07', '2022', 894,'319-444');

INSERT INTO vuelo(no_vuelo, origen, destino, prt_abordaje, h_salida, h_llegada, v_dia, v_mes, v_ano, coste_vuelo, matricula)
VALUES(8215896, 'Bruselas', 'Lisboa', 'G17', '16:00', '17:50', '13', '09', '2022', 99,'717-200');

INSERT INTO vuelo(no_vuelo, origen, destino, prt_abordaje, h_salida, h_llegada, v_dia, v_mes, v_ano, coste_vuelo, matricula)
VALUES(135214756, 'New York', 'Paris', 'G14', '21:00', '05:20', '06', '07', '2022', 916,'321-997');

-- Insertar Promocion
INSERT INTO promocion(no_promocion, porcentaje, periodo, url, p_dia, p_mes, p_ano, no_vuelo)
VALUES(1, 30, 20, 'url', 22, 04, 2022, 85279);

INSERT INTO promocion(no_promocion, porcentaje, periodo, url, p_dia, p_mes, p_ano, no_vuelo)
VALUES(2, 15, 30, 'url', 30, 05, 2022, 21479);

INSERT INTO promocion(no_promocion, porcentaje, periodo, url, p_dia, p_mes, p_ano, no_vuelo)
VALUES(3, 25, 35, 'url', 22, 04, 2022, 798562);

INSERT INTO promocion(no_promocion, porcentaje, periodo, url, p_dia, p_mes, p_ano, no_vuelo)
VALUES(4, 30, 15, 'url', 22, 04, 2022, 996479);

INSERT INTO promocion(no_promocion, porcentaje, periodo, url, p_dia, p_mes, p_ano, no_vuelo)
VALUES(5, 50, 20, 'url', 22, 04, 2022, 569246);

INSERT INTO promocion(no_promocion, porcentaje, periodo, url, p_dia, p_mes, p_ano, no_vuelo)
VALUES(6, 35, 25, 'url', 22, 04, 2022, 75803);

INSERT INTO promocion(no_promocion, porcentaje, periodo, url, p_dia, p_mes, p_ano, no_vuelo)
VALUES(7, 20, 25, 'url', 22, 04, 2022, 8215896);

-- Insertar Reservacion:

INSERT INTO reservacion(no_reservacion, cancelado, no_vuelo, id_usuario, id_trabajador)
VALUES(17759, true, 85279, 1487418, NULL);

INSERT INTO reservacion(no_reservacion, cancelado, no_vuelo, id_usuario, id_trabajador)
VALUES(74859, false, 13568999, 2597413, NULL);

INSERT INTO reservacion(no_reservacion, cancelado, no_vuelo, id_usuario, id_trabajador)
VALUES(32584, true, 135214756, 1376556, NULL);

INSERT INTO reservacion(no_reservacion, cancelado, no_vuelo, id_usuario, id_trabajador)
VALUES(22568, true, 568999, 2486520, NULL);

INSERT INTO reservacion(no_reservacion, cancelado, no_vuelo, id_usuario, id_trabajador)
VALUES(23563, true, 798562, 1897025, NULL);

-- Insertar Tiquete:
INSERT INTO tiquete(no_transaccion, t_dia, t_mes, t_ano, abordaje, no_reservacion, no_asiento, dni)
VALUES(278788, 20, 11, 2021, false, 32584, 5, 116558830);

INSERT INTO tiquete(no_transaccion, t_dia, t_mes, t_ano, abordaje, no_reservacion, no_asiento, dni)
VALUES(758866, 22, 01, 2022, false, 22568, 10, 117486602);

INSERT INTO tiquete(no_transaccion, t_dia, t_mes, t_ano, abordaje, no_reservacion, no_asiento, dni)
VALUES(325568, 10, 02, 2022, false, 23563, 25, 105690475);

INSERT INTO tiquete(no_transaccion, t_dia, t_mes, t_ano, abordaje, no_reservacion, no_asiento, dni)
VALUES(201458, 25, 12, 2021, false, 17759, 7, 102350478);

-- Insertar Pasajero:
INSERT INTO pasajero(dni, p_nombre, p_apellido1, p_apellido2, cant_maletas, chequeado, no_transaccion)
VALUES(116558830, 'Ingrid', 'Ruiz', 'Madrigal', 2, 278788);

INSERT INTO pasajero(dni, p_nombre, p_apellido1, p_apellido2, cant_maletas, chequeado, no_transaccion)
VALUES(117486602, 'Gabriel', 'Vargas', 'Lopez', 1, 758866);

INSERT INTO pasajero(dni, p_nombre, p_apellido1, p_apellido2, cant_maletas, chequeado, no_transaccion)
VALUES(105690475, 'Mauricio', 'Calderon', 'Chavarria', 2, 325568);

INSERT INTO pasajero(dni, p_nombre, p_apellido1, p_apellido2, cant_maletas, chequeado, no_transaccion)
VALUES(102350478, 'Jose', 'Campos', 'Gutierrez', 1, 201458);

-- Insertar Maleta
INSERT INTO maleta(no_maleta, color, peso, dni, no_vuelo)
VALUES(12486, 'negro', 20, 116558830, 135214756);

INSERT INTO maleta(no_maleta, color, peso, dni, no_vuelo)
VALUES(23569, 'gris', 13, 116558830, 135214756);

INSERT INTO maleta(no_maleta, color, peso, dni, no_vuelo)
VALUES(58676, 'azul', 18, 117486602, 568999);

INSERT INTO maleta(no_maleta, color, peso, dni, no_vuelo)
VALUES(48546, 'negro', 20, 105690475, 798562);

INSERT INTO maleta(no_maleta, color, peso, dni, no_vuelo)
VALUES(25789, 'rojo', 17, 105690475, 798562);

INSERT INTO maleta(no_maleta, color, peso, dni, no_vuelo)
VALUES(12153, 'morado', 14, 102350478, 85279);