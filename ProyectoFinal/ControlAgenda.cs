using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class ControlAgenda
    {
        private Agenda agenda;

        public ControlAgenda(Agenda agenda)
        {
            this.agenda = agenda;
        }


        public void VerContactos()
        {

            // Limpiar la consola
            Limpiar();
            // Mostrar opciones
            MostrarMenu();
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Contacto ordenados");
                    agenda.MostrarOrdenados();

                    break;
                case "2":
                    Console.WriteLine("Contacto descendiente");
                    agenda.MostrarOrdenadosDescendientes();

                    break;
                case "3":


                    break;
                default:
                    Console.WriteLine("Su opcion no es valida");
                    break;

                
            }
            PresionaParaContinuar();
        }

        public void AgregarContacto()
        {
            Limpiar();
            Console.WriteLine("Nuevo Contacto");
            Contacto contacto= new Contacto();
            Console.Write("Nombre: ");
            contacto.Nombre=Console.ReadLine();
            Console.Write("Télefono: ");
            contacto.Telefono = Console.ReadLine();
            Console.Write("Email: ");
            contacto.Email = Console.ReadLine();

            agenda.AgregarContacto(contacto);
            Console.WriteLine("Contacto agregado exitosamente");
            PresionaParaContinuar();



        }

        public void BorrarUltimoContacto()
        {
            Limpiar();
            agenda.BorrarUltimoContacto();

            Console.WriteLine("Contacto borrado exitosamente");
            PresionaParaContinuar();

        }

        public void BuscarPorNombre()
        {
            Limpiar();

            Console.WriteLine("Buscar contacto");
            Console.Write("Nonbre: ");
            string nombre= Console.ReadLine();

            Contacto contacto=agenda.BuscarPorNombre(nombre);

            if(contacto!=null)
            {
                Console.WriteLine("Datos: \n" + contacto.ToString());
            }else
            {
                Console.WriteLine("Contacto no encontrado");
            }

            PresionaParaContinuar();


        }

        public static void AcercaDe()
        {
            Limpiar();

            Console.WriteLine("Nombre: Alexis Rojas");

            PresionaParaContinuar();

        }
        public void MostrarMenu()
        {
            StringBuilder sb=new StringBuilder();
            sb.AppendLine("1- Mostrar orden ascendente");
            sb.AppendLine("2- Mostrar orden descendente");
            sb.AppendLine("3- Volver al menú principal");
            sb.Append("Seleccione una opción:");

            Console.WriteLine(sb.ToString());

        }

        private static void PresionaParaContinuar()
        {
            Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.ReadKey();
        }
        private static void Limpiar()
        {
            Console.Clear();
        }


    }
}
