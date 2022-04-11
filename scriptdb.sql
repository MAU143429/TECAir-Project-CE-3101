--
-- PostgreSQL database dump
--

-- Dumped from database version 14.2
-- Dumped by pg_dump version 14.2

-- Started on 2022-04-10 16:39:54

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- TOC entry 215 (class 1259 OID 16472)
-- Name: asiento; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.asiento (
    no_asiento numeric NOT NULL,
    ubicacion character varying(10) NOT NULL,
    no_vuelo numeric NOT NULL
);


ALTER TABLE public.asiento OWNER TO postgres;

--
-- TOC entry 212 (class 1259 OID 16441)
-- Name: avion; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.avion (
    matricula character varying(20) NOT NULL,
    av_nombre character varying(30) NOT NULL,
    capacidad numeric NOT NULL
);


ALTER TABLE public.avion OWNER TO postgres;

--
-- TOC entry 210 (class 1259 OID 16422)
-- Name: estudiante; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.estudiante (
    carne numeric NOT NULL,
    universidad character varying(60) NOT NULL,
    id_usuario numeric NOT NULL
);


ALTER TABLE public.estudiante OWNER TO postgres;

--
-- TOC entry 220 (class 1259 OID 16552)
-- Name: maleta; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.maleta (
    no_maleta numeric NOT NULL,
    color character varying(20) NOT NULL,
    peso numeric NOT NULL,
    dni numeric NOT NULL
);


ALTER TABLE public.maleta OWNER TO postgres;

--
-- TOC entry 219 (class 1259 OID 16535)
-- Name: pasajero; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.pasajero (
    dni numeric NOT NULL,
    p_nombre character varying(20) NOT NULL,
    p_apellido1 character varying(20) NOT NULL,
    p_apellido2 character varying(20) NOT NULL,
    cant_maletas numeric NOT NULL,
    chequeado boolean NOT NULL,
    no_transaccion numeric NOT NULL
);


ALTER TABLE public.pasajero OWNER TO postgres;

--
-- TOC entry 216 (class 1259 OID 16484)
-- Name: promocion; Type: TABLE; Schema: public; Owner: postgres
--

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


ALTER TABLE public.promocion OWNER TO postgres;

--
-- TOC entry 217 (class 1259 OID 16496)
-- Name: reservacion; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.reservacion (
    no_reservacion numeric NOT NULL,
    cancelado boolean NOT NULL,
    no_vuelo numeric NOT NULL,
    id_usuario numeric,
    id_trabajador numeric
);


ALTER TABLE public.reservacion OWNER TO postgres;

--
-- TOC entry 218 (class 1259 OID 16518)
-- Name: tiquete; Type: TABLE; Schema: public; Owner: postgres
--

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


ALTER TABLE public.tiquete OWNER TO postgres;

--
-- TOC entry 211 (class 1259 OID 16434)
-- Name: trabajador; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.trabajador (
    id_trabajador numeric NOT NULL,
    t_contrasena character varying(20) NOT NULL
);


ALTER TABLE public.trabajador OWNER TO postgres;

--
-- TOC entry 209 (class 1259 OID 16415)
-- Name: usuario; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.usuario (
    id_usuario numeric NOT NULL,
    u_nombre character varying(20) NOT NULL,
    u_apellido1 character varying(20) NOT NULL,
    u_apellido2 character varying(20) NOT NULL,
    correo character varying(40) NOT NULL,
    u_contrasena character varying(20) NOT NULL,
    telefono numeric NOT NULL
);


ALTER TABLE public.usuario OWNER TO postgres;

--
-- TOC entry 213 (class 1259 OID 16448)
-- Name: vuelo; Type: TABLE; Schema: public; Owner: postgres
--

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


ALTER TABLE public.vuelo OWNER TO postgres;

--
-- TOC entry 214 (class 1259 OID 16460)
-- Name: vuelo_escala; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.vuelo_escala (
    escala character varying(256) NOT NULL,
    no_vuelo numeric NOT NULL
);


ALTER TABLE public.vuelo_escala OWNER TO postgres;

--
-- TOC entry 3220 (class 2606 OID 16478)
-- Name: asiento asiento_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.asiento
    ADD CONSTRAINT asiento_pkey PRIMARY KEY (no_asiento);


--
-- TOC entry 3214 (class 2606 OID 16447)
-- Name: avion avion_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.avion
    ADD CONSTRAINT avion_pkey PRIMARY KEY (matricula);


--
-- TOC entry 3210 (class 2606 OID 16428)
-- Name: estudiante estudiante_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.estudiante
    ADD CONSTRAINT estudiante_pkey PRIMARY KEY (carne);


--
-- TOC entry 3230 (class 2606 OID 16558)
-- Name: maleta maleta_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.maleta
    ADD CONSTRAINT maleta_pkey PRIMARY KEY (no_maleta);


--
-- TOC entry 3228 (class 2606 OID 16541)
-- Name: pasajero pasajero_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.pasajero
    ADD CONSTRAINT pasajero_pkey PRIMARY KEY (dni);


