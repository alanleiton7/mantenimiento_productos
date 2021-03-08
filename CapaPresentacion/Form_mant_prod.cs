using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidades;

namespace CapaPresentacion
{
    public partial class Form_mant_prod : Form
    {

        public bool editarse = false;
        
        E_productos obj_entidad_prod = new E_productos();
        N_productos obj_negocio_prod = new N_productos();
        public Form_mant_prod()
        {
            InitializeComponent();
            listaCategorias();
            listaMarcas();


        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            // Application.Exit();
            this.Close();
        }


        public void listaCategorias() {
            //instanciamos un objgeto de la clase n_categoria
            N_categoria obj_categoria = new N_categoria();
            //cargamos el combo_categoria con todo los datos de buscar categoria
            cmb_categoria.DataSource = obj_categoria.Buscar_categoria("");
            //seleccionamos el valor de id de la categoria
            cmb_categoria.ValueMember = "id_categoria";
            //y lo mostramos con el nombre de categoria
            cmb_categoria.DisplayMember = "nombre";

        }
        public void listaMarcas()
        {

            N_marca obj_marca = new N_marca();
            cmb_marca.DataSource = obj_marca.Buscar_marca("");
            cmb_marca.ValueMember = "id_marca";
            cmb_marca.DisplayMember = "nombre";

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (editarse == false)
            {
                try
                {
                    // MessageBox.Show("marca"+ cmb_categoria.SelectedValue);
                    //llama al objeto glogal obj_entidad y le asigna los valores por medio de set 
                    obj_entidad_prod.Codigo = int.Parse(txt_codigo.Text);
                    obj_entidad_prod.Producto = txt_nombre_producto.Text;
                    obj_entidad_prod.Stock = int.Parse(txt_stock.Text);
                    obj_entidad_prod.Precio_compra = decimal.Parse(txt_pre_compra.Text);
                    obj_entidad_prod.Precio_venta = decimal.Parse(txt_pre_venta.Text);
                    obj_entidad_prod.Fk_id_categoria = int.Parse(cmb_categoria.SelectedValue.ToString());
                    obj_entidad_prod.Fk_id_marca = int.Parse(cmb_marca.SelectedValue.ToString());
                    //pasa por parametro el objeto de tipo negocio
                    obj_negocio_prod.Insertar_producto(obj_entidad_prod);
                    Form_notificacion notificacion = new Form_notificacion("Guardado!!!");
                    notificacion.ShowDialog();
                    // mostrar_buscar_tabla("");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar el producto  " + ex.Message);

                }
                this.Close();

            }
            else
            {
                //metodo editar estudiante
                try
                {  //
                    obj_entidad_prod.Id_producto = int.Parse(txt_id_producto.Text);
                    obj_entidad_prod.Codigo = int.Parse(txt_codigo.Text);
                    obj_entidad_prod.Producto = txt_nombre_producto.Text;
                    obj_entidad_prod.Stock = int.Parse(txt_stock.Text);
                    obj_entidad_prod.Precio_compra = decimal.Parse(txt_pre_compra.Text);
                    obj_entidad_prod.Precio_venta = decimal.Parse(txt_pre_venta.Text);
                    obj_entidad_prod.Fk_id_categoria = int.Parse(cmb_categoria.SelectedValue.ToString());
                    obj_entidad_prod.Fk_id_marca = int.Parse(cmb_marca.SelectedValue.ToString());
                    obj_negocio_prod.modificar_producto(obj_entidad_prod);
                    Form_notificacion notificacion = new Form_notificacion("Editado!!!");
                    notificacion.ShowDialog();
                    
                    editarse = false;
                    this.Close();
                   
                }
                catch (Exception ex)
                {

                    MessageBox.Show("No se pudo editar la categoria " + ex.Message);
                }
            }
           
          
        }
    }
}
