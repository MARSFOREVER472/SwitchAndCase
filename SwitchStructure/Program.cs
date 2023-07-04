using System;

namespace SwitchStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            // Estructura de Control Switch.

            var variable = 9.8; // Iniciaremos con un valor por defecto en decimal.

            // Realizaremos el proceso con un switch divididos por cases.

            switch (variable)
            {
                case > 9.7: // Opción 1 dependiendo de la variable anterior a declarar.
                    Console.WriteLine("Opción patrón 1");
                    break;

                case >= 8.5: // Opción 2 dependiendo de la variable anterior a declarar.
                    Console.WriteLine("Opción patrón 2");
                    break;

                default: // En caso contrario si es que no cumple con estas dos opciones.
                    Console.WriteLine("NO HAY EXISTENCIAS");
                    break;
            }
            Console.WriteLine("SE ACABÓ EL SWITCH");
        }
    }
}