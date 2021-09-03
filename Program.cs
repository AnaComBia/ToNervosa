using System;

namespace ToNervosa
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine($"usuario, qual é a sua opinião sobre mim? Porquê eu te acho bem xoxo capenga ");
            string OpiniaoUser = Console.ReadLine();
        
            Console.WriteLine($"\n{OpiniaoUser.Remove(10)}...esquece, \nto nervosa");

        }

    }
}
