using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using CapaEntidades;
using System.Data;

namespace CapaDatos
{
   public  class D_productos
    {
        private SqlConnection conecion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);


        public DataTable listar_productos() {

            DataTable tabla = new DataTable();
            SqlDataReader leer_filas ;
            SqlCommand cmd = new SqlCommand("sp_listar_productos", conecion);
            cmd.CommandType = CommandType.StoredProcedure;
            conecion.Open();

            leer_filas = cmd.ExecuteReader();
            tabla.Load(leer_filas);

            leer_filas.Close();
            conecion.Close();

            return tabla;
        }



        ///prueba
        ///

        public List<E_productos> buscar_productos(string buscar_p)
        {

            SqlDataReader leer_filas;//declaramos un sqlreader llamado leer_filas
            //creamos un comando con el nombre del procedimiento y la coneccion
            SqlCommand cmd = new SqlCommand("sp_buscar_producto", conecion);
            //decimos que tipo de comando va hacer en este caso proc almacenado
            cmd.CommandType = CommandType.StoredProcedure;
            //abrimos la conecion 
            conecion.Open();
            //le pasamos el parametro al procedimiento almacenado
            cmd.Parameters.AddWithValue("@buscar", buscar_p);
            //ejecutamos el comando que nos devuelve la lista de la filas que las 
            //las guardaremos en el sqlreader
            leer_filas = cmd.ExecuteReader();
            //declaremos un objeto de tipo lista de entidades estudiantes
            List<E_productos> lista_productos = new List<E_productos>();
            //recorremos el  leer_filas
            while (leer_filas.Read())
            {
                //y guardaremos en la lista el grupo de filas devueltas
                lista_productos.Add(
                    new E_productos
                    {
                        //en cada objeto de la lista guardamos los siguiente datos
                        Id_producto = leer_filas.GetInt32(0),
                        Codigo = leer_filas.GetInt32(1),
                        Producto = leer_filas.GetString(2),
                        Fk_id_categoria = leer_filas.GetInt32(3),
                        Categoria = leer_filas.GetString(4),
                        Fk_id_marca = leer_filas.GetInt32(5),
                        Marca = leer_filas.GetString(6),
                        Precio_compra = leer_filas.GetDecimal(7),
                        Precio_venta = leer_filas.GetDecimal(8),
                        Stock = leer_filas.GetInt32(9),

        
    }
                         );
            }
            //cerramos la coneccion 
            conecion.Close();
            //cerramos el sqlreader leer filas
            leer_filas.Close();
            //returnamos la lista
            return lista_productos;

            
        }


        ///
        public void insertar_productos(E_productos prodoctos_p)
        {

            SqlCommand cmd = new SqlCommand("sp_insertar_productos", conecion);
            cmd.CommandType = CommandType.StoredProcedure;
            conecion.Open();
            cmd.Parameters.AddWithValue("codigo", prodoctos_p.Codigo);
            cmd.Parameters.AddWithValue("producto", prodoctos_p.Producto);
            cmd.Parameters.AddWithValue("precio_compra", prodoctos_p.Precio_compra);
            cmd.Parameters.AddWithValue("precio_venta", prodoctos_p.Precio_venta);
            cmd.Parameters.AddWithValue("stock", prodoctos_p.Stock);
            cmd.Parameters.AddWithValue("fk_id_marca", prodoctos_p.Fk_id_marca);
            cmd.Parameters.AddWithValue("fk_id_categoria", prodoctos_p.Fk_id_categoria);

            cmd.ExecuteNonQuery();
            conecion.Close();

        }
        public void modificar_productos(E_productos prodoctos_p)
        {

            SqlCommand cmd = new SqlCommand("sp_editar_productos", conecion);
            cmd.CommandType = CommandType.StoredProcedure;
            conecion.Open();
            cmd.Parameters.AddWithValue("id_producto", prodoctos_p.Id_producto);
            cmd.Parameters.AddWithValue("codigo", prodoctos_p.Codigo);
            cmd.Parameters.AddWithValue("producto", prodoctos_p.Producto);
            cmd.Parameters.AddWithValue("precio_compra", prodoctos_p.Precio_compra);
            cmd.Parameters.AddWithValue("precio_venta", prodoctos_p.Precio_venta);
            cmd.Parameters.AddWithValue("stock", prodoctos_p.Stock);
            cmd.Parameters.AddWithValue("fk_id_marca", prodoctos_p.Fk_id_marca);
            cmd.Parameters.AddWithValue("fk_id_categoria", prodoctos_p.Fk_id_categoria);
            cmd.ExecuteNonQuery();
            conecion.Close();

        }
        public void eliminar_productos(E_productos productos_p)
        {

            SqlCommand cmd = new SqlCommand("sp_eliminar_productos", conecion);
            cmd.CommandType = CommandType.StoredProcedure;
            conecion.Open();
            cmd.Parameters.AddWithValue("id_producto", productos_p.Id_producto);
            cmd.ExecuteReader();
            conecion.Close();

        }

    }
}
