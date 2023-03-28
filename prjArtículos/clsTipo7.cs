using System;

namespace prjArtículos
{
    public class clsTipo7 : clsArticulo
    {
        #region "Atributos" 

        private double tipo;
        private string nombre;
        private double precio;
        private double parteIva;
        private double total;

        #endregion

        #region "Constructor"

        public clsTipo7()
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
            if (nombre == "KINGSTON PCIe")
            {
                precio = 148000;
            }
            else if (nombre == "KINGSTON M2")
            {
                precio = 140000;
            }
        }

        public override string getNombre()
        {
            return nombre;
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