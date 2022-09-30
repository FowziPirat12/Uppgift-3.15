using System;


namespace Uppgift_3._15
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många timmar ska du hyra bilen?");
            string tid = Console.ReadLine();
            Console.WriteLine("Hur mycket kommer det att kosta?");
           string pris = Console.ReadLine();    
            
            float tid_tal1 = float.Parse(Console.ReadLine());
            float pris_tal1 = float.Parse(Console.ReadLine());

            float dagar = 80 * tid_tal1; 
        }
    }
}