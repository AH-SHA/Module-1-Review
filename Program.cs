namespace Module_1_Review_Exercise___C_
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
         // AREA of a CIRCLE
            // Code to ask the user to provide input

            Console.WriteLine("Please type a number on the next line for the radius: ");

            //Create a variable called 'radius'
            //Converting user input to the 'double' variable type

            double radius = double.Parse(Console.ReadLine());

            //Calling the method 'CircleArea' and printing the method's result to the console

            Console.WriteLine(CircleArea(radius));

         // AREA of a TRIANGLE




         //AREA of a RECTANGLE




         // AREA of a SQUARE


        }

        // Creating the method 'CircleArea' within the class of the project
        static double CircleArea(double radius)

        {

            // Coding the body of the method to calculate the area, using 'radius' as a parameter

            return (Math.PI) * Math.Pow(radius, 2);

        }

        // Creating the method 'TriangleArea' within the class of the project




    }




}
