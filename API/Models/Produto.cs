using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class Produto
    {
        #region Private Fields

        
        [Key] //indica quem é a chave primaria, no caso o campo _id
        private int _id;
        private string _descricao;
        private DateTime _dt_ultima_venda;
        private double _valor_venda;
        private string _obs;
        private int _id_grupo;

        #endregion

        #region Public Fields

        // A propriedade publica deve ter exatamente o mesmo nome(inclusive respeirando letras maiusculas e minusculas) que no banco de dados, caso queira-se utilizar dentro do programa a propriedade
        // com o nome diferente deve-se utilizar a notation [Column]("nomePropriedadeNoBanco") logo acima da propriedade desejada. 
        [Column("id")]
        public int Id { get => _id; set => _id = value; }

        [Column("descricao")]
        public string Descricao { get => _descricao; set => _descricao = value; }

        [Column("dt_ultima_venda")]
        public DateTime Dt_ultima_venda { get => _dt_ultima_venda; set => _dt_ultima_venda = value; }

        [Column("valor_venda")]
        public double Valor_venda { get => _valor_venda; set => _valor_venda = value; }

        [Column("obs")]
        public string Obs { get => _obs; set => _obs = value; }

        [Column("id_grupo")]
        public int Id_grupo { get => _id_grupo; set => _id_grupo = value; }

        #endregion
    }
}
