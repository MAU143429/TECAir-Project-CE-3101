-- INSERT INTO

-- Insertar usuarios en tabla Usuario
INSERT INTO Usuario(id_usuario, u_nombre, u_apellido1, u_apellido2, correo, u_contrasena, telefono) 
VALUES(1487418, 'Jose', 'Campos', 'Gutierrez', 'jcampos@gmail.com', 'contrasena1', '89803806');

INSERT INTO Usuario(id_usuario, u_nombre, u_apellido1, u_apellido2, correo, u_contrasena, telefono) 
VALUES(2597413, 'Cinthya', 'Gutierrez', 'Vargas', 'cinthya@yahoo.com', 'contrasena2', '83983371');

INSERT INTO Usuario(id_usuario, u_nombre, u_apellido1, u_apellido2, correo, u_contrasena, telefono) 
VALUES(1376556, 'Ingrid', 'Ruiz', 'Madrigal', 'ingrid@gmail.com', 'contrasena3', '87090199');

INSERT INTO Usuario(id_usuario, u_nombre, u_apellido1, u_apellido2, correo, u_contrasena, telefono) 
VALUES(2486520, 'Gabriel', 'Vargas', 'Lopez', 'gabo@gmail.com', 'contrasena4', '85962556');

INSERT INTO Usuario(id_usuario, u_nombre, u_apellido1, u_apellido2, correo, u_contrasena, telefono) 
VALUES(1897025, 'Mauricio', 'Calderon', 'Chavarria', 'mau@gmail.com', 'contrasena5', '88770380');

-- Insertar usuarios que son estudiantes en tabla Estudiante
INSERT INTO Estudiante(carne, universidad, id_usuario) 
VALUES(60136, 'Universidad de Costa Rica', 1376556);

INSERT INTO Estudiante(carne, universidad, id_usuario) 
VALUES(2017000000, 'Tecnologico de Costa Rica', 2486520);

INSERT INTO Estudiante(carne, universidad, id_usuario)
VALUES(2019000000, 'Tecnologico de Costa Rica', 1897025);