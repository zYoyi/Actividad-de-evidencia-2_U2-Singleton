using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evidencia_2_U2_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // Verificar la única instancia del Singleton
            Central_911 central1 = Central_911.Obtener_Instancia();
            Central_911 central2 = Central_911.Obtener_Instancia();
            Central_911 central3 = Central_911.Obtener_Instancia();

            Console.WriteLine("=== Verificación de Singleton ===");
            Console.WriteLine("central1 == central2: " + ReferenceEquals(central1, central2));
            Console.WriteLine("central2 == central3: " + ReferenceEquals(central2, central3));
            Console.WriteLine("central1 == central3: " + ReferenceEquals(central1, central3));

            if (ReferenceEquals(central1, central2) && ReferenceEquals(central2, central3))
            {
                Console.WriteLine("Sí, solo existe una única instancia de Central_911.");
            }
            else
            {
                Console.WriteLine("No, se crearon múltiples instancias.");
            }

            Console.WriteLine("\n=== Operadores disponibles ===");
            Operador op1 = new Operador(1, "Laura");
            Operador op2 = new Operador(2, "Carlos");
            Operador op3 = new Operador(3, "Ana");
            Operador op4 = new Operador(4, "Miguel");
            Operador op5 = new Operador(5, "Sofia");

            Console.WriteLine($"{op1.Id_Operador} - {op1.Nombre}");
            Console.WriteLine($"{op2.Id_Operador} - {op2.Nombre}");
            Console.WriteLine($"{op3.Id_Operador} - {op3.Nombre}");
            Console.WriteLine($"{op4.Id_Operador} - {op4.Nombre}");
            Console.WriteLine($"{op5.Id_Operador} - {op5.Nombre}");

            Console.WriteLine("\n=== Registro de llamadas ===");
            central1.ConectarLlamada(op1, "Incendio");
            central2.ConectarLlamada(op2, "Violacion");
            central3.ConectarLlamada(op3, "Accidente");
            central1.ConectarLlamada(op4, "Intento de suicidio");
            central2.ConectarLlamada(op5, "Robo");
            central3.ConectarLlamada(op1, "Asalto");
            central1.ConectarLlamada(op2, "Emergencia medica");
            central2.ConectarLlamada(op3, "Fuga de gas");
            central3.ConectarLlamada(op4, "Incendio");
            central1.ConectarLlamada(op5, "Accidente");

            Console.WriteLine($"\nTotal de llamadas atendidas por la única central: {central1.TotalLlamadas}");

            Console.ReadKey();
        }
    }
}
