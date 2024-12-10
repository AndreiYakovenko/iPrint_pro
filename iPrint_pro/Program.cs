internal class Program
{
    private static void Main(string[] args)
    {
        // Формируем массив, который будет соответствовать нашему прайсу
        double[,] price = {
                {7, 6.65, 6.32, 6},
                {10.5, 8.65, 8.21, 7.8},
                {5, 4.75, 4.51, 4.29},
                {7.5, 6.18, 5.87, 5.57},
                {5, 4.75, 4.51, 4.29},
                {7.5, 6.18, 5.87, 5.57},
                {4, 3.8, 3.61, 3.43},
                {6, 4.94, 4.69, 4.46},
                {100, 120, 140, 160}
};
        for (int i = 0; i < price.GetLength(0); i++)
        {
            for (int j = 0; j < price.GetLength(1); j++)
                Console.Write(price[i, j] + " ");
            Console.WriteLine();
        }
    }
}