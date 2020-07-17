using System;

namespace TH_lớp_Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            AAnimal[] aanimal = new AAnimal[2];
            aanimal[0] = new Tiger() ;
            aanimal[1] = new Chicken() ;

            foreach (var animal in aanimal)
            {
                Console.WriteLine(animal.MakeSound());
         
            if (aanimal is Chicken)
            {
                Edible edibler = (Chicken)animal;uyg
                Console.WriteLine(edibler.howtoeat());
            }
            }

        }
    }
}
