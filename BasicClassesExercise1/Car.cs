using System;
using System.Collections.Generic;
using System.Text;

namespace BasicClassesExercise1
{
    public class Car
    {
        public Car()
        {

        }

        public Car(string makeInput, string modleInput, int year)
        {
            Make = makeInput;
            Model = modleInput;
            Year = year;             
                
        }
        
        //fields
        //Properties
        //Methods 

        // Create a Make property of type string that is public 
        public string Make { get; set; } //get = read set = weight 
        public string Model { get; set; }
        public int Year { get; set; }
    }
}
