

using System;
using System.Runtime.InteropServices;

namespace PrincipioSRP
{
    public class Persona
    {
        public string nombre;
        public int edad;
        public string dirrecion;
        public string correoElectronico;

        public Persona(string nombre, int edad, string direccion, string correoElectronico)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dirrecion = direccion;
            this.correoElectronico = correoElectronico;
        }
    }

    public class EnviarCorreo
    {
        public string message;
        public string receptor;

        public EnviarCorreo(string message, string receptor)
        {
            this.message = message;
            this.receptor = receptor;
        }
    }

    public class ImprimirDatos
    {
        private Persona _persona;
        private EnviarCorreo _enviarCorreo;

        public ImprimirDatos(Persona persona, EnviarCorreo enviarCorreo)
        {
            _persona = persona;
            _enviarCorreo = enviarCorreo;
        }

        public void Imprimir()
        {
            Console.WriteLine($"Nombre: {_persona.nombre}");
            Console.WriteLine($"Edad: {_persona.edad}");
            Console.WriteLine($"Dirección: {_persona.dirrecion}");
            Console.WriteLine($"Correo Electronico: {_persona.correoElectronico}\n");
            Console.WriteLine($"Receptor: {_enviarCorreo.receptor}");
            Console.WriteLine($"mensaje: {_enviarCorreo.message}");

        }
    }
}
