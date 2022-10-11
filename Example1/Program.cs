//  Задаем  двумерный массив рандом
//  вводим число и программа должна сказать сколько раз оно присутствует в массиве.
//  число 23 - 5 раз.

int [,] GetArray (int m, int n, int min, int max)
{
    int [,] result = new int [m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
            Console.Write(result[i, j] + "\t" );                // \t - табуляция
        }
        Console.WriteLine();
    } 
    return result;
}
int [] GoodArray(int [,] matrix, int [] array)
{
    int[] out1 = new int [array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        for (int x = 0; x < matrix.GetLength(0); x++)
        {
            for (int y = 0; y < matrix.GetLength(1); y++)
            {
                if (array [i] == matrix[y,x]) out1[i]++;
            }
        }
    }
    return out1;
}
// string [] array = Console.ReadLine().Split(" ");                                // вводим числа через пробел Split(" ") - убирает пробелы
int [] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray(); // select берет введеные числа и конвертирует их в числа массива типо цикла фор где х индекс элемента
int [] good = GoodArray(GetArray(6, 6, -10, 10), array);
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Число {array[i]} = {good[i]}");
}