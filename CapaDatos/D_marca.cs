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
   public  class D_marca
    {
        //creamos un sqlconnection de mi appconfig de capaPresentacion
        private SqlConnection conecion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        //creamos un metodo que nos devuelve una lista de tipo entidade producto
        //donde le pasamos un parametro 
        public List<E_marca> buscar_marca(string buscar_p)
        {

            SqlDataReader leer_filas;//declaramos un sqlreader llamado leer_filas
            //creamos un comando con el nombre del procedimiento y la coneccion
            SqlCommand cmd = new SqlCommand("sp_buscar_marca", conecion);
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
            List<E_marca> lista_marca = new List<E_marca>();
            //recorremos el  leer_filas
            while (leer_filas.Read())
            {
                //y guardaremos en la lista el grupo de filas devueltas
                lista_marca.Add(
                    new E_marca
                    {
                        //en cada objeto de la lista guardamos los siguiente datos
                        Id_marca = leer_filas.GetInt32(0),
                        Codigo = leer_filas.GetInt32(1),
                        Nombre = leer_filas.GetString(2),
                        Descripcion = leer_filas.GetString(3)

                    }
                         );
            }
            //cerramos la coneccion 
            conecion.Close();
            //cerramos el sqlreader leer filas
            leer_filas.Close();
            //returnamos la lista
            return lista_marca;

            /*
            foreach (E_estudiante nuevalista in leer_filas)
            {
                lista.Add(new E_estudiante
                    {
                        Id_estudiate = leer_filas.GetInt32(0),
                        Cedula = leer_filas.GetInt32(1),
                        Nombre = leer_filas.GetString(2),
                        Apellido = leer_filas.GetString(3)

                    });
            }
            */
        }

        //metodo insertar estudiante
        public void insertar_marca(E_marca marca_p)
        {

            SqlCommand cmd = new SqlCommand("sp_insertar_marca", conecion);
            cmd.CommandType = CommandType.StoredProcedure;
            conecion.Open();
            cmd.Parameters.AddWithValue("codigo", marca_p.Codigo);
            cmd.Parameters.AddWithValue("nombre", marca_p.Nombre);
            cmd.Parameters.AddWithValue("descripcion", marca_p.Descripcion);

            cmd.ExecuteNonQuery();
            conecion.Close();

        }
        public void modificar_marca(E_marca marca_p)
        {

            SqlCommand cmd = new SqlCommand("sp_editar_marca", conecion);
            cmd.CommandType = CommandType.StoredProcedure;
            conecion.Open();
            cmd.Parameters.AddWithValue("id_marca", marca_p.Id_marca);
            cmd.Parameters.AddWithValue("codigo", marca_p.Codigo);
            cmd.Parameters.AddWithValue("nombre", marca_p.Nombre);
            cmd.Parameters.AddWithValue("descripcion", marca_p.Descripcion);
            cmd.ExecuteNonQuery();
            conecion.Close();

        }
        public void eliminar_marca(E_marca marca_p)
        {

            SqlCommand cmd = new SqlCommand("sp_eliminar_marca", conecion);
            cmd.CommandType = CommandType.StoredProcedure;
            conecion.Open();
            cmd.Parameters.AddWithValue("id_marca", marca_p.Id_marca);
            cmd.ExecuteReader();
            conecion.Close();

        }




    }
}
