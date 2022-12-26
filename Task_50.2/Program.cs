Console.WriteLine("Введите кол-во строк массив m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов массив n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер элемента (первое число - столбец, начиная с 0, второе - строка, начиная с 0): ");
int k = Convert.ToInt32(Console.ReadLine());
int m1,n1 = 0;
n1 = k%10;
m1 = k/10;
//System.Console.WriteLine(m1 + " " + n1);

int[,] NewArr (int m, int n)
{
    int[,] arr = new int[m,n];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++) 
        {
            arr[i,j] = rand.Next(0, 10);
            System.Console.Write(arr[i,j] + " ");
        }
        System.Console.WriteLine();
    }
    return arr;
}

void GetNumber (int [,] arr)
{
    if (m1 > m-1 || n1 > n)
    System.Console.WriteLine("Такого элемента нет");
    else
    int num = arr[m1,n1-1];
    System.Console.WriteLine(num);
}

int[,] arr = NewArr(m,n);
GetNumber(arr);