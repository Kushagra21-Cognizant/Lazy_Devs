// See https://aka.ms/new-console-template for more information
while (true)
{
    Console.WriteLine("Choose an option:");
    Console.WriteLine("1. Use a prefilled array of 10 items");
    Console.WriteLine("2. Enter your own array");
    Console.WriteLine("3. Exit program");
    Console.Write("Enter your choice (1, 2, or 3): ");
    int choice = int.Parse(Console.ReadLine());

    int[] array;

    if (choice == 3)
    {
        Console.WriteLine("Exiting the program. Goodbye!");
        break;
    }

    if (choice == 1)
    {
        // Prefilled array of 10 items
        array = new int[] { 45, 23, 78, 12, 89, 34, 67, 91, 10, 56 };
        Console.WriteLine("Using prefilled array.");
    }
    else if (choice == 2)
    {
        // Input-based array
        Console.Write("Enter the size of the array: ");
        int size = int.Parse(Console.ReadLine());
        array = new int[size];

        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Element {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }
    }
    else
    {
        Console.WriteLine("Invalid choice. Please try again.");
        return;
    }

    Console.WriteLine("\nArray before sorting:");
    DisplayArray(array);

    // Bubble Sort
    BubbleSort(array);

    Console.WriteLine("\nArray after sorting:");
    DisplayArray(array);
}
    static void BubbleSort(int[] array)
{
    int n = array.Length;
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n - i - 1; j++)
        {
            if (array[j] > array[j + 1])
            {
                // Swap array[j] and array[j + 1]
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
    }
}

static void DisplayArray(int[] array)
{
    foreach (var item in array)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}