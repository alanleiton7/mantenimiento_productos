using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class N_categoria
    {
        D_categoria objDatos = new D_categoria();


        public List<E_categoria> Buscar_categoria(string buscar_p)
        {
            return objDatos.buscar_categoria(buscar_p);
        }
        public void Insertar_categoria(E_categoria categoria_p)
        {
            objDatos.insertar_categoria(categoria_p);
        }
        public void Modificar_categoria(E_categoria categoria_p)
        {
            objDatos.modificar_categoria(categoria_p);
        }
        public void Eliminar_categoria(E_categoria categoria_p)
        {
            objDatos.eliminar_categoria(categoria_p);
        }
    }
}
