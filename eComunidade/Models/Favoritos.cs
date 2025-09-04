using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eComunidade.Models
{
    public class Favoritos
    {
        public int Id { get; set; }          
        public int IdUsuario { get; set; }    
        public int IdLocal { get; set; }     
        public DateTime Momento { get; set; }
    }
}
