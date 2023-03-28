using System;

namespace prjArtículos
{
    public class clsTipo16 : clsArticulo
    {
        #region "Atributos" 

        private double tipo;
        private string nombre;
        private double precio;
        private double parteIva;
        private double total;

        #endregion

        #region "Constructor"

        public clsTipo16()
        {
            this.tipo = 0;
            this.precio = 0;
        }

        #endregion

        #region "Propiedades"

        public double Tipo { set => tipo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; }
        public double ParteIVA { get => this.parteIva; }
        public double Total { get => this.total; }

        #endregion

        #region "Metodos Publicos"

        public override void Articulo(string nombre)
        {
            if(nombre == "CRUCIAL PCIe")
            {
                precio = 158000;
            }
            else if(nombre == "CRUCIAL M2")
            {
                precio = 150000;
            }
        }

        public override string getNombre()
        {
            throw new NotImplementedException();
        }

        public override void setNombre(string nombre)
        {
            throw new NotImplementedException();
        }

        public override double getPrecio()
        {
            return total = precio + parteIva;
        }

        public override double getTipo()
        {
            return tipo;
        }

        public override double parteIVA()
        {
            return parteIva = precio * 0.19;
        }

        public void Calcular()
        {
            Articulo(nombre);
            parteIVA();
            getPrecio();
        }

        #endregion
    }
}