using System;
using System.Collections.Generic;
using System.IO;

namespace QuiltPatternProject
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Shape> shapes = new List<Shape>();
            
            string userInput1;
            
            
            Console.WriteLine("***Welcome to the shape recorder!***\n");
            Console.WriteLine("Please pick a color for your exciting journey ahead: ");
            Console.WriteLine("1)Red\n2)Blue\n3)Yellow");
            userInput1 = Console.ReadLine();
            
            if(userInput1 == "1")
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if(userInput1 == "2")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if(userInput1 == "3")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            
            while(userInput1 != "L")
            {
                Console.WriteLine("\n--Please Pick a Shape You Would Like to Add--");
                Console.WriteLine("S) Add a square");
                Console.WriteLine("R) Add a rectangle");
                Console.WriteLine("T) Add a triangle");
                Console.WriteLine("L) List shapes");
                userInput1 = Console.ReadLine();

                if (userInput1 == "S")
                {
                    
                    Square tempS = new Square();
                    Console.WriteLine("Please enter the side of the square: ");
                    tempS.Side1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter the color of the square: ");
                    tempS.Color = Console.ReadLine();
                    tempS.Name = "Square";
                    Console.WriteLine($"The Area of the Square is: " + tempS.GetArea());
                    
                    shapes.Add(new Square(tempS.Side1, tempS.Color));

                }


            }

            foreach (Shape s in shapes)
            {
                s.GetInfo();
                Console.WriteLine($"The " + s.Name + " has an area of " + s.GetArea() + "\n");
            }

    }

        private static object Square()
        {
            throw new NotImplementedException();
        }
    }
}
