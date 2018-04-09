using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.TO
{
    public class TOGrupo
    {
        #region Private Fields
        [Key]
        private int _id;
        private string _descricao;

        #endregion

        #region Public Fields
        public int Id { get => _id; set => _id = value; }
        public string Descricao { get => _descricao; set => _descricao = value; }

        #endregion
    }
}
