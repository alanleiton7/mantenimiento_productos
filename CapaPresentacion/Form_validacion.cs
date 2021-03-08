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
    public partial class Form_validacion : Form
    {
        DialogResult opcion;
        public Form_validacion()
        {
            InitializeComponent();
        }

        private void Form_validacion_Load(object sender, EventArgs e)
        {
            transiccion.ShowAsyc(this);
        }

        //metodo
        public DialogResult validacion() {
 
            this.ShowDialog();
                return opcion;
        }
        public DialogResult validacion(string mensaje_p)
        {
            lb_mensaje.Text = mensaje_p;
            this.ShowDialog();
            return opcion;
        }
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            opcion = DialogResult.Yes;
            this.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            opcion = DialogResult.No;
            this.Close();
        }
    }
}
