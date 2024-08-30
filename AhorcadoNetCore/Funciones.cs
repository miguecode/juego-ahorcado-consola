using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AhorcadoNetCore
{
    public static class Funciones
    {
        static Random numRandom = new Random();

        public static bool ValidarSiPalabraEsValida(string palabra)
        {
            bool palabraTesteada = palabra.All(Char.IsLetter);

            while (palabraTesteada == false || palabra.Length == 0)
            {
                return false;
            }

            return true;
        }

        public static string RetornarPalabraRandom(string[] arrayPalabras)
        {
            int cantidadPalabras = arrayPalabras.Length - 1;
            int numeroRandom = numRandom.Next(0, cantidadPalabras);
            while (string.IsNullOrEmpty(arrayPalabras[numeroRandom]))
            {
                numeroRandom = numRandom.Next(0, cantidadPalabras);
            }

            return Logica.arrayPalabras[numeroRandom];
        }


        public static int RetornarIndiceEspacioDisponible(string[] arrayPalabras)
        {
            int posicion = -1;
            for (int i = 0; i < arrayPalabras.Length; i++)
            {
                if (string.IsNullOrEmpty(arrayPalabras[i]))
                {
                    posicion = i;
                    break;
                }

            }
            return posicion;

        }

        public static string IngresarLetra()
        {

            char letra = Console.ReadKey(true).KeyChar;

            while (!char.IsLetter(letra))
            {
                Console.WriteLine("Por favor,ingresá una letra valida");
                letra = Console.ReadKey(true).KeyChar;
            }

            return letra.ToString().ToUpper();
        }


        public static int ValidarEntero(int opcionMin, int opcionMax)
        {
           int opcion;

            while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < opcionMin || opcion > opcionMax)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error,reingrese opcion valida.\nIngrese una opcion entre {0} y {1}", opcionMin, opcionMax);
            }
            Console.ResetColor();

            return opcion;
        }


        public static string ValidarSoN(string auxDatoIngresado)
        {
            while (string.IsNullOrEmpty(auxDatoIngresado) || (auxDatoIngresado.ToLower().Trim() != "s" && auxDatoIngresado.ToLower().Trim() != "n"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error,reingrese opcion valida.\nIngrese una opcion entre S o N");
                auxDatoIngresado = Funciones.leerTecla();
            }
            Console.ResetColor();

            return auxDatoIngresado.ToLower();

        }


        public static bool SeguirEn(string auxUbicacion)
        {
            string datoIngresado;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nDesea continuar " + auxUbicacion.ToUpper() + "?\n");

            MostrarPresionarTecla("S", " para reiniciar el juego");
            MostrarPresionarTecla("N", " para volver al Menu Principal");

            datoIngresado = Funciones.ValidarSoN(Funciones.leerTecla());

            if (datoIngresado == "s")
                return true;
            else
                return false;

        }

        private static void MostrarPresionarTecla(string tecla, string msj)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nPresione ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write(" " + tecla + " ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(msj);
            Console.WriteLine();
        }


        public static void PresioneUnaTeclaParaContinuar()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\n Presione una tecla para continuar");
            Console.ResetColor();
            Console.ReadKey();
        }


        public static string leerTecla()
        {
            return Console.ReadKey(true).KeyChar.ToString();
        }

    }
}
