using System;
using System.ComponentModel.DataAnnotations;


namespace API2.Model
{
    public class Produto
    {
        #region Private Fields

        [Key]
        private int _id;
        private string _descricao;
        private DateTime _dt_ultima_venda;
        private double _valor_venda;
        private string _obs;

        private int _id_grupo;

        #endregion

        #region Public Fields

        public int id { get => _id; set => _id = value; }
        public string descricao { get => _descricao; set => _descricao = value; }
        public DateTime dt_ultima_venda { get => _dt_ultima_venda; set => _dt_ultima_venda = value; }
        public double valor_venda { get => _valor_venda; set => _valor_venda = value; }
        public string obs { get => _obs; set => _obs = value; }

        public int id_grupo { get => _id_grupo; set => _id_grupo = value; }

        #endregion
    }
}
