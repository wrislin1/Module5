/* 
 Widler Rislin
 10/31/2019
 CEN 4370C
 Module 5 Assignment
 This Program prompts the user for input to find the area of either a Circle, Square or Rectangle.
 it also finds the circufernce of a Circle and perimeter of a rectangle`. There is not enough info to find
 the perimeter of a triangle.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5
{
    class Circleobj  // Circle object definitions
    {
        public double radius, circumference,area;

        public Circleobj(double radius = 0)  // Circle object constructor with an optional parameter.
        {
            this.radius = radius;
            area = 0;
        }
        public void Prompt() // Prompt function promting user for input
        {
            string c;       // escape character check

            Console.WriteLine();
            Console.WriteLine("Press x to return to the Menu");
            Console.WriteLine();                                 // Prompts user for input
            Console.Write("Please enter the Radius of the Circle: ");

            while (radius <= 0)
            {
                c = Console.ReadLine(); // stores user input
                if (c == "x" || c == "X")  // checks for escape character
                {
                    radius = 0;
                    break;
                }
                try // checks for valid input
                {
                    radius = double.Parse(c);
                    if (radius <= 0)
                    {
                        throw new Exception();
                    }
                }
                catch
                {
                    Console.Write("Invalid Input, Please enter a valid Radius: "); // prompts user for valid input

                }

            }
            area = Math.PI * Math.Pow(radius, 2);   // computes area and circumference
            circumference = 2 * Math.PI * radius;
        }
    }

    class Rectangleobj  // Rectangele object definitions
    {
        public double base1,height,area,perimeter;
        public Rectangleobj(double base1= 0, double height= 0) // Constructor with optional parameters
        {
            this.base1 = base1;
            this.height = height;

        }

        public void Prompt()  // Prompt function prompting users for input
        {
            string c; // escape character check


            Console.WriteLine();
            Console.WriteLine("Press x to return to the Menu");
            Console.WriteLine(); //prompts user for input
            Console.Write("Please enter the Base of the Rectangle: ");

            while (base1 <= 0)
            {
                c = Console.ReadLine(); // stores user input
                if (c == "x" || c == "X") // checks for escape character
                {
                    base1 = 0;
                    break;
                }
                try // checks for valid input
                {
                    base1 = double.Parse(c);
                    if (base1 <= 0)
                    {
                        throw new Exception();
                    }
                }
                catch
                {
                    Console.Write("Invalid Input, Please enter a valid Base: "); //prompts user to enter valid input

                }
            }

            if (base1 != 0)
            {
                Console.Write("Please enter the Height of the Rectangle: ");
                while (height <= 0)
                {
                    c = Console.ReadLine();
                    if (c == "x" || c == "X")
                    {
                        height = 0;
                        break;
                    }
                    try
                    {
                        height = double.Parse(c);
                        if (height <= 0)
                        {
                            throw new Exception();
                        }
                    }
                    catch
                    {
                        Console.Write("Invalid Input, Please enter a valid Height: ");

                    }
                }
                if (base1 != 0 && height != 0)
                {
                    area = base1 * height;  // Calculates area and perimeter of rectangle
                    perimeter = (2 * base1) + (2 * height);
                }
            }
        }
    }

    class Triangleobj  // Triangle object and definitions
    {
        public double base1, height,area;

        public Triangleobj(double base1 = 0, double height = 0)  // Constructor with optional parameters
        {
            this.base1 = base1;
            this.height = height;

        }

        public void Prompt() // Prompt function prompting users for input
        {
            string c; // escape character check


            Console.WriteLine();
            Console.WriteLine("Press x to return to the Menu");
            Console.WriteLine(); //prompts user for input
            Console.Write("Please enter the Base of the Triangle: ");

            while (base1 <= 0)
            {
                c = Console.ReadLine(); // stores user input
                if (c == "x" || c == "X") // checks for escape character
                {
                    base1 = 0;
                    break;
                }
                try // checks for valid input
                {
                    base1 = double.Parse(c);
                    if (base1 <= 0)
                    {
                        throw new Exception();
                    }
                }
                catch
                {
                    Console.Write("Invalid Input, Please enter a valid Base: "); //prompts user to enter valid input

                }
            }

            if (base1 != 0)
            {
                Console.Write("Please enter the Height of the Triangle: ");
                while (height <= 0)
                {
                    c = Console.ReadLine();
                    if (c == "x" || c == "X")
                    {
                        height = 0;
                        break;
                    }
                    try
                    {
                        height = double.Parse(c);
                        if (height <= 0)
                        {
                            throw new Exception();
                        }
                    }
                    catch
                    {
                        Console.Write("Invalid Input, Please enter a valid Height: ");

                    }
                }
                if  (height !=0 && base1 !=0  )
                {
                    area = (base1 * height) / 2; // Computes area of the triangle
                }
                
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int opt = 0; // Variable holding user selection
             // variable holding area value.

            while (opt != 4) // Loops through selection menu, checks for escape character.
            {
                opt = 0; // resets user selection to 0
                Console.WriteLine("Please enter a Selection");    // Selection Menu
                Console.WriteLine("1. Area of a Circle");
                Console.WriteLine("2. Area of a Rectangle");
                Console.WriteLine("3. Area of a Triangle");
                Console.WriteLine("4. Exit Program");
                Console.WriteLine();

                try //Checking for invalid inputs
                {
                    opt = int.Parse(Console.ReadLine());
                    if (opt < 1 || opt > 4)
                        throw new Exception();
                }
                catch
                {
                    Console.WriteLine();
                    Console.Write("Input Not Valid, Please try again: ");    // Prompts user for new input
                    Console.WriteLine();

                }
                switch (opt)   // Checks user selection and creates appropriate object
                {
                    case 1:
                        Circleobj circ = new Circleobj();   // Creates new circle object
                        circ.Prompt();
                        if (circ.area == 0)     // If area is 0 the eescape character was pressed
                        {
                            break;
                        }
                        Console.WriteLine();
                        Console.WriteLine("Area of the Circle = " + circ.area); //outputs area
                        Console.WriteLine("Circumference of the Circle = " + circ.circumference);
                        break;
                    case 2:
                        Rectangleobj rec = new Rectangleobj();  // Creates new Rectangle object
                        rec.Prompt();
                        if (rec.area == 0)  // If area is 0 the eescape character was pressed
                        {
                            break;
                        }
                        Console.WriteLine();
                        Console.WriteLine("Area of the Rectangle = " + rec.area);
                        Console.WriteLine("Perimeter of the Rectangle = " + rec.perimeter);
                        break;
                    case 3:
                        Triangleobj tri = new Triangleobj(); // Creates new Triangle object
                        tri.Prompt();
                        if (tri.area == 0)   // If area is 0 the eescape character was pressed
                        {
                            break;
                        }
                        Console.WriteLine();
                        Console.WriteLine("Area of the Triangle = " + tri.area);
                        break; 
                }
                Console.WriteLine();
            }
        }
    }
}
