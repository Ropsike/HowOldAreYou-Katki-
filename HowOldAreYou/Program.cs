using System;

namespace HowOldAreYou
{
    class Program
    {

            //programm küsib kasutaja vanust
            //programm arvutab kasutaja sünniaastat
            //programm kuvab kasutaja sünniaastat konsoolis

            Console.WriteLine("Mis on sinu vanus?");
            
            //convert string from ReadLine() to int
            
            int YearOfBirth = 2021 - Age;
            
            int Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Olen sündinud aastal " + YearOfBirth);

            //Console.WriteLine ("Olen sündinud aastal " + YearOfBirth + "
            Console.ReadLine($"Olen sündinud aastal {YearOfBirth}".);


        }
    }
}
