using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> diccionario = new Dictionary<string, string>()
        {
            {"day","día"},
            {"world","mundo"},
            {"life","vida"},
            {"man","hombre"},
            {"woman","mujer"},
            {"time","tiempo"},
            {"year","año"},
            {"eye","ojo"},
            {"hand","mano"},
            {"work","trabajo"}
        };

        int opcion;

        do
        {
            Console.WriteLine("\n====== MENÚ ======");
            Console.WriteLine("1. Traducir frase");
            Console.WriteLine("2. Agregar palabra");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1)
            {
                Console.Write("Ingrese frase: ");
                string frase = Console.ReadLine();
                string[] palabras = frase.Split(' ');
                string traduccion = "";

                foreach (string palabra in palabras)
                {
                    string p = palabra.ToLower();

                    if (diccionario.ContainsKey(p))
                        traduccion += diccionario[p] + " ";
                    else
                        traduccion += palabra + " ";
                }

                Console.WriteLine("Traducción: " + traduccion);
            }

            else if (opcion == 2)
            {
                Console.Write("Palabra en inglés: ");
                string ingles = Console.ReadLine().ToLower();

                Console.Write("Traducción en español: ");
                string espanol = Console.ReadLine().ToLower();

                diccionario[ingles] = espanol;
                Console.WriteLine("Palabra agregada correctamente.");
            }

        } while (opcion != 0);
    }
}
