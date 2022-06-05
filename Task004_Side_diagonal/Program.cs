//Посчитать сумму элементов побочной диагонали матрицы
void PrintMatrix(int[,] matrix)
{
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j<matrix.GetLength(1); j++)
            Console.Write($"{matrix[i,j]} ");
    Console.WriteLine();
    }
}
int[,] CreateMatrix(int rows, int columns, int minValue, int maxValue)
{
    int[,] matrix = new int[rows,columns];
    var random = new Random();
    for(int i=0;i<rows;i++)
        for(int j=0;j<columns;j++)
            matrix[i,j] = random.Next(minValue,maxValue);
    return matrix;
}


int SumSideDiagonal(int[,] matrix)
{
    int sum = 0;
    for (int i=0; i<matrix.GetLength(0); i++)
        for (int j=0; j<matrix.GetLength(1); j++)
            if(i+j==matrix.GetLength(0)-1)
            {
                sum=sum+matrix[i,j];
            }
    return sum;
}

Console.Write("Enter amount of matrix rows and columns: ");
int rows = int.Parse(Console.ReadLine() ?? "0");
int columns = rows;
Console.Write("Enter left side of matrix columns: ");
int start = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Enter right side of matrix columns: ");
int finish = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = CreateMatrix(rows,columns,start,finish);
Console.WriteLine("Your matrix: ");
PrintMatrix(matrix);
Console.WriteLine($"Sum of diagonal elements of array: {SumSideDiagonal(matrix)}.");