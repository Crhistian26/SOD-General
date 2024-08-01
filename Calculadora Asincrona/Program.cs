using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Ruta del archivo donde se guardarán las combinaciones
        string filePath = "combinaciones_6_digitos.txt";

        
            int[] combination = new int[6];
            GenerateCombinations( combination, 0);
       

    }

    static void GenerateCombinations(int[] combination, int position)
    {
        if (position == combination.Length)
        {
            Console.WriteLine(combination);
            
            return;
        }

        for (int i = 1; i <= 7; i++)
        {
            combination[position] = i;
            GenerateCombinations( combination, position + 1);
        }
    }
}