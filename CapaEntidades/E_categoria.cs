using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
   public  class E_categoria
    {
        //abstraccion
        private int id_categoria;
        private int codigo;
        private string nombre;
        private string descripcion;
        //encapsulamiento
        public int Id_categoria { get => id_categoria; set => id_categoria = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
