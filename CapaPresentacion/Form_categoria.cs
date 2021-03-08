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
    public partial class Form_categoria : Form
    {
        //varibles y objetos globales 
        private string id_categoria;
        private bool editarse = false;
        E_categoria obj_entidad = new E_categoria();
        N_categoria obj_negocio = new N_categoria();

        public Form_categoria()
        {
            InitializeComponent();
           
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            //cerrar la aplicacion 
            //Application.Exit();
            this.Close();
           
        }

        private void Form_categoria_Load_1(object sender, EventArgs e)
        {
            mostrar_buscar_tabla("");
            //hace las acciones del datagrid
            acciones_datagrid();
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            //evento text_changed para cuando escribimos en buscar lo filtro por 
            //nombre
            mostrar_buscar_tabla(txt_buscar.Text);
        }
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            //pone la variable global editase en false
            editarse = false;
            limpiar_cajas();
        }


        private void btn_modificar_Click(object sender, EventArgs e)
        {
            //pone la variable editarse en true
            editarse = true;
            //valida si hay una fila selecionada en el datagrid
            if (datagrid_categoria.SelectedRows.Count > 0)
            {
                //asigna a la variable global id_estudiante la el valor de id_estudiante de esa fila
                id_categoria = datagrid_categoria.CurrentRow.Cells[0].Value.ToString();
                txt_codigo.Text = datagrid_categoria.CurrentRow.Cells[1].Value.ToString();
                txt_nombre.Text = datagrid_categoria.CurrentRow.Cells[2].Value.ToString();
                txt_descripcion.Text = datagrid_categoria.CurrentRow.Cells[3].Value.ToString();
            }
            else
            {
                MessageBox.Show("Selecione una fila", "Informacion!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txt_buscar_Click(object sender, EventArgs e)
        {
            txt_buscar.Text = "";
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (editarse == false)
            {
                try
                {
                    //llama al objeto glogal obj_entidad y le asigna los valores por medio de set 
                    obj_entidad.Codigo = int.Parse(txt_codigo.Text);
                    obj_entidad.Nombre = txt_nombre.Text;
                    obj_entidad.Descripcion = txt_descripcion.Text;
                    //pasa por parametro el objeto de tipo negocio
                    obj_negocio.Insertar_categoria(obj_entidad);
                    Form_notificacion notificacion = new Form_notificacion("Guardado!!!");
                    notificacion.ShowDialog();
                    mostrar_buscar_tabla("");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar la categoria " + ex.Message);

                }
            }
            else
            {
                //metodo editar estudiante
                try
                {  //
                    obj_entidad.Id_categoria = int.Parse(id_categoria);
                    obj_entidad.Codigo = int.Parse(txt_codigo.Text);
                    obj_entidad.Nombre = txt_nombre.Text;
                    obj_entidad.Descripcion = txt_descripcion.Text;
                    obj_negocio.Modificar_categoria(obj_entidad);
                    Form_notificacion notificacion = new Form_notificacion("Editado!!!");
                    notificacion.ShowDialog();
                    mostrar_buscar_tabla("");
                    editarse = false;
                    txt_buscar.Text = "";
                }
                catch (Exception ex)
                {

                    MessageBox.Show("No se pudo editar la categoria " + ex.Message);
                }
            }
            limpiar_cajas();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

            if (datagrid_categoria.SelectedRows.Count > 0)
            {

                try
                {
                    Form_validacion obj_validacion = new Form_validacion();
                    DialogResult opcion = obj_validacion.validacion();
                   // DialogResult opcion = MessageBox.Show("Desea eliminar este usuario!!!", "Adventencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (DialogResult.Yes == opcion)
                    {

                        obj_entidad.Id_categoria = int.Parse(datagrid_categoria.CurrentRow.Cells[0].Value.ToString());
                        obj_negocio.Eliminar_categoria(obj_entidad);
                        Form_notificacion notificacion = new Form_notificacion("Eliminado!!!");
                        notificacion.ShowDialog();
                        mostrar_buscar_tabla("");
                        editarse = false;
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error: " + ex.Message);
                }

            }
        }

        //metodos 
        public void mostrar_buscar_tabla(string buscar_p)
        {

            N_categoria obj_negocio = new N_categoria();
            datagrid_categoria.DataSource = obj_negocio.Buscar_categoria(buscar_p);

        }
      
        public void acciones_datagrid()
        {

            datagrid_categoria.Columns[0].Visible = false;
            datagrid_categoria.Columns[1].Width = 5;
            datagrid_categoria.Columns[2].Width = 10;
            datagrid_categoria.Columns[3].Width = 270;

        }

        public void limpiar_cajas()
        {

            txt_codigo.Text = "";
            txt_nombre.Text = "";
            txt_descripcion.Text = "";
            txt_codigo.Focus();

        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
           
        }


        //fin metodos

    }
}
