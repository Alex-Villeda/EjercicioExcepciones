class Program
{
    static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("Elija una operación:");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Salir");

            Console.Write("Opción: ");
            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Opción no válida. Por favor, introduzca un número.");
                continue;
            }

            if (opcion < 1 || opcion > 5)
            {
                Console.WriteLine("Opción no válida. Por favor, elija una opción del 1 al 5.");
                continue;
            }

            if (opcion == 5)
            {
                Console.WriteLine("Saliendo del programa. ¡Hasta luego!");
                break;
            }

            Console.Write("Ingrese el primer número: ");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Entrada no válida. Por favor, introduzca un número.");
                continue;
            }

            Console.Write("Ingrese el segundo número: ");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Entrada no válida. Por favor, introduzca un número.");
                continue;
            }

            try
            {
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine($"Resultado: {Operaciones.Sumar(num1, num2)}");
                        break;
                    case 2:
                        Console.WriteLine($"Resultado: {Operaciones.Restar(num1, num2)}");
                        break;
                    case 3:
                        Console.WriteLine($"Resultado: {Operaciones.Multiplicar(num1, num2)}");
                        break;
                    case 4:
                        Console.WriteLine($"Resultado: {Operaciones.Dividir(num1, num2)}");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

        } while (opcion != 5);
    }
}