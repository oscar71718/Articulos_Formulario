using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjArtículos
{
    public abstract class clsArticulo
    {
        private string Nombre;
        private double Precio;

        #region "metodos publicos"

        public abstract void Articulo(string nombre);

        public abstract string getNombre();

        public abstract void setNombre(string nombre);

        public abstract double getPrecio();

        public abstract double parteIVA();

        public abstract double getTipo();

        #endregion
    }
}
