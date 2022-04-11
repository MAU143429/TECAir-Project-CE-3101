-- CREATE TABLE
-- Tabla Usuario

CREATE TABLE public.usuario (
    id_usuario numeric NOT NULL,
    u_nombre character varying(20) NOT NULL,
    u_apellido1 character varying(20) NOT NULL,
    u_apellido2 character varying(20) NOT NULL,
    correo character varying(40) NOT NULL,
    u_contrasena character varying(20) NOT NULL,
    telefono numeric NOT NULL
);

-- Tabla Estudiante

CREATE TABLE public.estudiante (
    carne numeric NOT NULL,
    universidad character varying(60) NOT NULL,
    id_usuario numeric NOT NULL
);

-- Tabla Trabajador

CREATE TABLE public.trabajador (
    id_trabajador numeric NOT NULL,
    t_contrasena character varying(20) NOT NULL
);

-- Tabla avion

CREATE TABLE public.avion (
    matricula character varying(20) NOT NULL,
    av_nombre character varying(30) NOT NULL,
    capacidad numeric NOT NULL
);

-- Tabla vuelo

CREATE TABLE public.vuelo (
    no_vuelo numeric NOT NULL,
    origen character varying(256) NOT NULL,
    destino character varying(256) NOT NULL,
    prt_abordaje character varying(10) NOT NULL,
    h_salida character varying(10) NOT NULL,
    h_llegada character varying(10) NOT NULL,
    v_dia character varying(10) NOT NULL,
    v_mes character varying(10) NOT NULL,
    v_ano character varying(10) NOT NULL,
    coste_vuelo numeric NOT NULL,
    " matricula" character varying(20) NOT NULL
);

-- Tabla vuelo_escala

CREATE TABLE public.vuelo_escala (
    escala character varying(256) NOT NULL,
    no_vuelo numeric NOT NULL
);

-- Tabla asiento

CREATE TABLE public.asiento (
    no_asiento numeric NOT NULL,
    ubicacion character varying(10) NOT NULL,
    no_vuelo numeric NOT NULL
);

-- Tabla promocion

CREATE TABLE public.promocion (
    no_promocion numeric NOT NULL,
    porcentaje numeric NOT NULL,
    periodo numeric NOT NULL,
    url character varying(512) NOT NULL,
    p_dia character varying(10) NOT NULL,
    p_mes character varying(10) NOT NULL,
    p_ano character varying(10) NOT NULL,
    no_vuelo numeric NOT NULL
);

-- Tabla reservacion

CREATE TABLE public.reservacion (
    no_reservacion numeric NOT NULL,
    cancelado boolean NOT NULL,
    no_vuelo numeric NOT NULL,
    id_usuario numeric,
    id_trabajador numeric
);

-- Tabla tiquete

CREATE TABLE public.tiquete (
    no_transaccion numeric NOT NULL,
    t_dia character varying(20) NOT NULL,
    t_mes character varying(20) NOT NULL,
    t_ano character varying(20) NOT NULL,
    abordaje boolean NOT NULL,
    no_reservacion numeric NOT NULL,
    no_asiento numeric NOT NULL,
    dni numeric NOT NULL
);

-- Tabla pasajero

CREATE TABLE public.pasajero (
    dni numeric NOT NULL,
    p_nombre character varying(20) NOT NULL,
    p_apellido1 character varying(20) NOT NULL,
    p_apellido2 character varying(20) NOT NULL,
    cant_maletas numeric NOT NULL,
    chequeado boolean NOT NULL,
    no_transaccion numeric NOT NULL
);


-- Tabla maleta

CREATE TABLE public.maleta (
    no_maleta numeric NOT NULL,
    color character varying(20) NOT NULL,
    peso numeric NOT NULL,
    dni numeric NOT NULL
);

-- ALTER TABLE

ALTER TABLE ONLY public.asiento
    ADD CONSTRAINT asiento_pkey PRIMARY KEY (no_asiento);

