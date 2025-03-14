class Program
{
    static void Main()
    {
        Console.Write("Ingrese el número a descomponer: ");
        int num = int.Parse(Console.ReadLine()!);

        int[][] matrix = new int[50][2];
        int top = 0;

        matrix[top][0] = num;
        int i;

        while (!IsPrime(matrix[top][0]))
        {
            for (i = 2; i < matrix[top][0]; i++)
            {
                if (matrix[top][0] % i == 0)
                    break;
            }
            matrix[top][1] = i;
            matrix[top + 1][0] = matrix[top][0] / i;
            top++;
        }
        matrix[top][1] = matrix[top][0];

        string fac = num + " = ";
        for (i = 0; i <= top; i++)
        {
            fac += matrix[i][1] + " x ";
        }
        Console.WriteLine(fac);
    }

    public static bool IsPrime(int num)
    {
        for (int i = 2; i <= num / 2; i++)
        {
            if (num % i == 0)
            return false;
        }
        return true;
    }
}