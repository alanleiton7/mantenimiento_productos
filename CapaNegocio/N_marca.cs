using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;


namespace CapaNegocio
{
   public class N_marca
    {

        D_marca objDatos = new D_marca();


        public List<E_marca> Buscar_marca(string buscar_p)
        {
            return objDatos.buscar_marca(buscar_p);
        }
        public void Insertar_marca(E_marca marca_p)
        {
            objDatos.insertar_marca(marca_p);
        }
        public void Modificar_marca(E_marca marca_p)
        {
            objDatos.modificar_marca(marca_p);
        }
        public void Eliminar_marca(E_marca marca_p)
        {
            objDatos.eliminar_marca(marca_p);
        }
     
    }
}
