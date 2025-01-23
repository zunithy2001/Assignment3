namespace Assignment3_7G
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get array size from the user
            Console.Write("Enter the size of the array: ");
            int size;

            // Validate the array size
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.WriteLine("Invalid input! Please enter a positive integer for the array size.");
            }

            // Initialize the array based on the user input size
            int[] numbers = new int[size];

            // Get the elements of the array from the user
            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    Console.WriteLine("Invalid input! Please enter an integer.");
                    Console.Write($"Element {i + 1}: ");
                }
            }

            // Display the array
            Console.WriteLine("\nArray entered by the user:");
            for (int i = 0; i < size; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

            // Initialize the variables to store smallest and second smallest
            int smallest = int.MaxValue;
            int secondSmallest = int.MaxValue;

            // Find the second smallest element
            for (int i = 0; i < size; i++)
            {
                if (numbers[i] < smallest)
                {
                    secondSmallest = smallest;
                    smallest = numbers[i];
                }
                else if (numbers[i] < secondSmallest && numbers[i] != smallest)
                {
                    secondSmallest = numbers[i];
                }
            }

            // Display the second smallest element
            if (secondSmallest == int.MaxValue)
            {
                Console.WriteLine("\nThere is no second smallest element in the array.");
            }
            else
            {
                Console.WriteLine($"\nThe second smallest element is: {secondSmallest}");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadLine();
        }
    }
}