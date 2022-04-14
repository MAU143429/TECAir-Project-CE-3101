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
INSERT INTO Vuelo(no_vuelo, origen, destino, prt_abordaje, h_salida, h_llegada, v_dia, v_mes, v_ano, coste_vuelo, matricula)
VALUES(13568999, 'San José', 'Ciudad de México', 'G7', '11:50', '16:10', '30', '04', '2022', 1400,'737-100');

INSERT INTO Vuelo(no_vuelo, origen, destino, prt_abordaje, h_salida, h_llegada, v_dia, v_mes, v_ano, coste_vuelo, matricula)
VALUES(298519, 'San José', 'Bogotá', 'G1', '14:45', '16:00', '05', '05', '2022', 213,'318-256');

INSERT INTO Vuelo(no_vuelo, origen, destino, prt_abordaje, h_salida, h_llegada, v_dia, v_mes, v_ano, coste_vuelo, matricula)
VALUES(568999, 'San José', 'Rio de Janeiro', 'G9', '16:55', '06:15', '10', '08', '2022', 222,'737-800');

INSERT INTO Vuelo(no_vuelo, origen, destino, prt_abordaje, h_salida, h_llegada, v_dia, v_mes, v_ano, coste_vuelo, matricula)
VALUES(98521479, 'San José', 'Medellin', 'G5', '08:42', '01:01', '12', '07', '2022', 274,'737-100');

INSERT INTO Vuelo(no_vuelo, origen, destino, prt_abordaje, h_salida, h_llegada, v_dia, v_mes, v_ano, coste_vuelo, matricula)
VALUES(98521479, 'San José', 'Cairo', 'G19', '13:40', '18:40', '23', '11', '2022', 1687,'350-1000');

INSERT INTO Vuelo(no_vuelo, origen, destino, prt_abordaje, h_salida, h_llegada, v_dia, v_mes, v_ano, coste_vuelo, matricula)
VALUES(98521479, 'San José', 'Los Ángeles', 'G19', '01:00', '06:05', '01', '07', '2022', 714,'737-800');

INSERT INTO Vuelo(no_vuelo, origen, destino, prt_abordaje, h_salida, h_llegada, v_dia, v_mes, v_ano, coste_vuelo, matricula)
VALUES(98521479, 'Sao Paulo', 'New York', 'G19', '07:00', '21:23', '11', '11', '2022', 952,'319-444');

INSERT INTO Vuelo(no_vuelo, origen, destino, prt_abordaje, h_salida, h_llegada, v_dia, v_mes, v_ano, coste_vuelo, matricula)
VALUES(98521479, 'Madrid', 'Praga', 'G3', '15:15', '17:23', '08', '06', '2022', 150,'737-300');

INSERT INTO Vuelo(no_vuelo, origen, destino, prt_abordaje, h_salida, h_llegada, v_dia, v_mes, v_ano, coste_vuelo, matricula)
VALUES(98521479, 'Londres', 'Las Vegas', 'G15', '11:00', '15:20', '05', '07', '2022', 894,'319-444');

INSERT INTO Vuelo(no_vuelo, origen, destino, prt_abordaje, h_salida, h_llegada, v_dia, v_mes, v_ano, coste_vuelo, matricula)
VALUES(98521479, 'Bruselas', 'Lisboa', 'G17', '16:00', '17:50', '13', '09', '2022', 99,'717-200');

-- Insertar Promocion
-- Insertar Reservacion: 5 (castri)
-- Insertar Tiquete: 3 (yen)
-- Insertar Pasajero: 3 (yen)
-- Insertar Maleta: 6, 1 pasajero 1, 1 pasajero 2, 1 pasajero 3 (castri)