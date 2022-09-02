/* Задача 59: Из двумерного массива целых чисел удалить строку и столбец, 
на пересечении которых расположен наименьший элемент. */
using static System.Console;
using System.Linq;
Clear();

WriteLine("Введите размер массива через пробел: ");
int[] parametrs = ReadLine()!
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();
int[,] array = CreateMatrix(parametrs[0], parametrs[1]);
WriteLine();
PrintMatrix(array);
WriteLine();
int MinElement = FindMinElementMatrix(array);
WriteLine(MinElement);
string coordinates = FindCoordinatesMinElementMatrix(array, MinElement);
WriteLine(coordinates);
int[] parametrsForDelete = coordinates
                        .Split(new char[] { ' ', ';', '(', ')' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(x => int.Parse(x))
                        .ToArray();
WriteLine(string.Join(" ", parametrsForDelete));
int[,] arrayResult = CreateMatrix((parametrs[0] - parametrsForDelete.Length / 2), (parametrs[1] - parametrsForDelete.Length / 2));
CreateResultMatrix(array, arrayResult, parametrsForDelete);
PrintMatrix(arrayResult);





int[,] CreateMatrix(int rows, int columns)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(0, 100);
        }
    }
    return result;
}
void PrintMatrix(int[,] matrixForPrint)
{
    for (int i = 0; i < matrixForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixForPrint.GetLength(1); j++)
        {
            Write(matrixForPrint[i, j] < 10 ? $"0{matrixForPrint[i, j]} " : $"{matrixForPrint[i, j]} ");
        }
        WriteLine();
    }
}
int FindMinElementMatrix(int[,] arrayForFindMinElement)
{
    int minElementMatrix = arrayForFindMinElement[0, 0];
    for (int i = 0; i < arrayForFindMinElement.GetLength(0); i++)
    {
        for (int j = 0; j < arrayForFindMinElement.GetLength(1); j++)
        {
            if (i == 0 && j == 0) break;
            if (arrayForFindMinElement[i, j] < minElementMatrix)
            {
                minElementMatrix = arrayForFindMinElement[i, j];
            }
        }
    }

    return minElementMatrix;
}
string FindCoordinatesMinElementMatrix(int[,] matrixForFindCoordinates, int minElementMatrix)
{
    string coordinatesMinElementMatrix = string.Empty;
    for (int i = 0; i < matrixForFindCoordinates.GetLength(0); i++)
    {
        for (int j = 0; j < matrixForFindCoordinates.GetLength(1); j++)
        {
            if (matrixForFindCoordinates[i, j] == minElementMatrix)
            {
                coordinatesMinElementMatrix += $"({i};{j}) ";
            }
        }
    }
    return coordinatesMinElementMatrix;
}

void CreateResultMatrix(int[,] arrayForDeleteRowsAndColumns, int[,] resultMatrix, int[] coordinatesMatrix)
{
    int i = 0;
    int icount = 0;
    int jcount = 0;

    while (i < arrayForDeleteRowsAndColumns.GetLength(0))
    {
        int j = 0;
        while (j < arrayForDeleteRowsAndColumns.GetLength(1))
        {
            for (int k = 0; k < coordinatesMatrix.Length; k += 2)
            {
                if (i == coordinatesMatrix[k])
                {
                    icount++;
                    i++;
                    if(i < arrayForDeleteRowsAndColumns.GetLength(0))
                    {
                        break;
                    }
                }
            }
            for (int l = 1; l < coordinatesMatrix.Length; l += 2)
            {
                if (j == coordinatesMatrix[l])
                {
                    jcount++;
                    j++;
                    if(j < arrayForDeleteRowsAndColumns.GetLength(1))
                    {
                        break;
                    }
                }
            }
            resultMatrix[i - icount, j - jcount] = arrayForDeleteRowsAndColumns[i, j];
            j++;
        }
        i++;
    }
}

