class Program
{
    static void Main()
    {
        Dictionary<string, string> diccionario = new Dictionary<string, string>()
        {
            {"time", "tiempo"},
            {"person", "persona"},
            {"year", "año"},
            {"way", "camino/forma"},
            {"day", "día"},
            {"thing", "cosa"},
            {"man", "hombre"},
            {"world", "mundo"},
            {"life", "vida"},
            {"hand", "mano"},
            {"part", "parte"},
            {"child", "niño/a"},
            {"eye", "ojo"},
            {"woman", "mujer"},
            {"place", "lugar"},
            {"work", "trabajo"},
            {"week", "semana"},
            {"case", "caso"},
            {"point", "punto/tema"},
            {"government", "gobierno"},
            {"company", "empresa/compañía"}
        };

        while (true)
        {
            Console.WriteLine("                   MENU"                                );
            Console.WriteLine("=======================================================");
            Console.WriteLine("                   DICCIONARIO"                         );
            Console.WriteLine("                   INGLES - ESPAÑOL"                    );
            Console.WriteLine("=======================================================");
            Console.WriteLine("1. Traducir una frase");
            Console.WriteLine("2. Ingresar más palabras al diccionario");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            if (opcion == "0") break;

            switch (opcion)
            {
                case "1":
                    Console.Write("Ingrese la frase: ");
                    string frase = Console.ReadLine();
                    string[] palabras = frase.Split(' ');
                    string fraseTraducida = "";

                    foreach (string palabra in palabras)
                    {
                        string palabraMinuscula = palabra.ToLower();

                        if (diccionario.ContainsKey(palabraMinuscula))
                        {
                            fraseTraducida += diccionario[palabraMinuscula] + " ";
                        }
                        else
                        {
                            fraseTraducida += palabra + " ";
                        }
                    }

                    Console.WriteLine("Su frase traducida es: " + fraseTraducida.Trim());
                    break;

                case "2":
                    Console.Write("Ingrese la palabra en inglés: ");
                    string palabraIngles = Console.ReadLine().ToLower();

                    Console.Write("Ingrese la traducción en español: ");
                    string palabraEspanol = Console.ReadLine().ToLower();

                    if (!diccionario.ContainsKey(palabraIngles))
                    {
                        diccionario.Add(palabraIngles, palabraEspanol);
                        Console.WriteLine("Palabra añadida correctamente.");
                    }
                    else
                    {
                        Console.WriteLine("La palabra ya existe en el diccionario.");
                    }
                    break;

                default:
                    Console.WriteLine("Opción no válida. Intente nuevamente.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
