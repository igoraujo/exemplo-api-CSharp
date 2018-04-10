-- Table: public.grupo

-- DROP TABLE public.grupo;

CREATE TABLE public.grupo
(
    id numeric NOT NULL,
    descricao text COLLATE pg_catalog."default",
    CONSTRAINT "PK_id_grupo" PRIMARY KEY (id)
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE public.grupo
    OWNER to postgres;