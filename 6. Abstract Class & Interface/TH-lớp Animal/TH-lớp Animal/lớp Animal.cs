using System;
using System.Collections.Generic;
using System.Text;

namespace TH_lớp_Animal
{
    public abstract class AAnimal
    {
        public abstract string MakeSound();
        
    }
    public class Tiger : AAnimal
    {
        public override string MakeSound()
        {
            return "Tiger: roarrrrr!";
        }
    }
    public class Chicken : AAnimal , Edible 
    {
        public override string MakeSound()
        {
            return "Chicken: cluck-cluck!";
        }
        public string howtoeat()
        {
            return "could be fried";
        }
    }
    public interface Edible
    {
        public string howtoeat();
    }
    

}
