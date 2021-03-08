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
    public partial class Form_notificacion : Form
    {
        public Form_notificacion(string mensaje_p)
        {
            InitializeComponent();
            lb_mensaje.Text = mensaje_p;
        
        }
        public Form_notificacion() {
        
        }

        private void Form_notificacion_Load(object sender, EventArgs e)
        {
            transiccion.ShowAsyc(this);
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //metodo
        /*
        public void confimacion_form() {

           
            Form_notificacion notificacion = new Form_notificacion();
            
            notificacion.ShowDialog();
            
        }
        */
    }
}
