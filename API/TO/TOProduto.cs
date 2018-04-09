using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.TO
{
    public class TOProduto
    {
        #region Private Fields

        [Key]
        private int _id;
        private string _descricao;
        private DateTime _dt_ultima_venda;
        private double _valor_venda;
        private string _obs;
        private string _img;
        private int _id_grupo;

        #endregion

        #region Public Fields

        public int Id { get => _id; set => _id = value; }
        public string Descricao { get => _descricao; set => _descricao = value; }
        public DateTime Dt_ultima_venda { get => _dt_ultima_venda; set => _dt_ultima_venda = value; }
        public double Valor_venda { get => _valor_venda; set => _valor_venda = value; }
        public string Obs { get => _obs; set => _obs = value; }
        public string Img { get => _img; set => _img = value; }
        public int Id_grupo { get => _id_grupo; set => _id_grupo = value; }

        #endregion

    }
}
