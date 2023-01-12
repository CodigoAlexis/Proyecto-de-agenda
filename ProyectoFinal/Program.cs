using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class Program
    {
        static ControlAgenda control = new ControlAgenda(new Agenda());
        static void Main(string[] args)
        {
            string opcion = "";
            do
            {
                Console.Clear();

                Console.WriteLine("Agenda de contactos");
                ImprimirMenu();
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":

                        control.VerContactos();
                        break;
                    case "2":
                        control.AgregarContacto();

                        break;
                    case "3":
                        control.BorrarUltimoContacto();

                        break;
                    case "4":
                        control.BuscarPorNombre();

                        break;
                    case "5":
                        ControlAgenda.AcercaDe();

                        break;
                    case "6":


                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                } 
            } while (opcion!="6");





            Console.ReadKey();
        }

        static void ImprimirMenu()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("1- Ver contactos");
            sb.AppendLine("2- Agregar contactos");
            sb.AppendLine("3- Borra ultimo contacto");
            sb.AppendLine("4- Buscar contacto por nombre");
            sb.AppendLine("5- Acerca de");
            sb.AppendLine("6- Salir");

            sb.Append("Seleccione una opción");

            Console.WriteLine(sb.ToString());

        }
    }
}
