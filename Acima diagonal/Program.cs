using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acima_diagonal {
    class Program {
        static void Main(string[] args) {

            int n, i, j, soma;

            Console.Write("Qual a ordem da matriz?");
            n = int.Parse(Console.ReadLine());
            
            int[,] matriz = new int[n, n];
            
            for (i = 0; i < n; i++) {
                for (j = 0; j < n; j++) {
                    Console.Write("Elementos [" + i + "," + j + "]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            soma = 0;
            for (i = 0; i < n; i++) {
                for (j = 0; j < n; j++) {
                    if (i < j) {
                        soma = soma + matriz[i, j];
                    }
                }
            }

            Console.WriteLine("SOMA DOS ELEMENTOS ACIMA DA DIAGONAL PRINCIPAL = " + soma);
        }
    }
}
