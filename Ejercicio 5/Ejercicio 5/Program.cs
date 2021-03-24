using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Describe la tecla presioanda de la consola
            ConsoleKeyInfo input;
      
            do
            {
                Console.WriteLine("Ingrese CTRL+K, de lo contrario el proceso continuará");
                //Lee las teclas presionadas. Con false muestra lo presionado en la pantalla, con true no.
                input = Console.ReadKey(true);
                //Console.WriteLine(ConsoleModifiers.Control); Esto imprime control, solo para pruebas.
                //Console.WriteLine(input.Modifiers); Esto imprime el modificador que se use, solo para pruebas.
                //Console.WriteLine(input.Key); Esto imprime la tecla que se aprete, solo para pruebas.
            } while (input.Key.ToString() != "K" || input.Modifiers != ConsoleModifiers.Control);

            Console.WriteLine("Ahora agreguemos un Shift!");

            do
            {
                Console.WriteLine("Ingrese CTRL+Shift+K, de lo contrario el proceso continuará");
                input = Console.ReadKey(true);
                //Console.WriteLine(input.Modifiers); Solo para saber que modificadores se usan
            } while (input.Key.ToString() != "K" || (input.Modifiers.ToString() != "Shift, Control")); //Medio feo, porque le estoy cargando a mano el resultado Shift, Control.

            Console.WriteLine("El proceso ha finalizado exitosamente");
            Console.ReadKey();
        }
    }
}
