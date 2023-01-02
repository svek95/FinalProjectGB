string[] array1 = {"1234", "1567", "-2", "computer science"};
string[] array2 = new string[array1.Length];


     void Main()
    {
        Console.Write("Manual Input (1) or Presset (2): ");
        int taskNumver = Convert.ToInt32(Console.ReadLine());
        switch (taskNumver)
        {
            case 1:
                Console.Write("Print size array: ");
                int arraySize = Convert.ToInt32(Console.ReadLine());
                Task(craeteMass(arraySize), array2);
                PrintArray(array2);
                break;
            case 2:
                 Task(array1, array2);
                 PrintArray(array2);
                 break;


        }
    }


string[] craeteMass(int size)
        {
            string[] array = new string[size];
            
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Input {i+1} number: ");
                array[i] = Console.ReadLine();
            }

            return array;

        }
        


void Task(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}

void PrintArray(string[] array)
{
    Console.WriteLine("Resault is: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

Main();