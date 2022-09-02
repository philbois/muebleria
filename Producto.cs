using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    abstract class Producto:IComparable
    {
         string descripcion;
        protected double precioBase;
        protected int material;

        abstract public double precio();
        public Producto(string descripcion)
        {
            this.descripcion = descripcion;
            
        }
         public int CompareTo(object obj)
        {
            
            return this.descripcion.CompareTo(((Producto)obj).descripcion);
        }
        public override string ToString()
        {
            return descripcion;
        }
    }
}
