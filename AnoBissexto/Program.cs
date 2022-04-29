using System;

namespace AnoBissexto
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Digite um ano para calcularmos se é ou não Bissexto, ex: 2022 . ");

            int ano = int.Parse(Console.ReadLine());






            
           
            if ((ano % 400 == 0) && (ano % 4 == 0)) // bissexto
            {
                Console.WriteLine("Esse ano é Bissexto.");

            }else if(ano %400 == 0)
            {
                Console.WriteLine(" Esse ano  é bissexto.");
            }
            else if (ano %4==0 && ano %100 != 0)
            {
                Console.WriteLine("Esse ano é bissexto");
            }
            else
            {
                Console.WriteLine(" Esse ano não é bissexto");
                   
            }
            
        }
    }
}