--
-- TOC entry 3222 (class 2606 OID 16490)
-- Name: promocion promocion_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.promocion
    ADD CONSTRAINT promocion_pkey PRIMARY KEY (no_promocion);


--
-- TOC entry 3224 (class 2606 OID 16502)
-- Name: reservacion reservacion_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.reservacion
    ADD CONSTRAINT reservacion_pkey PRIMARY KEY (no_reservacion);


--
-- TOC entry 3226 (class 2606 OID 16524)
-- Name: tiquete tiquete_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tiquete
    ADD CONSTRAINT tiquete_pkey PRIMARY KEY (no_transaccion);


--
-- TOC entry 3212 (class 2606 OID 16440)
-- Name: trabajador trabajador_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.trabajador
    ADD CONSTRAINT trabajador_pkey PRIMARY KEY (id_trabajador);


--
-- TOC entry 3208 (class 2606 OID 16421)
-- Name: usuario usuario_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.usuario
    ADD CONSTRAINT usuario_pkey PRIMARY KEY (id_usuario);


--
-- TOC entry 3218 (class 2606 OID 16466)
-- Name: vuelo_escala vuelo_escala_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.vuelo_escala
    ADD CONSTRAINT vuelo_escala_pkey PRIMARY KEY (escala);


--
-- TOC entry 3216 (class 2606 OID 16454)
-- Name: vuelo vuelo_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.vuelo
    ADD CONSTRAINT vuelo_pkey PRIMARY KEY (no_vuelo);


--
-- TOC entry 3241 (class 2606 OID 16547)
-- Name: tiquete dni; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tiquete
    ADD CONSTRAINT dni FOREIGN KEY (dni) REFERENCES public.pasajero(dni) NOT VALID;


--
-- TOC entry 3243 (class 2606 OID 16559)
-- Name: maleta dni; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.maleta
    ADD CONSTRAINT dni FOREIGN KEY (dni) REFERENCES public.pasajero(dni);


--
-- TOC entry 3238 (class 2606 OID 16513)
-- Name: reservacion id_trabajador; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.reservacion
    ADD CONSTRAINT id_trabajador FOREIGN KEY (id_trabajador) REFERENCES public.trabajador(id_trabajador);


--
-- TOC entry 3231 (class 2606 OID 16429)
-- Name: estudiante id_usuario; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.estudiante
    ADD CONSTRAINT id_usuario FOREIGN KEY (id_usuario) REFERENCES public.usuario(id_usuario);


--
-- TOC entry 3237 (class 2606 OID 16508)
-- Name: reservacion id_usuario; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.reservacion
    ADD CONSTRAINT id_usuario FOREIGN KEY (id_usuario) REFERENCES public.usuario(id_usuario);


--
-- TOC entry 3232 (class 2606 OID 16455)
-- Name: vuelo matricula; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.vuelo
    ADD CONSTRAINT matricula FOREIGN KEY (" matricula") REFERENCES public.avion(matricula);


--
-- TOC entry 3240 (class 2606 OID 16530)
-- Name: tiquete no_asiento; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tiquete
    ADD CONSTRAINT no_asiento FOREIGN KEY (no_asiento) REFERENCES public.asiento(no_asiento);


--
-- TOC entry 3239 (class 2606 OID 16525)
-- Name: tiquete no_reservacion; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tiquete
    ADD CONSTRAINT no_reservacion FOREIGN KEY (no_reservacion) REFERENCES public.reservacion(no_reservacion);


--
-- TOC entry 3242 (class 2606 OID 16542)
-- Name: pasajero no_transaccion; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.pasajero
    ADD CONSTRAINT no_transaccion FOREIGN KEY (no_transaccion) REFERENCES public.tiquete(no_transaccion);


--
-- TOC entry 3233 (class 2606 OID 16467)
-- Name: vuelo_escala no_vuelo; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.vuelo_escala
    ADD CONSTRAINT no_vuelo FOREIGN KEY (no_vuelo) REFERENCES public.vuelo(no_vuelo);


--
-- TOC entry 3234 (class 2606 OID 16479)
-- Name: asiento no_vuelo; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.asiento
    ADD CONSTRAINT no_vuelo FOREIGN KEY (no_vuelo) REFERENCES public.vuelo(no_vuelo);


--
-- TOC entry 3235 (class 2606 OID 16491)
-- Name: promocion no_vuelo; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.promocion
    ADD CONSTRAINT no_vuelo FOREIGN KEY (no_vuelo) REFERENCES public.vuelo(no_vuelo);


--
-- TOC entry 3236 (class 2606 OID 16503)
-- Name: reservacion no_vuelo; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.reservacion
    ADD CONSTRAINT no_vuelo FOREIGN KEY (no_vuelo) REFERENCES public.vuelo(no_vuelo);


-- Completed on 2022-04-10 16:39:54

--
-- PostgreSQL database dump complete
--

