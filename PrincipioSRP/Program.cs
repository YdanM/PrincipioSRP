using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipioSRP
{
    public class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("Ydan",19,"C/Sombrero","Idanmonegro@gmail.com");

            EnviarCorreo enviar = new EnviarCorreo("Esta es la tarea de programación","Francis Ramirez");

            ImprimirDatos datos = new ImprimirDatos(persona, enviar);
            datos.Imprimir();
            Console.ReadKey();
        }
    }
}
