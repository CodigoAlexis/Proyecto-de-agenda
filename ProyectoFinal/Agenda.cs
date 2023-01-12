using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class Agenda
    {
        private const int TAM = 10;
        private Contacto[] contactos;
        private int indice;

        public int NumeroContactos
        {
            get
            {
                return indice;
            }
        }

        public Agenda()
        {
            indice = 0;
            contactos= new Contacto[TAM];
        }

        public void AgregarContacto(Contacto contacto)
        {
            if(indice<TAM)
            {
                contactos[indice] = contacto;
                indice++;
            }else
            {
                Console.WriteLine("Agenda llena");
            }
        }

        public void BorrarUltimoContacto()
        {
            if(indice>0)
            {
                contactos[indice] = null;
                indice--;
            }else
            {
                Console.WriteLine("La agenda ya está vacía");
            }
        }

        private bool NoHayContactos()
        {
            if(indice==0)
            {
                Console.WriteLine("No hay contactos");
                return true;
            }else
            {
                return false;
            }
        }
        public void MostrarOrdenados()
        {
            if(NoHayContactos())
            {
                return;
            }
            Contacto[] ordenados = new Contacto[indice];
            Array.Copy(contactos, ordenados, indice);
            Array.Sort(ordenados);

            Console.WriteLine(CadenaContactos(ordenados));


        }

        public void MostrarOrdenadosDescendientes()
        {
            if (NoHayContactos())
            {
                return;
            }
            Contacto[] ordenados = new Contacto[indice];
            Array.Copy(contactos, ordenados, indice);
            Array.Sort(ordenados);
            Array.Reverse(ordenados);

            Console.WriteLine(CadenaContactos(ordenados));


        }

        public Contacto BuscarPorNombre(string nombre)
        {
            foreach(Contacto contacto in contactos)
            {
                if(contacto!=null&&contacto.Nombre==nombre)
                {
                    return contacto;
                }
            }
            return null;
        }

        public void MostrarContactos()
        {
            Console.WriteLine(this);
        }
        public override string ToString()
        {
            return CadenaContactos(contactos);
        }

        private string CadenaContactos(Contacto[]personas)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < indice; i++)
            {

                if (contactos[i] == null) { continue; }

                string dato = string.Format("{0}. {1}", i + 1, personas[i]);
                sb.AppendLine(dato);
            }

            return sb.ToString();

        }


    }
}
