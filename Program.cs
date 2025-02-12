namespace Module_1_Review_Exercise___C_
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            // AREA of a CIRCLE

            Console.WriteLine("AREA of a CIRCLE");
            Console.WriteLine();

            // Code to ask the user to provide input

            Console.WriteLine("Please type a number on the next line for the circle's radius: ");

            //Create a variable called 'radius'
            //Converting user input to the 'double' variable type

            double radius = double.Parse(Console.ReadLine());

            //Calling the method 'CircleArea' and printing the method's result to the console

            Console.WriteLine($"The area of your circle is: {CircleArea(radius)}");

            Console.WriteLine();




          // AREA of a TRIANGLE

            Console.WriteLine("AREA of a TRIANGLE");

            Console.WriteLine();

            Console.WriteLine("Enter a number on the next line for the triangle's BASE: ");


            double baseLength = double.Parse(Console.ReadLine());


            Console.WriteLine("Enter a number on the next line for the triangle's HEIGHT: ");


            double height = double.Parse(Console.ReadLine());


            Console.WriteLine($"The area of your triangle is: {TriangleArea(baseLength, height)}");

            Console.WriteLine();


            //AREA of a RECTANGLE


            Console.WriteLine("AREA of a RECTANGLE");

            Console.WriteLine();

            Console.WriteLine("Enter a number on the next line for the rectangle's LENGTH: ");


            double length = double.Parse(Console.ReadLine());


            Console.WriteLine("Enter a number on the next line for the rectangle's WIDTH: ");


            double width = double.Parse(Console.ReadLine());


            Console.WriteLine($"The area of your rectangle is: {RectangleArea(length, width)}");

            Console.WriteLine();




            Console.WriteLine();

            // AREA of a SQUARE
            Console.WriteLine("AREA of a SQUARE");
            Console.WriteLine();
            
            
            Console.WriteLine();



        }
        // All Methods were placed in the Class of the Project
        // Creating the method 'CircleArea' within the class of the project
        static double CircleArea(double radius)

        {

            // Coding the body of the method to calculate the area, using 'radius' as a parameter

            return (Math.PI) * Math.Pow(radius, 2);

        }

        // Creating the method 'TriangleArea' within the class of the project

        static double TriangleArea(double baseLength, double height)
        {
            //Codeblock for the TriangleArea method to calculate area
            //TriangleArea method uses 2 parameters: baseLength and height

            return (baseLength / 2) * height;

        }

        //Creating the method 'RectangleArea' within the class of the project

        static double RectangleArea(double length, double width)
        {
            //Codeblock for the RectangleArea method to calculate area
            //RectangleArea method uses 2 parameters: length and width

            return length * width;

        }


    }




}