ALTER TABLE ONLY public.avion
    ADD CONSTRAINT avion_pkey PRIMARY KEY (matricula);

ALTER TABLE ONLY public.estudiante
    ADD CONSTRAINT estudiante_pkey PRIMARY KEY (carne);

ALTER TABLE ONLY public.maleta
    ADD CONSTRAINT maleta_pkey PRIMARY KEY (no_maleta);

ALTER TABLE ONLY public.pasajero
    ADD CONSTRAINT pasajero_pkey PRIMARY KEY (dni);

ALTER TABLE ONLY public.promocion
    ADD CONSTRAINT promocion_pkey PRIMARY KEY (no_promocion);

ALTER TABLE ONLY public.reservacion
    ADD CONSTRAINT reservacion_pkey PRIMARY KEY (no_reservacion);

ALTER TABLE ONLY public.tiquete
    ADD CONSTRAINT tiquete_pkey PRIMARY KEY (no_transaccion);

ALTER TABLE ONLY public.trabajador
    ADD CONSTRAINT trabajador_pkey PRIMARY KEY (id_trabajador);

ALTER TABLE ONLY public.usuario
    ADD CONSTRAINT usuario_pkey PRIMARY KEY (id_usuario);

ALTER TABLE ONLY public.vuelo_escala
    ADD CONSTRAINT vuelo_escala_pkey PRIMARY KEY (escala);

ALTER TABLE ONLY public.vuelo
    ADD CONSTRAINT vuelo_pkey PRIMARY KEY (no_vuelo);


ALTER TABLE ONLY public.tiquete
    ADD CONSTRAINT dni FOREIGN KEY (dni) REFERENCES public.pasajero(dni) NOT VALID;


ALTER TABLE ONLY public.maleta
    ADD CONSTRAINT dni FOREIGN KEY (dni) REFERENCES public.pasajero(dni);


ALTER TABLE ONLY public.reservacion
    ADD CONSTRAINT id_trabajador FOREIGN KEY (id_trabajador) REFERENCES public.trabajador(id_trabajador);


ALTER TABLE ONLY public.estudiante
    ADD CONSTRAINT id_usuario FOREIGN KEY (id_usuario) REFERENCES public.usuario(id_usuario);


ALTER TABLE ONLY public.reservacion
    ADD CONSTRAINT id_usuario FOREIGN KEY (id_usuario) REFERENCES public.usuario(id_usuario);


ALTER TABLE ONLY public.vuelo
    ADD CONSTRAINT matricula FOREIGN KEY (" matricula") REFERENCES public.avion(matricula);



ALTER TABLE ONLY public.tiquete
    ADD CONSTRAINT no_asiento FOREIGN KEY (no_asiento) REFERENCES public.asiento(no_asiento);


ALTER TABLE ONLY public.tiquete
    ADD CONSTRAINT no_reservacion FOREIGN KEY (no_reservacion) REFERENCES public.reservacion(no_reservacion);


ALTER TABLE ONLY public.pasajero
    ADD CONSTRAINT no_transaccion FOREIGN KEY (no_transaccion) REFERENCES public.tiquete(no_transaccion);


ALTER TABLE ONLY public.vuelo_escala
    ADD CONSTRAINT no_vuelo FOREIGN KEY (no_vuelo) REFERENCES public.vuelo(no_vuelo);


ALTER TABLE ONLY public.asiento
    ADD CONSTRAINT no_vuelo FOREIGN KEY (no_vuelo) REFERENCES public.vuelo(no_vuelo);

ALTER TABLE ONLY public.promocion
    ADD CONSTRAINT no_vuelo FOREIGN KEY (no_vuelo) REFERENCES public.vuelo(no_vuelo);


ALTER TABLE ONLY public.reservacion
    ADD CONSTRAINT no_vuelo FOREIGN KEY (no_vuelo) REFERENCES public.vuelo(no_vuelo);

