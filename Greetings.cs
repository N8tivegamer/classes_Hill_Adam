using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_Hill_Adam
{
    internal class Greetings
    {

        public void Welcome()
        {
            // Display a welcome message to the user
            Console.WriteLine("Hello Travler, welcome");
        }

        public void Hello(string name)
        {
            // Thank the user by name for joining
            Console.WriteLine($"{name}, Thank you for joining us today!");
        }
    }
}
