using System;
namespace ej1
{
    public class Prestamo
    {
        //atributos
        private Socio socio;
        private Ejemplar ejemplar;
        private DateTime fecha;

        //getters y setters
        public Socio Socio { get { return socio;} set { socio = value; }}
        public Ejemplar Ejemplar { get { return ejemplar;} set { ejemplar = value; }}
        public DateTime Fecha { get { return fecha;} set { fecha = value; }}

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
        
        public String ImprimirPrestamo(){
        	return "El ejemplar " + ejemplar.Imprimir() + "\n" +
        		"ha sido prestado al socio " + socio.Nombre + " " + socio.Apellido + "\n" +
        		" el dia y hora " + fecha.ToString();
        }
    }
}
