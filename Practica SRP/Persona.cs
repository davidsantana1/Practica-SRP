namespace Practica_SRP
{
    public class Persona
    {
        public string nombre;
        public int edad;
        public string direccion;
        public string correoElectronico;
    }

    public class Correos
    {
        public void EnviarCorreoElectronico(string mensaje)
        {
            // Lógica para enviar correo electrónico
        }
    }

    public class ImprimirPersona
    {
        public void ImprimirDatos(Persona persona)
        {
            Console.WriteLine($"Nombre: {persona.nombre}");
            Console.WriteLine($"Edad: {persona.edad}");
            Console.WriteLine($"Dirección: {persona.direccion}");
            Console.WriteLine($"Correo electrónico: {persona.correoElectronico}");
        }
    }
}
