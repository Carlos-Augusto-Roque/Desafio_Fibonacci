using System;

namespace Desafio_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {

        Console.WriteLine("Série de Fibonacci!");
        int num1 = 0, num2 = 1, auxiliar;

		for (int i = 0; i < 20; i++)
		{
			auxiliar = num1;
			num1 = num2;
			num2 = num1 + auxiliar;
			Console.WriteLine("{0}", num2);
            if(num2>500)
            {
                 Console.ReadLine();
            }
            
        }

        


        }
    }
}


//*DESAFIO EXTRA!

// A série de Fibonacci é formada pela seqüência 0,1,1,2,3,5,8,13,21,34,55,...
// Pesquise como funciona o algoritmo Fibonacci.
// Faça um programa que gere a série até que o valor seja maior que 500.