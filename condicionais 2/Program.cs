using System;

namespace condicionais_2
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Calculadora");
           Console.WriteLine("----------------");

        //ENTRADA
           Console.WriteLine("Digite o ano que você nasceu: ");
           int anonascimento = int.Parse(Console.ReadLine()); 

           Console.WriteLine("Digite o ano atual: ");
           int anoatual = int.Parse(Console.ReadLine());

        //PROCESSAMENTO
            int idade = anoatual- anonascimento;
            int semanas = idade * 52;
        
        //EXIBIR

         System.Console.WriteLine("A sua idade é: "+idade);
          System.Console.WriteLine("Semanas vividas é: "+semanas);






        }
    }
}
