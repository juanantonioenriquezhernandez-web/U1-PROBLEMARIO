// Importamos las librerías básicas de C# para poder usar comandos como Console.WriteLine
using System;
// Definimos el espacio de trabajo de nuestro programa
namespace Ejercicio1
{ // Creamos la clase principal
    class Program
    {
        // Función principal donde inicia la ejecución del programa
        static void Main(string[] args)
        {
            // Muestra en la pantalla el título del problema
            Console.WriteLine("=== EJERCICIO 1: CÁLCULO DE POTENCIA ELÉCTRICA DE UN MOTOR CD ===");

            // Muestra en la pantalla la explicación de lo que hace el programa
            Console.WriteLine("Calcula la potencia P = V * I y clasifica el consumo del motor.\n");

            // Le pide al usuario que escriba el voltaje
            Console.Write("Ingrese el voltaje (V): ");

            // Lee la línea que escribió el usuario en el teclado y la convierte a un número decimal (double)
            double v = Convert.ToDouble(Console.ReadLine());

            // Le pide al usuario que escriba la corriente
            Console.Write("Ingrese la corriente (A): ");

            // Lee el texto ingresado por el usuario y lo convierte a número decimal (double)
            double i = Convert.ToDouble(Console.ReadLine());

            // Multiplica el voltaje por la corriente para obtener la potencia y la guarda en la variable 'p'
            double p = v * i;

            // Muestra en pantalla el resultado numérico de la potencia calculada
            Console.WriteLine($"\nPotencia calculada: {p} W");

            // Revisa si la potencia calculada es menor o igual a 120 Watts
            if (p <= 120)
            {
                // Si la potencia es 120 o menos, muestra que el consumo es normal
                Console.WriteLine("Estado: CONSUMO NORMAL");
            }
            // Si la condición de arriba no se cumple (es decir, la potencia es mayor a 120 Watts)
            else
            { // Muestra un mensaje de advertencia por consumo elevado
                Console.WriteLine("Estado: ADVERTENCIA: CONSUMO ELEVADO");
            }
        }
    }
}