using System;

namespace SwitchStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            // Estructura de Control Switch.

            var variable = 6.0; // Iniciaremos con un valor por defecto en decimal.

            // Realizaremos el proceso con un switch divididos por cases.

            switch (variable)
            {
                case > 8.0: // Opción 1 dependiendo de la variable anterior a declarar.
                    Console.WriteLine("Estás en el nivel avanzado");
                    break;

                case >= 5.5: // Opción 2 dependiendo de la variable anterior a declarar.
                    Console.WriteLine("Estás en el nivel intermedio");
                    break;

                case >= 4.0: // Opción 3 dependiendo de la variable anterior a declarar.
                    Console.WriteLine("Estás en el nivel básico");
                    break;

                default: // En caso contrario si es que no cumple con estas dos opciones.
                    Console.WriteLine("NO HAY EXISTENCIAS");
                    break;
            }
            Console.WriteLine("SE ACABÓ EL SWITCH");
        }
    }
}