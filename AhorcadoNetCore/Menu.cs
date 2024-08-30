using System;
using System.Collections.Generic;
using System.Text;

namespace AhorcadoNetCore
{
  public static class Menu
  {
        public static void MenuPrincipal()
        {
            int opcionIngresada;
            bool reiniciarJuego = true;
            bool seguirEnElPrograma = true;
            do
            {
                Console.Clear();
                DibujarEncabezado("Bienvenido al Ahorcado!");
                DibujarMenuPrincipal();

                opcionIngresada = Funciones.ValidarEntero(0, 4);
                Console.Clear();

                switch (opcionIngresada)
                {
                    case 1:
                        do
                        {
                            reiniciarJuego = Logica.ComenzarJuego();

                        } while(reiniciarJuego);
                        Console.Clear();
                    break;
                    case 2:
                        Logica.AgregarPalabraNueva();
                    break;

                    case 3:
                        Logica.MostrarPalabras();
                        Funciones.PresioneUnaTeclaParaContinuar();
                    break;

                    case 4:
                        Logica.EliminarPalabra();
                    break;

                    case 0:
                        Console.WriteLine("Gracias por jugar!");
                        seguirEnElPrograma = false;
                    break;
                }

            } while (seguirEnElPrograma);

        }


        public static void DibujarEncabezado(string textoAMostrar)
        {
            string titulo = "*****  " + textoAMostrar.Trim() + "  *****";
            string asteriscos = string.Empty;

            for (int i = 0; i < titulo.Length; i++)
            {
                asteriscos += "*";
            }

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(asteriscos);
            Console.WriteLine(titulo);
            Console.WriteLine(asteriscos);
            Console.WriteLine();
        }

        static void DibujarMenuPrincipal()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Menu Principal");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("| 1 | Iniciar Juego");
            Console.WriteLine("| 2 | Agregar Palabra Nueva");
            Console.WriteLine("| 3 | Mostrar Palabras Cargadas");
            Console.WriteLine("| 4 | Eliminar Palabra");
            Console.WriteLine("| 0 | Salir");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Ingrese la opcion deseada:");

            Console.ResetColor();
        }
  }
}
