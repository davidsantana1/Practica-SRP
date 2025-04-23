namespace Practica_SRP
{
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
