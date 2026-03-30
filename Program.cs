using System;
 class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("digite sua operacao");
         
       
        Console.WriteLine("1- adição");
        Console.WriteLine("2- subtração");
        Console.WriteLine("3- multiplicação");
         Console.WriteLine("4- divisão\n");

        

         int operacao = int.Parse(Console.ReadLine());

           Console.WriteLine("digite o primeiro numero");
         int num1 = int.Parse(Console.ReadLine());

         
           Console.WriteLine("digite o segundo numero");
         int num2 = int.Parse(Console.ReadLine());

         int resultado;

         switch (operacao)
        {
            case 1:
                {
                    resultado = num1 + num2;
                    Console.WriteLine(resultado);
                    break;
                }        
                case 2:
                {
                    resultado = num1 - num2;
                    Console.WriteLine(resultado);
                    break;
                }    
                case 3:
                {
                    resultado = num1 * num2;
                    Console.WriteLine(resultado);
                    break;
                }            
                case 4:
                {
                    resultado = num1 / num2;
                    Console.WriteLine(resultado);
                    break;
                }        
                default:
                {
                    Console.WriteLine("operaçao invalida");
                    break;
                }
        }  

    }
}