using System;
using System.Linq;

namespace AhorcadoNetCore
{
    public static class Logica
    {
        public static string[] arrayPalabras = new string[15];
        static int vidas;
        public static void CargarPalabras()
        {
            arrayPalabras[0] = "PERRO";
            arrayPalabras[1] = "GATO";
            arrayPalabras[2] = "OBJETO";
            arrayPalabras[3] = "CALAMAR";
            arrayPalabras[4] = "INVIERNO";
            arrayPalabras[5] = "VERANO";
            arrayPalabras[6] = "PLANETARIO";
            arrayPalabras[7] = "DEPORTES";
            arrayPalabras[8] = "PROGRAMACION";
        }

        public static void AgregarPalabraNueva()
        {
            string datoIngresado;
            Console.WriteLine("Ingrese nueva palabra:");
            datoIngresado = Console.ReadLine().ToUpper().Trim();
            while (!Funciones.ValidarSiPalabraEsValida(datoIngresado))
            {
                datoIngresado = Console.ReadLine().ToUpper().Trim();
            }

            int indice = Funciones.RetornarIndiceEspacioDisponible(arrayPalabras);
            if (indice != -1)
            {
                arrayPalabras[indice] = datoIngresado;
                Console.WriteLine("Nueva palabra agregada");
                Funciones.PresioneUnaTeclaParaContinuar();
            }
        }


        public static bool ComenzarJuego()
        {
            Console.Clear();
            #region Variables
            vidas = 5;
            string palabraSecreta = Funciones.RetornarPalabraRandom(arrayPalabras);
            int recuento = -1;
            char[] arrayLetrasPalabraSecreta = palabraSecreta.ToCharArray();
            char[] mostrarArrayProgreso = new char[palabraSecreta.Length];
            char[] letrasArriesgadas = new char[26];
            int indiceLetrasArriesgadas = 0;
            bool victoria = false;
            char letraArriesgada;
            #endregion

            foreach (char letra in mostrarArrayProgreso)
            {
                recuento++;
                mostrarArrayProgreso[recuento] = '_';
            }

            while (vidas > 0)
            {
                recuento = -1;
                string mostrarProgreso = String.Concat(mostrarArrayProgreso);
                bool letraEncontrada = false;
                int multiples = 0;

                if (mostrarProgreso == palabraSecreta)
                {
                    victoria = true;
                    break;
                }
                if (vidas > 1)
                {
                    Console.WriteLine("Tenes {0} vidas!", vidas);
                }
                else
                {
                    Console.WriteLine("Te quedan solo {0} vidas!", vidas);
                }
                Console.Write("\n");
                Console.WriteLine("Palabra: " + mostrarProgreso);
                Console.Write("\n\n\n");
                Console.Write("Ingresa una letra: ");

                letraArriesgada = Convert.ToChar(Funciones.IngresarLetra());

                Console.Clear();

                if (letrasArriesgadas.Contains(letraArriesgada) == false)
                {

                    letrasArriesgadas[indiceLetrasArriesgadas] = letraArriesgada;
                    indiceLetrasArriesgadas++;

                    foreach (char letter in arrayLetrasPalabraSecreta)
                    {
                        recuento++;
                        if (letter == letraArriesgada)
                        {
                            mostrarArrayProgreso[recuento] = letraArriesgada;
                            letraEncontrada = true;
                            multiples++;
                        }
                    }

                    if (letraEncontrada && multiples > 1)
                    {
                        Console.WriteLine("Bien! La letra {1} aparece {0} veces!", multiples, letraArriesgada);
                    } else if(letraEncontrada && multiples == 1)
                    {
                        Console.WriteLine("Bien! Encontraste la letra {0}!", letraArriesgada);
                    }
                    else
                    {
                        Console.WriteLine("Mmm... la letra {0} no aparece!", letraArriesgada);
                        vidas--;
                    }

                }
                else
                {
                    Console.WriteLine("La letra {0} ya la dijiste!", letraArriesgada);
                }

                Logica.DibujarPersonaje(vidas);

            }

            Console.WriteLine("\n\nLa palabra era: {0}", palabraSecreta);
            if (victoria)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\nGANASTEEEEEEEEEE, FELICIDADES!!!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\nNOOOOOOOOOO, PERDISTE!!!");
            }
            Console.ResetColor();
            return Funciones.SeguirEn("jugando");

        }

        public static void DibujarPersonaje(int vidasRestantes)
        {
            ConsoleColor aux = ConsoleColor.White;
            string dibujo = "";

            if (vidasRestantes < 5)
            {
                dibujo += "--------\n";
                aux = ConsoleColor.Green;
            }

            if (vidasRestantes < 4)
            {
                dibujo += "       |\n";
                aux = ConsoleColor.Yellow;
            }

            if (vidasRestantes < 3)
            {
                dibujo += "       O\n";
                aux = ConsoleColor.Yellow;
            }

            if (vidasRestantes < 2)
            {
                dibujo += "      /|\\ \n";
                aux = ConsoleColor.Red;
            }

            if (vidasRestantes == 0)
            {
                dibujo += "      / \\ \n";
                aux = ConsoleColor.Red;
            }

            Console.ForegroundColor = aux;
            Console.WriteLine(dibujo);
            Console.ResetColor();
        }

        public static string IngresarPalabraNueva()
        {
            string nuevaPalabra = Console.ReadLine();

            while (!Funciones.ValidarSiPalabraEsValida(nuevaPalabra) || !LaPalabraEstaCargada(nuevaPalabra.ToUpper()))
            {
                Console.WriteLine("Esa palabra no esta en la lista");
                Console.Write("Reingrese palabra: ");
                nuevaPalabra = Console.ReadLine();
            }

            return nuevaPalabra.ToUpper();
        }

        public static bool LaPalabraEstaCargada(string palabraAValidar)
        {
            int recuento = 0;
            bool respuesta = false;

            foreach (string itemPalabra in arrayPalabras)
            {
                if (itemPalabra == palabraAValidar)
                {
                    respuesta = true;
                    break;
                }
                recuento++;
            }

            return respuesta;
        }

        public static void MostrarPalabras()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Lista de palabras cargadas: \n");

            Console.ResetColor();

            foreach (string itemPalabra in arrayPalabras)
            {
                if(itemPalabra is not null)
                {
                    Console.WriteLine("- " + itemPalabra);
                }
            }
        }

        public static void EliminarPalabra()
        {
            string palabraAEliminar;
            int recuento = 0;

            
            MostrarPalabras();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nIngresar la palabra que desea eliminar: ");
            Console.ResetColor();

            palabraAEliminar = IngresarPalabraNueva();

            foreach (string itemPalabra in arrayPalabras)
            {
                if (itemPalabra == palabraAEliminar)
                {
                    arrayPalabras[recuento] = null;
                    break;
                }
                recuento++;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Palabra eliminada correctamente!\n");

            Funciones.PresioneUnaTeclaParaContinuar();
        }
    }
}
