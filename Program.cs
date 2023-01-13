// // Задача 62. 
// // Напишите программу, которая заполнит спирально массив 4 на 4.
// // Например, на выходе получается вот такой массив:
// // 01 02 03 04
// // 12 13 14 05
// // 11 16 15 06
// // 10 09 08 07

int[,] GetMatrix(int height) // прописывает массив по спирали
{
    int count = 1;
    int n = 0;
    int i = 0;
    int j = 0;
    int x = 0;
    int y = 0;
    int[,] matrix = new int[height, height];

    while (count < matrix.GetLength(0) * matrix.GetLength(0) + 1)
    {
        for (j = x; j < matrix.GetLength(0) - n; j++) // заполнение на право
        {
            matrix[i, j] = count++;
        }
        --j;
        for (i = 1 + n; i < matrix.GetLength(0) - n; i++) // заполнение вниз
        {
            matrix[i, j] = count++;
        }
        --i;
        x = --j;
        for (j = x; j > -1 + n; j--) // заполнение на лево
        {
            matrix[i, j] = count++;
        }
        y = --i;
        x = ++j;
        n++;
        for (i = y; i > -1 + n; i--) // заполнение вверх
        {
            matrix[i, j] = count++;
        }
        x = ++j;
        y = ++i;
    }
    return matrix;
}

void WriteMatrix (int[,] matrix)
{
    string write = String.Empty;
    int len = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            write = Convert.ToString(matrix[i, j]);
            len = write.Length;
            for (int k = 0; k < 4 - len; k++)
            {
                write = write.Insert(0, " ");
            }
            Console.Write($"{write} ");
        }
        Console.WriteLine("");
    }
}

int razmer = 5;
int[,] matrix = GetMatrix(razmer);
WriteMatrix (matrix);