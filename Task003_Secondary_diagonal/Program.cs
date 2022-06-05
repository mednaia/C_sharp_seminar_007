//Посчитать сумму элементов побочной диагонали матрицы
char choice;

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

void SumSecondaryDiagonal(int[,] matrix)
{
    Console.WriteLine("1. The diagonal begins from columns.");
    Console.WriteLine("2. The diagonal begins from row.");
    Console.WriteLine("Choose the startpoint of diagonal (1 or 2) and press Enter: ");
    choice = Convert.ToChar(Console.ReadLine() ?? "0");
    switch (choice)
        {
            case '1':
                Console.Write("Enter number of rows (from 0 to N) to start: ");
                int i1 = int.Parse(Console.ReadLine() ?? "0");
                int j1 = 0;
                int sumC = 0;
                while(i1<matrix.GetLength(0) && j1<matrix.GetLength(1))
                    {
                        sumC=sumC+matrix[i1,j1];
                        i1++;
                        j1++;
                    }
                    Console.WriteLine($"{sumC}");
                    break;
            case '2':
                Console.Write("Enter number of columns (from 0 to N) to start: ");
                int j2 = int.Parse(Console.ReadLine() ?? "0");
                int i2 = 0;
                int sumR = 0;  
                while(i2<matrix.GetLength(0) && j2<matrix.GetLength(1))
                    {
                        sumR=sumR+matrix[i2,j2];
                        i2++;
                        j2++;
                    }
                    Console.WriteLine($"{sumR}");
                    break;
            default:
                Console.WriteLine("Incorrect value");
                break;
        }
}

Console.Write("Enter amount of matrix rows: ");
int rows = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Enter amount of matrix columns: ");
int columns = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Enter left side of matrix columns: ");
int start = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Enter right side of matrix columns: ");
int finish = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = CreateMatrix(rows,columns,start,finish);
Console.WriteLine("Your matrix: ");
PrintMatrix(matrix);
SumSecondaryDiagonal(matrix);
