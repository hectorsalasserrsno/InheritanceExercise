using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal-- done
            // give this class 4 members that all Animals have in common- done


            // Create a class Bird-- done
            // give this class 4 members that are specific to Bird--done
            // Set this class to inherit from your Animal Class-- done

            // Create a class Reptile-- done 
            // give this class 4 members that are specific to Reptile-- done
            // Set this class to inherit from your Animal Class-- done




            /*Create an object of your Bird class-- done
             *  give values to your members using the object of your Bird class-- done
             *  
             * Creatively display the class member values -- done
             */
            Bird Eagle = new Bird() {Peak = true, Wings = 2, Feathers = true, Sing = true };
            Console.WriteLine($"The American Eagle has a very sharp peak, " +
                $"and flies really high with its {Eagle.Wings} wings," +
                $"and has beautifull feathers, but doesn't sing very much.");
            Console.WriteLine($"Does the American Eagle has a peak, feathers, and can sing? " +
                $"{Eagle.Peak},{Eagle.Feathers},{Eagle.Sing}");


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Reptile Aligator = new Reptile();
            {
                Aligator.SharpTeeth = true;
                Aligator.Scales = true;
                Aligator.ColdBlooded = true;
                Aligator.BackBone = true;

                Console.WriteLine($"Do the reptiles have sharp teeth, scales, " +
                    $"also are the reptiles cold-blooded and backbone?");
                Console.WriteLine($"{Aligator.SharpTeeth}  {Aligator.Scales}  " +
                    $"{Aligator.ColdBlooded}  {Aligator.BackBone}");
            };
        }
    }
}
