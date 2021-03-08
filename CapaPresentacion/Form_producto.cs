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
    public partial class Form_producto : Form
    {

        N_productos obj_negocio_pro = new N_productos();
        E_productos obj_entidades_pro = new E_productos();
      
        public Form_producto()
        {
            InitializeComponent();

            mostrar_buscar_tabla();
            ocultar_mover_anchar_columnas();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //prueba 
      
        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            buscar_producto(txt_buscar_producto.Text);
            
            ocultar_mover_anchar_columnas();
        }

        //metodos
        public void mostrar_buscar_tabla()
        {

            N_productos obj_producto = new N_productos();
            dg_tabla_productos.DataSource = obj_producto.listar_productos();

        }

        public void buscar_producto(string buscar_p)
        {

            N_productos obj_producto = new N_productos();
            dg_tabla_productos.DataSource = obj_producto.Buscar_productos(buscar_p);

        }

        public void ocultar_mover_anchar_columnas() {
            
                      dg_tabla_productos.Columns[2].Visible = false;
                      dg_tabla_productos.Columns[5].Visible = false;
                      dg_tabla_productos.Columns[7].Visible = false;

                     dg_tabla_productos.Columns[0].Width = 70;
                     dg_tabla_productos.Columns[1].Width = 120;
                     dg_tabla_productos.Columns[2].Width = 120;
                     dg_tabla_productos.Columns[3].Width = 70;

            
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Form_categoria obj_categoria = new Form_categoria();
            obj_categoria.ShowDialog();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Form_mant_prod mant_producto = new Form_mant_prod();
            mant_producto.ShowDialog();
           // mant_producto.Update = false;
            mostrar_buscar_tabla();
           // ocultar_mover_anchar_columnas();
        }

        private void dg_tabla_productos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (dg_tabla_productos.Rows[e.RowIndex].Cells["ELIMINAR"].Selected) {

                Form_validacion obj_validacion = new Form_validacion();
                DialogResult opcion = obj_validacion.validacion("Desea eliminar el siguiente producto!!");

                if (DialogResult.Yes == opcion)
                {
                    obj_entidades_pro.Id_producto = Convert.ToInt32(dg_tabla_productos.Rows[e.RowIndex].Cells[2].Value.ToString());
                    obj_negocio_pro.eliminar_producto(obj_entidades_pro);
                    Form_notificacion notificacion = new Form_notificacion("Eliminado!!!");
                    notificacion.ShowDialog();
                    mostrar_buscar_tabla();
                    ocultar_mover_anchar_columnas();

                } 
            }
            else if (dg_tabla_productos.Rows[e.RowIndex].Cells["EDITAR"].Selected)
            {

                Form_mant_prod ven_man_pro = new Form_mant_prod();

                ven_man_pro.editarse = true;
                ven_man_pro.txt_id_producto.Text = dg_tabla_productos.Rows[e.RowIndex].Cells["id_producto"].Value.ToString();
                ven_man_pro.txt_codigo.Text = dg_tabla_productos.Rows[e.RowIndex].Cells["codigo"].Value.ToString();
                ven_man_pro.txt_nombre_producto.Text = dg_tabla_productos.Rows[e.RowIndex].Cells["producto"].Value.ToString();
                ven_man_pro.txt_pre_compra.Text = dg_tabla_productos.Rows[e.RowIndex].Cells["precio_compra"].Value.ToString();
                ven_man_pro.txt_pre_venta.Text = dg_tabla_productos.Rows[e.RowIndex].Cells["precio_venta"].Value.ToString();
                ven_man_pro.txt_stock.Text = dg_tabla_productos.Rows[e.RowIndex].Cells["stock"].Value.ToString();
                ven_man_pro.cmb_categoria.Text = dg_tabla_productos.Rows[e.RowIndex].Cells["categoria"].Value.ToString();
               // ven_man_pro.cmb_marca.Text = dg_tabla_productos.Rows[e.RowIndex].Cells["marcas"].Value.ToString();
                ven_man_pro.ShowDialog();
                mostrar_buscar_tabla();
                ocultar_mover_anchar_columnas();


            }




        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            Form_marca obj_marca = new Form_marca();
            obj_marca.ShowDialog();
        }
       
    }
}
