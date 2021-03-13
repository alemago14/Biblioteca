using System;
using System.Collections.Generic;

namespace ej1
{
    public class SocioVIP : Socio
    {
        //ATRIBUTOS 
        private double cuotaMensual;

        //getter y setter
        public double CuotaMensual { get { return cuotaMensual;} set { cuotaMensual = value;} }

        //constructor por defecto
        public SocioVIP()
        {
        }

        public SocioVIP(string nombre, string apellido, int numeroID, double cuotaMensual)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.numeroID = numeroID;
            cantMaxima = 15;
            this.cuotaMensual = cuotaMensual;
            ejemplaresRetirados = new List<Ejemplar>();
        }

        //METODOS HEREDADOS
        public override bool ConsultarCupo()
        {
            if (ejemplaresRetirados.Count <= 15)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void PedirPres(Ejemplar ej1)
        {
            base.PedirPres(ej1);
        }

        public override Ejemplar DevolverEj(String nLibro)
        {
            return base.DevolverEj( nLibro);
        }

        public override String Imprimir()
        {
           return "Socio Vip" + "\n" 
            + "Nombre: " + Nombre + "\n" +
            "Apellido: " + Apellido + "\n" +
            	"ID: " + NumeroID;
        }

        public override bool ConsultarCant()
        {
            return base.ConsultarCant();
        }

        public override void ImprimirE()
        {
            base.ImprimirE();
        }
    }
}
