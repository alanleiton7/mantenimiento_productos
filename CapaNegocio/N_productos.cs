using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using CapaDatos;
using CapaEntidades;



namespace CapaNegocio
{
  public  class N_productos
    {
        D_productos obj_productos = new D_productos();
        public DataTable listar_productos()
        {
          return  obj_productos.listar_productos();
  
        }

        //prueba

       


        public List<E_productos> Buscar_productos(string buscar_p)
        {
            return obj_productos.buscar_productos(buscar_p);
        }
        public void Insertar_producto(E_productos producto_p)
        {
            obj_productos.insertar_productos(producto_p);
        }
        public void modificar_producto(E_productos producto_p)
        {
            obj_productos. modificar_productos(producto_p);
        }
        public void eliminar_producto(E_productos producto_p)
        {
            obj_productos.eliminar_productos(producto_p);
        }
       

        //


    }
}