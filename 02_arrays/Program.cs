using System;

class Program
{
    static void Main()
    {
        //================Task #1===========================
        //int[] array = { 1, 2, 3, 4, 5, 2, 4, 6, 8, 1, 3, 7 };

        // DisplayArrayInfo(array);
        //===================================================
        //================Task #2============================
        //Console.Write("Enter array's size: ");
        //int size = int.Parse(Console.ReadLine());

        //int[] array = new int[size];

        //for (int i = 0; i < size; i++)
        //{
        //    Console.Write($"Enter element {i + 1}: ");
        //    array[i] = int.Parse(Console.ReadLine());
        //}

        //Console.Write("Entr the treshold value: ");
        //int threshold = int.Parse(Console.ReadLine());

        //int countBelowThreshold = CountValuesBelowThreshold(array, threshold);

        //Console.WriteLine($"Number of values less than {threshold}: {countBelowThreshold}");

        //============================================================================
        //================Task #3============================================
        //double[] A = new double[5];
        //double[,] B = new double[3, 4];

        //Console.WriteLine("Enter element of array A:");

        //for (int i = 0; i < A.Length; i++)
        //{
        //    Console.Write($"Element {i + 1}: ");
        //    A[i] = double.Parse(Console.ReadLine());
        //}

        //Random random = new Random();

        //for (int i = 0; i < B.GetLength(0); i++)
        //{
        //    for (int j = 0; j < B.GetLength(1); j++)
        //    {
        //        B[i, j] = random.NextDouble() * 10;
        //    }
        //}

        //Console.WriteLine("\nArray A:");
        //DisplayArray(A);

        //Console.WriteLine("\nArray B (matrix):");
        //DisplayMatrix(B);

        //Console.WriteLine($"\nMax element: {GetMaxElement(A, B)}");
        //Console.WriteLine($"Min element: {GetMinElement(A, B)}");
        //Console.WriteLine($"Summa of all elements: {GetTotalSum(A, B)}");
        //Console.WriteLine($"Production of all elements: {GetTotalProduct(A, B)}");
        //Console.WriteLine($"Summa of even elements of array A: {GetSumOfEvenElements(A)}");
        //Console.WriteLine($"Summa of odd elements of array B: {GetSumOfOddColumns(B)}");
        //=============Task #4==========================================
        int[,] array = new int[5, 5];
        Random random = new Random();

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = random.Next(-100, 101);
            }
        }

        Console.WriteLine("2-demention array:");
        DisplayMatrix(array);

        int minIndexI, minIndexJ, maxIndexI, maxIndexJ;
        FindMinMaxIndexes(array, out minIndexI, out minIndexJ, out maxIndexI, out maxIndexJ);

        int sumBetweenMinMax = SumBetweenMinMax(array, minIndexI, minIndexJ, maxIndexI, maxIndexJ);

        Console.WriteLine($"Summa of elements between minimal ({array[minIndexI, minIndexJ]}) and maximal ({array[maxIndexI, maxIndexJ]}) elements: {sumBetweenMinMax}");
        //===============================================================
    }


    //======================== Task #1===============================
    //static void DisplayArrayInfo(int[] array)
    //{
    //    Console.WriteLine("Arrays elements : " + string.Join(", ", array));

    //    int evenCount = 0;
    //    int oddCount = 0;
    //    int uniqueCount = 0;

    //    foreach (var number in array)
    //    {
    //        if (number % 2 == 0)
    //        {
    //            evenCount++;
    //        }
    //        else
    //        {
    //            oddCount++;
    //        }
    //    }
    //    for (int i = 0; i < array.Length; i++)
    //    {
    //        bool isUnique = true;
    //        for (int j = 0; j < array.Length; j++)
    //        {
    //            if (i != j && array[i] == array[j])
    //            {
    //                isUnique = false;
    //                break;
    //            }
    //        }
    //        if (isUnique)
    //        {
    //            uniqueCount++;
    //        }
    //    }

    //    Console.WriteLine($"Number of even elements: {evenCount}");
    //    Console.WriteLine($"Number of odd elements: {oddCount}");
    //    Console.WriteLine($"Number of unique elements: {uniqueCount}");
    //}
    //==========================================================================
    //=======================Task #2==============================
    //static int CountValuesBelowThreshold(int[] array, int threshold)
    //{
    //    int count = 0;

    //    foreach (var number in array)
    //    {
    //        if (number < threshold)
    //        {
    //            count++;
    //        }
    //    }

    //    return count;
    //}
    //===========================================================================
    //==================Task #3===========================================
    //static void DisplayArray(double[] array)
    //{
    //    Console.WriteLine(string.Join(", ", array));
    //}

    //static void DisplayMatrix(double[,] matrix)
    //{
    //    for (int i = 0; i < matrix.GetLength(0); i++)
    //    {
    //        for (int j = 0; j < matrix.GetLength(1); j++)
    //        {
    //            Console.Write($"{matrix[i, j],8:F2} ");
    //        }
    //        Console.WriteLine();
    //    }
    //}

    //static double GetMaxElement(double[] array, double[,] matrix)
    //{
    //    return Math.Max(array.Max(), matrix.Cast<double>().Max());
    //}

    //static double GetMinElement(double[] array, double[,] matrix)
    //{
    //    return Math.Min(array.Min(), matrix.Cast<double>().Min());
    //}

    //static double GetTotalSum(double[] array, double[,] matrix)
    //{
    //    return array.Sum() + matrix.Cast<double>().Sum();
    //}

    //static double GetTotalProduct(double[] array, double[,] matrix)
    //{
    //    return array.Aggregate(1.0, (current, element) => current * element) *
    //           matrix.Cast<double>().Aggregate(1.0, (current, element) => current * element);
    //}

    //static double GetSumOfEvenElements(double[] array)
    //{
    //    return array.Where(x => x % 2 == 0).Sum();
    //}

    //static double GetSumOfOddColumns(double[,] matrix)
    //{
    //    double sum = 0;

    //    for (int j = 0; j < matrix.GetLength(1); j++)
    //    {
    //        if (j % 2 != 0)
    //        {
    //            for (int i = 0; i < matrix.GetLength(0); i++)
    //            {
    //                sum += matrix[i, j];
    //            }
    //        }
    //    }

    //    return sum;
    //}
    //==================================================================
    //===============Task #4========================================


    static void DisplayMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j],4} ");
            }
            Console.WriteLine();
        }
    }

    static void FindMinMaxIndexes(int[,] matrix, out int minI, out int minJ, out int maxI, out int maxJ)
    {
        minI = minJ = maxI = maxJ = 0;

        int minValue = matrix[0, 0];
        int maxValue = matrix[0, 0];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] < minValue)
                {
                    minValue = matrix[i, j];
                    minI = i;
                    minJ = j;
                }

                if (matrix[i, j] > maxValue)
                {
                    maxValue = matrix[i, j];
                    maxI = i;
                    maxJ = j;
                }
            }
        }
    }

    static int SumBetweenMinMax(int[,] matrix, int minI, int minJ, int maxI, int maxJ)
    {
        int sum = 0;

        int startI = Math.Min(minI, maxI);
        int endI = Math.Max(minI, maxI);
        int startJ = Math.Min(minJ, maxJ);
        int endJ = Math.Max(minJ, maxJ);

        for (int i = startI; i <= endI; i++)
        {
            for (int j = startJ; j <= endJ; j++)
            {
                sum += matrix[i, j];
            }
        }

        return sum;
    }
}
