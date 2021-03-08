using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
   public   class E_productos
    {

        private int id_producto;
        private int codigo;
        private string producto;
        private int fk_id_categoria;
        private string categoria;
        private int fk_id_marca;
        private string marcas;
        private decimal precio_compra;
        private decimal precio_venta;
        private int stock;

        public int Id_producto { get => id_producto; set => id_producto = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public string Producto { get => producto; set => producto = value; }
        public int Fk_id_categoria { get => fk_id_categoria; set => fk_id_categoria = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public int Fk_id_marca { get => fk_id_marca; set => fk_id_marca = value; }
        public string Marca { get => marcas; set => marcas = value; }
        public decimal Precio_compra { get => precio_compra; set => precio_compra = value; }
        public decimal Precio_venta { get => precio_venta; set => precio_venta = value; }
        public int Stock { get => stock; set => stock = value; }
    }
}
