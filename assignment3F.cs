namespace Assignment3_6F
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //delete an element at desired position from an array. 

            // Declaring a Sample array
            int[] numbers = { 1, 3, 5, 7, 9, 10 };

            // Display the original array
            Console.WriteLine("Original Array:");
            DisplayArray(numbers);

            // Get the position to delete
            Console.Write("Enter the position (0-based index) of the element to delete: ");
            int position;
            while (!int.TryParse(Console.ReadLine(), out position) || position < 0 || position >= numbers.Length)
            {
                Console.WriteLine("Invalid input! Please enter a valid index.");
            }

            // Delete the element at the given position
            numbers = DeleteElementAtPosition(numbers, position);

            // Display the updated array
            Console.WriteLine("\nArray after deletion:");
            DisplayArray(numbers);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadLine();
        }

        // Method to delete an element at a given position
        static int[] DeleteElementAtPosition(int[] arr, int position)
        {
            // Create a new array of size one less than the original array
            int[] newArr = new int[arr.Length - 1];

            // Copy all elements before the given position
            for (int i = 0; i < position; i++)
            {
                newArr[i] = arr[i];
            }

            // Copy all elements after the given position
            for (int i = position + 1; i < arr.Length; i++)
            {
                newArr[i - 1] = arr[i];
            }

            return newArr;
        }

        // Method to display the array
        static void DisplayArray(int[] arr)
        {
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}