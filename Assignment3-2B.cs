namespace Assignment3_2B
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //find maximum and minimum element in an array

            //declaring a variable to take array size from user
            int size;

            //getting user input
            Console.Write("Enter the array size: ");

            //validating size
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.WriteLine("Invalid Input!! Please Enter A Positive Integer: ");

            }

            //declaring array and initalizing size
            int[] numbers = new int[size];

            //getting user input
            Console.Write("Enter the array elements: ");

            //loop to store array elements
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i + 1}: ");

                //validating each element entered by user
                while (!int.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    Console.WriteLine("Invalid input! Please enter an integer.");
                    Console.Write($"Element {i + 1}: ");
                }
            }

            // declaring variables to store maximum and minimum
            int max = numbers[0];
            int min = numbers[0];

            // iterating through the array to find max and min
            for (int i = 1; i < size; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            // Displaying results
            Console.WriteLine($"\nThe maximum element in the array is: {max}");
            Console.WriteLine($"The minimum element in the array is: {min}");
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
