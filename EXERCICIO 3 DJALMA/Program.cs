using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO_3_DJALMA
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string figura;
            double areatriangulo, arealosango, areatrapezio;




            Console.WriteLine("Escolha uma das figuras abaixo para calcular a área: A B OU C");

            Console.WriteLine("[A] = Triângulo");
            Console.WriteLine("[B] = Losango");
            Console.WriteLine("[C] = Trapézio");


            figura = Console.ReadLine();



            Console.WriteLine(figura);


            switch (figura)
            {
                case "a":
                case "A":


                    Console.WriteLine("A fórmula para calcular a área de um  triângulo é Area=(Base x altura)/2 \n");

                    Console.Write("informe o valor da BASE: ");
                    double b = Convert.ToDouble(Console.ReadLine());

                    Console.Write("informe o valor da ALTURA: ");
                    double h = Convert.ToDouble(Console.ReadLine());

                    areatriangulo = (b * h) / 2;

                    Console.WriteLine("a área do triangulo é: " + areatriangulo);

                    break;

                case "b":
                case "B":


                    Console.WriteLine("A fórmula para calcular a área de um losango é Area= (Diagonal MAIOR x Diagonal menor) /2 \n");

                    Console.Write("informe o valor da Diagonal MAIOR: ");
                    double dmaior = Convert.ToDouble(Console.ReadLine());

                    Console.Write("informe o valor da Diagonal MENOR: ");
                    double dmenor = Convert.ToDouble(Console.ReadLine());


                    arealosango = (dmaior * dmenor) / 2;

                    Console.Write("a área do losango  é: " + arealosango);
                    break;

                case "C":
                case "c":


                    Console.WriteLine("A fórmula para calcular a área de um Trapézio é Area= (Base Maior + Base Menor) x altura/2 \n ");

                    Console.Write("informe o valor da  BASE MAIOR: ");
                    double bmaior = Convert.ToDouble(Console.ReadLine());

                    Console.Write("informe o valor da  BASE MENOR: ");
                    double bmenor = Convert.ToDouble(Console.ReadLine());

                    Console.Write("informe o valor da altura: ");
                    double htrapezio = Convert.ToDouble(Console.ReadLine());

                    areatrapezio = (bmaior + bmenor) * htrapezio / 2;

                    Console.WriteLine("a área do Trapézio é: " + areatrapezio);
                    break;


                default:



                    Console.WriteLine("Escolha uma das Opçoes [A]Triângulo, [B]Losango ou [C]Trapézio");
                    break;



            }


            Console.ReadKey();
        }
    }


}

