using System;
using System.Collections.Generic;
using System.Threading;

namespace Bibliotecaa
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Socio> soc1 = new List<Socio>();
            List<Libro> libros = new List<Libro>();
            List<Ejemplar> ejem = new List<Ejemplar>();
            List<Ejemplar> ejem2 = new List<Ejemplar>();
            List<Ejemplar> ejem3 = new List<Ejemplar>();
            Ejemplar ele;
            int ide = 0;
            int i = 0, ind = 987, inde = 987;
            //Listas de socios anteriores

            Socio s1 = new Socio("Pedro", "Picapiedra", 101);
            SocioVIP s2 = new SocioVIP("Pablo", "Marmol", 102, 30);
            soc1.Add(s1);
            soc1.Add(s2);

            //Listas de libros
            Libro l1 = new Libro("El codigo da vinci", "Dan Bronw", 97898758, ejem);
            Libro l2 = new Libro("Inferno", "Dan Bronw", 13244567, ejem2);
            Libro l3 = new Libro("Origen", "Dan Bronw", 12345678, ejem3);

            libros.Add(l1);
            libros.Add(l2);
            libros.Add(l3);

            //lista de ejemplares
            Ejemplar e1 = new Ejemplar(l1, 3, 33);
            Ejemplar e2 = new Ejemplar(l1, 3, 34);
            Ejemplar e3 = new Ejemplar(l1, 3, 35);

            ejem.Add(e1);
            ejem.Add(e2);
            ejem.Add(e3);


            Ejemplar e11 = new Ejemplar(l2, 6, 28);
            Ejemplar e21 = new Ejemplar(l2, 2, 29);
            Ejemplar e31 = new Ejemplar(l2, 3, 25);

            ejem2.Add(e11);
            ejem2.Add(e21);
            ejem2.Add(e31);



            Console.WriteLine("Bienvenido Biblioteca");

            int opcion = 0;
            while (opcion != 9)
            {
                Console.WriteLine("Ingrese numero para continuar");
                Console.WriteLine("1. Para visualizar Socios");
                Console.WriteLine("2. Para Visualizar Libros");
                Console.WriteLine("3. Para pedir Libro");
                Console.WriteLine("4. Para devolver Libro");
                Console.WriteLine("5. Para Agregar nuevo libro a la biblioteca");
                Console.WriteLine("9. Para salir");

                String cad = Console.ReadLine();
                opcion = int.Parse(cad);


                switch (opcion)
                {
                    case 1:
                        Console.Clear();

                        Console.WriteLine("Ingrese 1 para ver los socios actuales");
                        Console.WriteLine("Ingrese 2 para Crear un nuevo socios");

                        cad = Console.ReadLine();
                        opcion = int.Parse(cad);

                        switch (opcion)
                        {
                            case 1:
                                for (i = 0; i <= soc1.Count - 1; i++)
                                {
                                    soc1[i].Imprimir();
                                    Console.WriteLine(" ");
                                    Console.WriteLine("-----------");
                                    Console.WriteLine(" ");
                                }
                                break;

                            case 2:
                                Console.WriteLine("Ingrese el nombre del socio:");
                                String nombre = Console.ReadLine();

                                Console.WriteLine("Ingrese el apellido: ");
                                String apellido = Console.ReadLine();

                                Console.WriteLine("Ingrese c Para socio Clasico o v para Socio Vip");
                                String vip = Console.ReadLine();

                                ide = new Random().Next(99, 999);

                                if (vip == "v")
                                {
                                    SocioVIP sov = new SocioVIP(nombre, apellido, ide, 30);
                                    soc1.Add(sov);
                                }
                                else
                                {
                                    Socio s = new Socio(nombre, apellido, ide);
                                    soc1.Add(s);
                                }
                                break;

                            default:
                                Console.WriteLine("Ingrese un valor valido");
                                break;
                        }
                        break;

                    case 2:
                        Console.Clear();

                        Console.WriteLine("A continuacion se listaran los libros de la biblioteca y si tienen ejemplares disponibles.");
                        for (i = 0; i <= libros.Count - 1; i++)
                        {
                            Console.WriteLine("-----");
                            Console.WriteLine(" ");
                            Libro l7 = libros[i];
                            libros[i].Imprimir();
                            if (l7.Consultar() == true)
                            {
                                Console.WriteLine("Hay Ejemplares Disponibles");
                                l7.bh();
                            }
                            else
                            {
                                Console.WriteLine("No hay ejemplares disponibles");
                                l7.bh();
                            }

                        }
                        Console.WriteLine("-----");
                        break;

                    case 3:
                        //pedir libro
                        Console.Clear();

                        Console.WriteLine("Pedir Libro prestado");
                        Console.WriteLine("Ingresar el ide del socio que va a pedir un libro");
                        for(i = 0; i <= soc1.Count-1; i++)
                        {
                            Socio sov = soc1[i];
                            Console.WriteLine(" ");
                            Console.WriteLine("Socio: " + sov.Nombre + " " + sov.Apellido);
                            Console.WriteLine("Ide: " + sov.NumeroID.ToString());
                            Console.WriteLine(" ");
                            Console.WriteLine("------");

                        }

                        cad = Console.ReadLine();
                        ide = int.Parse(cad);

                        for(i=0; i <= soc1.Count - 1; i++)
                        {
                        Socio sov = soc1[i];
                            if(sov.NumeroID == ide)
                            {
                                Console.WriteLine("Usuario seleccionado: " + sov.Nombre + " " + sov.Apellido);
                                ind = i;
                            }
                        }

                        if(ind == 987)
                        {
                            Console.WriteLine("Socio no encontrado");
                            break;
                        }

                        if(soc1[ind].ConsultarCupo()== true)
                        {
                            Console.WriteLine("El socio tiene disponible cupo para retirar libros.");
                        }
                        else
                        {
                            Console.WriteLine("El socio no tiene cupo para retirar libros");

                            break;
                        }


                        Console.WriteLine("Libros Disponibles:");
                        for(i=0; i <= libros.Count - 1; i++)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("------");
                            Libro l7 = libros[i];
                            Console.WriteLine("Libro: " + l7.Nombre + " Autor: " + l7.Autor);
                            if (l7.Consultar() == true)
                            {
                                Console.WriteLine("Hay Ejemplares Disponibles");
                                l7.bh();
                            }
                            else
                            {
                                Console.WriteLine("No hay ejemplares disponibles");
                                l7.bh();
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine("------");
                        }

                        String nombreLibro = Console.ReadLine().ToLower();

                        for(i = 0; i <= libros.Count - 1; i++)
                        {
                            Libro l7 = libros[i];
                            if(l7.Nombre.ToLower() == nombreLibro)
                            {
                                Console.WriteLine("Libro: " + l7.Nombre + " seleccionado.");
                                inde = i;
                            }
                        }

                        if(inde == 987)
                        {
                            Console.WriteLine("El titulo ingresado no se encuentra en la biblioteca");
                            break;
                        }


                        if ( libros[inde].EjemplaresDisponibles.Count == 0)
                        {
                            Console.WriteLine("El libro seleccionado no tiene ejemplares disponibles");
                            break;
                        }

                        //metodo para pedir prestado el libro
                        ele = libros[inde].PrestarLibro();

                        //poner el ejemlar al socio
                        soc1[ind].PedirPres(ele);

                        Console.Clear();

                        ele.Imprimir();
                        Console.WriteLine("Prestado con exito al socio " + soc1[ind].Nombre + " " + soc1[ind].Apellido);

                        Thread.Sleep(50);

                        Console.WriteLine("saliendo");
                        break;


                    case 4:
                        //Opcion par devolver libros
                        Console.Clear();

                        int cnt = 0;

                        Console.WriteLine("Socios que tienen libros prestados: ");
                        for(i = 0; i <= soc1.Count - 1; i++)
                        {
                            Socio sov = soc1[i];
                            if(sov.ConsultarCant() == false)
                            {
                                Console.WriteLine("El socio " + sov.Nombre + " " + sov.Apellido + "n° ide: " + sov.NumeroID.ToString());
                                Console.WriteLine("Tiene Ejemplares pedidos: ");
                                sov.ImprimirE();
                                Console.WriteLine(" ");
                                Console.WriteLine(" ");
                                Console.WriteLine(" ");
                                Console.WriteLine(" ");

                                cnt = cnt + 1;
                            }
                        }

                        if(cnt == 0)
                        {
                            Console.WriteLine("Ningun socio debe libros.");
                            break;
                        }

                        Console.WriteLine("Ingrese el ide del socio que devolvera el libro: ");
                        cad = Console.ReadLine();
                        ide = int.Parse(cad);

                        for (i = 0; i <= soc1.Count - 1; i++)
                        {
                            Socio so1 = soc1[i];
                            if (so1.NumeroID == ide)
                            {
                                Console.WriteLine("Usuario seleccionado: " + so1.Nombre + " " + so1.Apellido);
                                ind = i;
                            }
                        }

                        if (ind == 987)
                        {
                            Console.WriteLine("Socio no encontrado");
                            break;
                        }

                        Socio so = soc1[ind];

                        Console.WriteLine("El socio " + so.Nombre + " " + so.Apellido + "n° ide: " + so.NumeroID.ToString());
                        Console.WriteLine("Tiene Ejemplares pedidos: ");
                        so.ImprimirE();
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");

                        Console.WriteLine("Ingresar nombre del libro a devolver :");
                        cad = Console.ReadLine();

                        int ubi = 0;

                        ele = soc1[ind].DevolverEj(cad);
                        ubi = ele.Direccion;

                        if(ubi == 0)
                        {
                            Console.WriteLine("Error");
                            break;
                        }

                        for(i = 0; i <= libros.Count - 1; i++)
                        {
                            if(ele.Libro.Nombre == libros[i].Nombre)
                            {
                                libros[i].ReingresarLibro(ele);
                            }
                        }

                        Console.Clear();

                        Console.WriteLine("El libro " + ele.Libro.Nombre + " ha sido devuelto a la biblioteca.");
                        break;

                    case 5:
                        //opcion de agregar un nuevo libro a la biblioteca

                        Console.Clear();

                        Console.WriteLine("Ingrese 1 para agregar nuevo libro.");
                        Console.WriteLine("Ingrese 2 para agregar un nuevo ejemplar a un libro existente");

                        cad = Console.ReadLine();
                        opcion = int.Parse(cad);

                        switch (opcion)
                        {
                            case 1:
                                //nuevo libro

                                Console.Clear();

                                Console.WriteLine("Nuevo libro.");
                                Console.WriteLine("Ingrese el nombre del libro");
                                String nombre = Console.ReadLine();
                                Console.WriteLine("Ingrese el nombre del autor: ");
                                String autor = Console.ReadLine();
                                int codigo = new Random().Next(9999999, 99999999);

                                Libro ln = new Libro(nombre, autor, codigo);

                                libros.Add(ln);

                                Console.Clear();
                                Console.WriteLine("Libro agregado");
                                for (i = 0; i <= libros.Count - 1; i++)
                                {
                                    if(i == libros.Count - 1)
                                    {
                                        libros[i].Imprimir();
                                    }
                                }
                                break;

                                case 2:
                                //agregar ejemplar a un libro

                                Console.Clear();

                                Console.WriteLine("Libros Actuales");
                                for (i =0;i<=libros.Count-1;i++) {
                                    libros[i].Imprimir();
                                    Console.WriteLine(" ");
                                    Console.WriteLine("------");
                                    Console.WriteLine(" ");
                                }

                                Console.WriteLine("Ingrese nombre del libro");
                                cad = Console.ReadLine();

                                for(i = 0; i <= libros.Count - 1; i++)
                                {
                                    if(cad.ToLower() == libros[i].Nombre.ToLower())
                                    {
                                        inde = i;
                                    }
                                }

                                Console.Clear();

                                if (inde == 987)
                                {
                                    Console.WriteLine("El nombre ingresado no corresponde con un titulo en la biblioteca.");
                                    break;
                                }

                                Console.WriteLine("Libro " + libros[inde].Nombre + " seleccionado.");

                                Console.WriteLine("Ingresar n° de edicion:");
                                cad = Console.ReadLine();
                                int edicion = int.Parse(cad);

                                Console.WriteLine("Ingresar la ubicacion");
                                cad = Console.ReadLine();
                                int ubic = int.Parse(cad);

                                ele = new Ejemplar(libros[inde], edicion, ubic);

                                libros[inde].AgregarEjemplar(ele);

                                Console.Clear();

                                Console.WriteLine("Ejemplar de " + libros[inde].Nombre + " agregado.");
                                break;

                            default:
                                Console.WriteLine("Opcion no disponible");
                                break;
                        }
                        break;

                    case 9:
                        Console.Clear();

                        Console.WriteLine("Saliendo");
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Opcion no valida");
                        break;
                }
            }
        }
    }
}
