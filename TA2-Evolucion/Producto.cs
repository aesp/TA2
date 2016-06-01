using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA2_Evolucion
{
    public class Producto
    {
        private int codigo;
        private string nombre;
        private string descripcion;
        private double precio;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }
    }
}
