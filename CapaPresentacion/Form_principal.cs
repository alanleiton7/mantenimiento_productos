using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Form_principal : Form
    {
        public Form_principal()
        {
            InitializeComponent();
            pantalla_completa();
        }


        private void btn_salir_Click(object sender, EventArgs e)
        {
            //instanciamos el objeto de la clase validacion
            Form_validacion validacion_salir = new Form_validacion();
            DialogResult respuesta;//creamos una variable dialoResult
            //en esa variable guardamos el resultado de la respuesta y le enviamos 
            //el mensaje que quiere que se muestre en el cuadro
            respuesta = validacion_salir.validacion("Desea salir de la aplicacion!!");
            //si la respuesta es yes cierra la aplicacion 
            if (respuesta == DialogResult.Yes) {

                Application.Exit();
            
            }

        }

        //metodos 
        //metodo para poner en pantalla completa sin que hagarre la barra de tareas
        public void pantalla_completa() {

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        //metodo para cambiar color de texto botones y el sender representa
        // el boton que yo seleccione
        public void color_texto_botones(Bunifu.Framework.UI.BunifuFlatButton sender) {

            btn_dashboard.Textcolor = Color.White;
            btn_producto.Textcolor = Color.White;
            btn_ventas.Textcolor = Color.White;
            btn_compras.Textcolor = Color.White;
            btn_trabajadores.Textcolor = Color.White;
            btn_clientes.Textcolor = Color.White;
            btn_proveedores.Textcolor = Color.White;
            btn_ganancia.Textcolor = Color.White;

            sender.selected = true;

            if (sender.selected)
            {
                sender.Textcolor = Color.FromArgb(98, 195, 140);
            }


        }
        //metodo de la flecha llamado seguir boton 
        public void seguir_boton(Bunifu.Framework.UI.BunifuFlatButton sender) {
            //la imagen de flecha va estar en lo mas alto de mi boton seleccionado
            flecha.Top = sender.Top;
        
        
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {

            seguir_boton((Bunifu.Framework.UI.BunifuFlatButton)sender);
            color_texto_botones( (Bunifu.Framework.UI.BunifuFlatButton) sender);
            abrir_formulario_wrapper(new Form_dashboard());
        }

        private void btn_producto_Click(object sender, EventArgs e)
        {
            seguir_boton((Bunifu.Framework.UI.BunifuFlatButton)sender);
            color_texto_botones((Bunifu.Framework.UI.BunifuFlatButton)sender);
            abrir_formulario_wrapper(new Form_producto());
        }

        private void btn_ventas_Click(object sender, EventArgs e)
        {
            seguir_boton((Bunifu.Framework.UI.BunifuFlatButton)sender);
            color_texto_botones((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }

        private void btn_compras_Click(object sender, EventArgs e)
        {
            seguir_boton((Bunifu.Framework.UI.BunifuFlatButton)sender);
            color_texto_botones((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }

        private void btn_trabajadores_Click(object sender, EventArgs e)
        {
            seguir_boton((Bunifu.Framework.UI.BunifuFlatButton)sender);
            color_texto_botones((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            seguir_boton((Bunifu.Framework.UI.BunifuFlatButton)sender);
            color_texto_botones((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }

        private void btn_proveedores_Click(object sender, EventArgs e)
        {
            seguir_boton((Bunifu.Framework.UI.BunifuFlatButton)sender);
            color_texto_botones((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }

        private void btn_ganancia_Click(object sender, EventArgs e)
        {
            seguir_boton((Bunifu.Framework.UI.BunifuFlatButton)sender);
            color_texto_botones((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }


        ///METODO DE agregar formulario al wrapper 
        ///
        //creamos un objeto de la clase form 
        private Form form_Activado = null;
        private void abrir_formulario_wrapper(Form form_Hijo) {
            //valida si ya hay un formulario abierto
            if (form_Activado != null)
            {
                //cierra un formuario abierto
                form_Activado.Close();
            }
                //pone form activado como form hijo 
                form_Activado = form_Hijo;
                //no muestra la ventana como nivel superior 
                form_Hijo.TopLevel = false;
                //llena todo el campo 
                form_Hijo.Dock = DockStyle.Fill;
                //añadimos el formulario al panel wrapper
                wrapper.Controls.Add(form_Hijo);
                //para que muestra toda la informacion del formulario hijo
                wrapper.Tag = form_Hijo;
                //para traer el formulario al frente 
                form_Hijo.BringToFront();
                //llama o muestra el formulairo 
                form_Hijo.Show();
        }

    }
}
