using System;
using System.Collections;
using System.Globalization;

namespace AC1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variável a ser inserido pelo usuário, este valor irá determinar o tamanho do vetor.
            Console.Write("Coloque a quantidade de pessoas: ");
            int n = int.Parse(Console.ReadLine());
            double[] vect = new double[n];
            for (int i = 0; i < n; i++)
                
            {
                Console.Write("Altura da pessoa ({0}): ",i + 1);
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            double sum = 0.0;
            for  (int i = 0; i < n; i++)
                
            {
                sum += vect[i];
            }
            double media = sum / n;
            Console.Write("A média das pessoas inseridas é = {0:N2}", (double) media);

        }
    }
}  
