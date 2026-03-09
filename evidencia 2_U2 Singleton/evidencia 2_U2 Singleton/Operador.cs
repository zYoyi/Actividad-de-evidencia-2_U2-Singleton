using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evidencia_2_U2_Singleton
{
    public class Operador
    {
        public int Id_Operador { get; set; }
        public string Nombre { get; set; }

        public Operador(int id, string nombre)
        {
            Id_Operador = id;
            Nombre = nombre;
        }

        public void AtiendeEmergencia(string tipoEmergencia)
        {
            Console.WriteLine($"Operador {Nombre} atendiendo emergencia de tipo: {tipoEmergencia}");

            switch (tipoEmergencia)
            {
                case "Intento de suicidio":
                    Console.WriteLine("Enviando unidades de apoyo y rescate.");
                    break;

                case "Incendio":
                    Console.WriteLine("Enviando bomberos.");
                    break;

                case "Accidente":
                    Console.WriteLine("Enviando paramédicos y oficiales.");
                    break;

                case "Violacion":
                    Console.WriteLine("Enviando una patrulla.");
                    break;

                case "Robo":
                    Console.WriteLine("Enviando patrullas de seguridad.");
                    break;

                case "Asalto":
                    Console.WriteLine("Enviando apoyo policial inmediato.");
                    break;

                case "Emergencia medica":
                    Console.WriteLine("Enviando ambulancia.");
                    break;

                case "Fuga de gas":
                    Console.WriteLine("Enviando bomberos y personal especializado.");
                    break;

                default:
                    Console.WriteLine("Tipo de emergencia no reconocido.");
                    break;
            }
        }
    }
}