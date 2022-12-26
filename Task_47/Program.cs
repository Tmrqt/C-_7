Console.WriteLine("Введите кол-во строк массив m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов массив n: ");
int n = Convert.ToInt32(Console.ReadLine());

void NewArr (int m, int n)
{
    double[,] arr = new double[m,n];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++) 
        {
            arr[i,j] = Convert.ToDouble(rand.Next(-100, 100)) / 10;
            System.Console.Write(arr[i,j] + " ");
        }
        System.Console.WriteLine();
    }
}

NewArr(m,n);