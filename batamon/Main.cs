using System.Diagnostics;

namespace batamon
{
    public class Batamon1
    {
        public static void Main()
        {
            // El usuario ingresa la cantidad de enfrentamientos que habrá.
            
            var firstline = Console.ReadLine();
            int N = int.Parse(firstline);

            // Si la cantidad de enfrentamientos es menor a 1 o mayor a 200.000, tira 
            // una excepción.

            if (N < 1 || N > 200000)
                throw new Exception("Error. Cantidad de enfrentamientos menor a 1 o mayor a 200.000.");

            // El usuario ingresa los niveles de poder de los monstruos de la hechicera

            var secondline = Console.ReadLine();
            var unparsedhechicera = secondline.Split(' ');
            var hechicera = new List<int>();
            foreach (var unparsed in unparsedhechicera)
            {
                hechicera.Add(int.Parse(unparsed));
            }

            // El usuario ingresa los niveles de poder de los monstruos del rival.

            var thirdline = Console.ReadLine();
            var unparsedrival = thirdline.Split(' ');
            var rival = new List<int>();
            foreach (var unparsed in unparsedrival)
            {
                rival.Add(int.Parse(unparsed));
            }

            // Si la cantidad de niveles ingresados de los monstruos de la hechicera o
            // del rival no es la misma que la cantidad de enfrentamientos, tira una
            // excepción.

            if (hechicera.Count != N || rival.Count != N)
                throw new Exception("Error. Cantidad de niveles ingresados no coincide con el primer parámetro.");

            // Envía los parámetros a la función "batamon" y muestra el resultado en pantalla.

            Console.WriteLine("\nEnfrentamientos ganados:");
            Console.WriteLine(batamon(hechicera, rival));
            }
    
        public static int batamon(List<int> hechicera, List<int> rival)
        {
            // En el caso de que se esté testeando desde el TDD, las siguientes líneas
            // verifican que la cantidad de niveles entre los dos bandos sean iguales.

            if (hechicera.Count != rival.Count)
                throw new Exception("Cantidad de niveles diferentes entre los monstruos de la hechicera y del rival.");

            // Si el nivel de algun monstruo se encuentra fuera del rango, tira una
            // excepcion

            if (hechicera.Any(hechicera => hechicera < 1 || hechicera > 1000000) || 
                rival.Any(rival => rival < 1 || rival > 1000000))
                throw new Exception("Nivel de monstruos fuera de rango.");

            // Inicializo el resultado a devolver
            
            int result = 0;

            // Ordeno la lista de niveles de los monstruos en forma ascendente y descendente

            hechicera.Sort();

            rival.Sort();
            rival.Reverse();

            // En el siguiente for, el aplicativo va fijándose por cada monstruo de la
            // hechicera si es que hay un rival de menor o igual nivel, si es así, sube
            // el puntaje de la hechicera y descarta al monstruo enemigo del listado.
            // En caso contrario, sigue buscando con el siguiente monstruo de la hechicera
            // hasta ya haber pasado por todos.

            for (int i = 0; i < hechicera.Count; i++)
            {
                for (int j = 0; j < rival.Count; j++)
                {
                    if (hechicera[i] >= rival[j])
                    {
                        result++;
                        rival.RemoveAt(j);
                        break;
                    }
                }
            }

            return result;
        }
    }
}  