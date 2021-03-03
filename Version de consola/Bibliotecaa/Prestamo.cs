using System;
namespace Bibliotecaa
{
    public class Prestamo
    {
        //atributos
        private Socio socio;
        private Ejemplar ejemplar;
        private DateTime fecha;

        //getters y setters
        public Socio Socio { get => socio; set => socio = value; }
        public Ejemplar Ejemplar { get => ejemplar; set => ejemplar = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }

        //constructor por defecto
        public Prestamo()
        {
        }


        //constructor con todos los elem de la clase
        public Prestamo(Socio socio, Ejemplar ejemplar)
        {
            this.socio = socio;
            this.ejemplar = ejemplar;
            fecha = DateTime.Now;
        }
    }
}
