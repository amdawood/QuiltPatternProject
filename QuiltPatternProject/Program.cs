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
            
            while(userInput1 != "Q")
            {
                Console.WriteLine("\n--Please Pick a Shape You Would Like to Add--");
                Console.WriteLine("S) Add a square");
                Console.WriteLine("R) Add a rectangle");
                Console.WriteLine("T) Add a triangle");
                Console.WriteLine("L) List shapes");
                Console.WriteLine("Q) Quit");
                userInput1 = Console.ReadLine();

                if (userInput1 == "S")
                {
                    
                    Square tempS = new Square();
                    Console.WriteLine("Please enter the side of the square: ");
                    tempS.Side1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter the color of the square: ");
                    tempS.Color = Console.ReadLine();
                    Console.WriteLine($"The Area of the Square is: " + tempS.GetArea());
                    
                    shapes.Add(new Square(tempS.Side1, tempS.Color));

                }
                else if(userInput1 == "R")
                {
                    Rectangle tempR = new Rectangle();
                    Console.WriteLine("Please enter the side 1 of the rectangle: ");
                    tempR.Side1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter the side 2 of the rectangle: ");
                    tempR.Side2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter the color of the rectangle: ");
                    tempR.Color = Console.ReadLine();
                    Console.WriteLine($"The Area of the Rectangle is: " + tempR.GetArea());

                    shapes.Add(new Rectangle(tempR.Side1, tempR.Side2, tempR.Color));

                }else if(userInput1 == "T")
                {
                    Triangle tempT = new Triangle();
                    Console.WriteLine("Please enter the side 1 of the triangle: ");
                    tempT.Side1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter the side 2 of the triangle: ");
                    tempT.Side2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter the side 3 of the triangle: ");
                    tempT.Side3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter the color of the triangle: ");
                    tempT.Color = Console.ReadLine();
                    Console.WriteLine($"The Area of the Triangle is: " + tempT.GetArea());

                    shapes.Add(new Triangle(tempT.Side1, tempT.Side2, tempT.Side3, tempT.Color));

                }
                else if(userInput1 == "L")
                {
                    foreach (Shape s in shapes)
                    {

                        s.GetInfo();
                        Console.WriteLine($"The " + s.Name + " has an area of " + s.GetArea() + "\n");
                    }
                }
                else
                {
                    Console.WriteLine("***Please select one of the correct options***");
                }


            }

        }
    }
}
