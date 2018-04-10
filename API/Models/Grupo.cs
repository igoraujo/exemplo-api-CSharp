using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Grupo
    {
        #region Private Fields

        [Key]
        private int _id;
        private string _descricao;

        #endregion

        #region Public Fields

        [Column("id")]
        public int Id { get => _id; set => _id = value; }

        [Column("descricao")]
        public string Descricao { get => _descricao; set => _descricao = value; }

        #endregion
    }
}
