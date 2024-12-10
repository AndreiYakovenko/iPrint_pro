internal class Program
{
    private static void Main(string[] args)
    {
        double[,] price =
        {
            {7.00, 6.65, 6.32, 6.00},
            {10.5, 8.65, 8.21, 7.80},
            {5.00, 4.75, 4.51, 4.29},
            {7.50, 6.18, 5.87, 5.57},
            {5.00, 4.75, 4.51, 4.29},
            {7.50, 6.18, 5.87, 5.57},
            {4.00, 3.80, 3.61, 3.43},
            {6.00, 4.94, 4.69, 4.46},
        };
        // for (int i = 0; i < price.GetLength(0); i++)
        // {
        //     for (int j = 0; j < price.GetLength(1); j++)
        //     {
        //         Console.Write(price[i, j].ToString("F2") + "    ");
        //     }
        //     Console.WriteLine();
        // }
        int format;
        int color;
        int desing;
        int number;
        int type = 0;
        int volume = 0;
        string typePrint;
        string[] arrayTypePrint = { "111", "112", "121", "122", "211", "212", "221", "222" };
        int[] arrayNumber = { 1, 2, 3, 4 };

        Console.WriteLine();
        Console.WriteLine("Введите нужный формат:\nдля А4 нажмите 1,\nдля А5 нажмите 2");
        format = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Введите нужный цвет:\nдля Цветной печати нажмите 1,\nдля Чёрно-белой печати нажмите 2");
        color = Convert.ToInt32(Console.ReadLine()); ;
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Введите нужный макет:\nдля Односторонней печати нажмите 1,\nдля Двусторонней печати нажмите 2");
        desing = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Введите количество страниц:");
        number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("Ваш заказ:");

        if (format == 1)
        {
            Console.WriteLine("Формат листов А4");
        }
        else
        {
            Console.WriteLine("Формат листов А5");
        }

        if (color == 1)
        {
            Console.WriteLine("Цветная печать");
        }
        else
        {
            Console.WriteLine("Чёрно-белая печать");
        }

        if (desing == 1)
        {
            System.Console.WriteLine("Односторонняя");
        }
        else
        {
            Console.WriteLine("Двусторонняя");
        }
        Console.WriteLine("Количество страниц: " + number);
        Console.WriteLine();

        typePrint = Convert.ToString(color) + format + desing;

        for (int i = 0; i <= 7; i++)
        {
            if (typePrint == arrayTypePrint[i])
            {
                type = i;
                break;
            }
        }

        if (number <= 50)
        {
            volume = 0;
        }
        if (number >= 51 && number <= 100)
        {
            volume = 1;
        }
        if (number >= 101 && number <= 300)
        {
            volume = 2;
        }
        if (number >= 301)
        {
            volume = 3;
        }

        Console.WriteLine("Стоимость печати одного листа:     " + price[type, volume] + " рублей");
        Console.WriteLine("Стоимость печати данной позиции: " + Math.Round((price[type, volume] * number), 2) + " рублей");
        Console.WriteLine();
    }
}