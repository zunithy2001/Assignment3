namespace Assignment3___1A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get array size from the user
            Console.Write("Enter the size of the array: ");
            int size;
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer for the array size.");
            }

            // Declare the array
            int[] numbers = new int[size];

            // Get array elements from the user
            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    Console.WriteLine("Invalid input. Please enter an integer.");
                    Console.Write($"Element {i + 1}: ");
                }
            }

            // Count duplicate elements
            int duplicateCount = 0;
            bool[] visited = new bool[size]; // To track visited elements

            for (int i = 0; i < size; i++)
            {
                if (visited[i]) continue; // Skip if already counted

                bool isDuplicate = false;

                for (int j = i + 1; j < size; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        isDuplicate = true;
                        visited[j] = true; // Mark this element as visited
                    }
                }

                if (isDuplicate)
                {
                    duplicateCount++;
                }
            }

            // Display the result
            Console.WriteLine($"\nTotal number of duplicate elements in the array: {duplicateCount}");
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}