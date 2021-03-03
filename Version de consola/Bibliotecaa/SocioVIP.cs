using System;
using System.Collections.Generic;

namespace Bibliotecaa
{
    public class SocioVIP : Socio
    {
        //ATRIBUTOS 
        private double cuotaMensual;

        //getter y setter
        public double CuotaMensual { get => cuotaMensual; set => cuotaMensual = value; }

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

        public override void Imprimir()
        {
            Console.WriteLine("Socio Vip");
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Apellido: " + Apellido);
            Console.WriteLine("ID: " + NumeroID);
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
