using System;

namespace ProvaTriangulos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 1 para realizar suas operações:");


            int opcao = Convert.ToInt32(Console.ReadLine());

            if (opcao == 1)
            {


                Console.WriteLine("Digite o valor X:");
                int ValorX = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o valor Y:");
                int ValorY = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o valor Z:");
                int ValorZ = Convert.ToInt32(Console.ReadLine());

                if (ValorX < 0 && ValorY < 0 && ValorZ < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opção inválida: tente novamente");
                    Console.ResetColor();
                    Console.ReadLine();
                    Console.Clear();
                }
                    

                if (ValorX == ValorY && ValorX == ValorZ && ValorY == ValorZ)
                    Console.WriteLine("Este triângulo é equilátero");

                else if (ValorX != ValorY && ValorX != ValorZ && ValorY != ValorZ)
                    Console.WriteLine("Este triângulo é escaleno");

                else
                    Console.WriteLine("Este triângulo é isósceles");

            }

        }
    }
}
