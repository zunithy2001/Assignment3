namespace Assignment3_8H
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //addition of two Matrices of same size. 
            // Get the number of rows and columns of the matrix from the user
            Console.Write("Enter the number of rows: ");
            int rows;
            while (!int.TryParse(Console.ReadLine(), out rows) || rows <= 0)
            {
                Console.WriteLine("Invalid input! Please enter a positive integer.");
            }

            Console.Write("Enter the number of columns: ");
            int cols;
            while (!int.TryParse(Console.ReadLine(), out cols) || cols <= 0)
            {
                Console.WriteLine("Invalid input! Please enter a positive integer.");
            }

            // Declaring two matrices and the result matrix
            int[,] matrix1 = new int[rows, cols];
            int[,] matrix2 = new int[rows, cols];
            int[,] resultMatrix = new int[rows, cols];

            // Get values for the first matrix
            Console.WriteLine("Enter the elements of the first matrix:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Element [{i + 1},{j + 1}]: ");
                    while (!int.TryParse(Console.ReadLine(), out matrix1[i, j]))
                    {
                        Console.WriteLine("Invalid input! Please enter an integer.");
                        Console.Write($"Element [{i + 1},{j + 1}]: ");
                    }
                }
            }

            // Get values for the second matrix
            Console.WriteLine("Enter the elements of the second matrix:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Element [{i + 1},{j + 1}]: ");
                    while (!int.TryParse(Console.ReadLine(), out matrix2[i, j]))
                    {
                        Console.WriteLine("Invalid input! Please enter an integer.");
                        Console.Write($"Element [{i + 1},{j + 1}]: ");
                    }
                }
            }

            // Perform matrix addition
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    resultMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            // Display the result matrix
            Console.WriteLine("\nThe resulting matrix after addition is:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(resultMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}