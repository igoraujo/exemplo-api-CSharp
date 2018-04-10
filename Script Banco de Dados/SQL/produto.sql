-- Table: public.produto

-- DROP TABLE public.produto;

CREATE TABLE public.produto
(
    id numeric NOT NULL,
    descricao text COLLATE pg_catalog."default",
    dt_ultima_venda date,
    valor_venda double precision,
    obs text COLLATE pg_catalog."default",
    id_grupo numeric,
    CONSTRAINT "PK_id_produto" PRIMARY KEY (id),
    CONSTRAINT "FK_id_grupo" FOREIGN KEY (id_grupo)
        REFERENCES public.grupo (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE public.produto
    OWNER to postgres;