using System;

namespace Numbergenerator
{
    class Program
    {
        static void Main(string[] args){   
            Random rnd = new Random();
            int nummer =  rnd.Next(1,101);

            Console.WriteLine("Jag tänker på ett nummer mellan 1 och 100, försök att gissa vilket!");
            
            int försök = 0;
            int gissning = 0;
            while (gissning != nummer) {
                gissning = Int32.Parse(Console.ReadLine());
                if (gissning > nummer) {
                    Console.WriteLine("För högt, gissa igen!");

                } 
                else if (gissning < nummer){
                    Console.WriteLine("För lågt, gissa igen!");
                }
                försök++; 
            }
            if (gissning == nummer) {
                Console.WriteLine("Du gissade rätt!");
                Console.WriteLine("Jag tänkte på numret " + nummer + ", det tog dig " + försök + " försök att få rätt svar!");
            }
                
             
        }
    }
}
