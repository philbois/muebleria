using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    internal class Silla:Producto
    {
        public Silla(string descripcion) : base(descripcion)
        {

        }
        public void Detalle(int material, double precio)
        {
            this.material = material;
            this.precioBase= precio;   
        }
        override public double precio()
        {
            return precioBase*(1+material*0.25);
        }
        

    }
}
