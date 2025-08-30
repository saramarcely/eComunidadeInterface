using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eComunidade.Models
{
    public class Favoritos
    {
        public int Id { get; set; }           // Id do registro do favorito
        public int IdUsuario { get; set; }    // Quem marcou o favorito
        public int IdLocal { get; set; }      // Id do item favoritado (Evento, Dica, Ocorrencia, etc.)
        public DateTime Momento { get; set; }
    }
}
