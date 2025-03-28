// See https://aka.ms/new-console-template for more information
while (true)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Multiply predefined matrices");
            Console.WriteLine("2. Input your own matrices");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice (1, 2, or 3): ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 3)
            {
                Console.WriteLine("Exiting the program. Goodbye!");
                break;
            }

            int[,] matrixA, matrixB;

            if (choice == 1)
            {
                // Prefilled matrices
                matrixA = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
                matrixB = new int[,] { { 7, 8 }, { 9, 10 }, { 11, 12 } };

                Console.WriteLine("\nUsing predefined matrices.");
                Console.WriteLine("\nMatrix A:");
                DisplayMatrix(matrixA);
                Console.WriteLine("\nMatrix B:");
                DisplayMatrix(matrixB);
            }
            else if (choice == 2)
            {
                // User-defined matrices
                Console.Write("\nEnter the number of rows for the first matrix: ");
                int rowsA = int.Parse(Console.ReadLine());
                Console.Write("Enter the number of columns for the first matrix: ");
                int colsA = int.Parse(Console.ReadLine());

                Console.Write("\nEnter the number of rows for the second matrix: ");
                int rowsB = int.Parse(Console.ReadLine());
                Console.Write("Enter the number of columns for the second matrix: ");
                int colsB = int.Parse(Console.ReadLine());

                if (colsA != rowsB)
                {
                    Console.WriteLine("\nMatrix multiplication is not possible. The number of columns of the first matrix must equal the number of rows of the second matrix.");
                    continue;
                }

                Console.WriteLine("\nEnter the elements of the first matrix:");
                matrixA = new int[rowsA, colsA];
                for (int i = 0; i < rowsA; i++)
                {
                    for (int j = 0; j < colsA; j++)
                    {
                        Console.Write($"Element [{i + 1}, {j + 1}]: ");
                        matrixA[i, j] = int.Parse(Console.ReadLine());
                    }
                }

                Console.WriteLine("\nEnter the elements of the second matrix:");
                matrixB = new int[rowsB, colsB];
                for (int i = 0; i < rowsB; i++)
                {
                    for (int j = 0; j < colsB; j++)
                    {
                        Console.Write($"Element [{i + 1}, {j + 1}]: ");
                        matrixB[i, j] = int.Parse(Console.ReadLine());
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
                continue;
            }

            int[,] resultMatrix = MultiplyMatrices(matrixA, matrixB);

            Console.WriteLine("\nResultant Matrix:");
            DisplayMatrix(resultMatrix);
        }

    static int[,] MultiplyMatrices(int[,] matrixA, int[,] matrixB)
    {
        int rowsA = matrixA.GetLength(0);
        int colsA = matrixA.GetLength(1);
        int colsB = matrixB.GetLength(1);

        int[,] result = new int[rowsA, colsB];

        for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < colsB; j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < colsA; k++)
                {
                    result[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }

        return result;
    }

    static void DisplayMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}