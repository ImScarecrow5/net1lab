using System;

struct Helicopter
{
    public string Model;
    public string SerialNumber;
    public double MaxTakeoffWeight;
    public double MaxSpeed;
    public double Range;

    public void show()
    {
        Console.WriteLine($"Model: {Model},\nSerial number: {SerialNumber},\n" +
            $"Max take off weight: {MaxTakeoffWeight},\nMax speed: {MaxSpeed},\n" +
            $"Range: {Range}");
    }
    public void inPUT()
    {
        int vibor;
        while (true)
        {
            Console.WriteLine("Что хотите ввести?\n1)Модель\n2)Серийный номер\n3)Перевозимый вес\n4)Максимальная скорость\n5)Длина\n0)Выход\n");
            vibor = Convert.ToInt32(Console.ReadLine());
            switch (vibor)
            {
                case 1:
                    try
                    {
                        Console.WriteLine("Введите значение:");
                        this.Model = Console.ReadLine();
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Неверный ввод данных");
                        break;
                    }
                case 2:
                    try
                    {
                        Console.WriteLine("Введите значение:");
                        this.SerialNumber = Console.ReadLine();
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Неверный ввод данных");
                        break;
                    }
                case 3:
                    try {
                        Console.WriteLine("Введите значение:");
                        this.MaxTakeoffWeight = Convert.ToDouble(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Неверный ввод данных");
                        break;
                    }
                    
                case 4:
                    try
                    {
                        Console.WriteLine("Введите значение:");
                        this.MaxSpeed = Convert.ToDouble(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Неверный ввод данных");
                        break;
                    }
                case 5:
                    try
                    {
                        Console.WriteLine("Введите значение:");
                        this.Range = Convert.ToDouble(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Неверный ввод данных");
                        break;
                    }
                case 0:
                    return;
                default:
                    Console.WriteLine("Неверный ввод данных");
                    break;
            }
        }
    }

}

class Program
{
    static void Main(string[] args)
    {
        int choice;
        Helicopter hel = new Helicopter();
        hel.Model = "undefined";
        hel.SerialNumber = "undefined";
        hel.MaxTakeoffWeight = 0;
        hel.Range = 0;
        hel.MaxSpeed = 0;

        while (true)
        {
            Console.WriteLine("Выберите (1-5). Нажмите 0 для выхода из программы.");
            Console.WriteLine("1)Найти значение уравнения\n2)Найти вершину параллелограмма\n3)Сравнить сумму и произведение чисел\n4)Система уравнений\n5)Ввод данных в структуру\n6)Информация о структуре\n");
            Console.WriteLine("Ваш выбор: ");
            
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Неверный ввод данных");
                continue;
            }

            switch(choice)
            {
                case 1:
                    task1();
                    break;
                case 2:
                    task2();
                    break;
                case 3:
                    task3();
                    break;
                case 4:
                    task4();
                    break;
                case 5:
                    hel.inPUT();
                    break;
                case 6:
                    hel.show();
                    break;
                case 0:
                    return;
                default:
                    Console.WriteLine("Нет такой функции");
                    break;
            }
        }  
    }

    static void task1()
    {
        double a = 0.0;
        double b = 0.0;
        double x = 0;
        double y = 0;
        double z = 0;

        int flag = 1;
        Console.WriteLine("Введите x, y и z: ");
        while (flag == 1)
        {
            try
            {
                x = Convert.ToDouble(Console.ReadLine());
                y = Convert.ToDouble(Console.ReadLine());
                z = Convert.ToDouble(Console.ReadLine());
                flag = 0;
            }
            catch
            {
                Console.WriteLine("Неверный ввод данных");
            }
        }

        a = ((1 + Math.Pow(Math.Sin(x + y), 2)) / (2 + Math.Abs(x - (2 * x) / (1 + x * x * y * y))) + x);
        b = Math.Pow(Math.Cos(Math.Atan(1 / z)), 2);
        Console.WriteLine($"Результат для а: {a}\nРезультат для b: {b}");
    }

    static void task2()
    {
        int x4 = 0;
        int y4 = 0;
        int x1, y1, x2, y2, x3, y3;
        
        Console.WriteLine("Введите координаты трех вершин параллелограмма (x1 y1 x2 y2 x3 y3):");
        
        int flag = 1;
        while (flag == 1)
        {
            try
            {
                x1 = Convert.ToInt32(Console.ReadLine());
                y1 = Convert.ToInt32(Console.ReadLine());
                x2 = Convert.ToInt32(Console.ReadLine());
                y2 = Convert.ToInt32(Console.ReadLine());
                x3 = Convert.ToInt32(Console.ReadLine());
                y3 = Convert.ToInt32(Console.ReadLine());
                flag = 0;
                if (((y1 == y2) && (y2 == y3)) || ((x1 == x2) && (x2 == x3)) || ((y1 == y2) && (x1 == x2)) || ((x2 == x3) && (y2 == y3)) || ((y1 == y3) || (x1 == x3))) Console.WriteLine("Это не параллелограмм!");
                if (y1 == y2)
                {
                    y4 = y3;
                    x4 = Math.Abs(x1 - x2) + x3;
                }
                else if (y1 == y3)
                {
                    y4 = y2;
                    x4 = Math.Abs(x1 - x3) + x2;
                }
                else if (y3 == y2)
                {
                    y4 = y1;
                    x4 = Math.Abs(x3 - x2) + x1;
                }
                Console.WriteLine();
                Console.WriteLine(x4 + " " + y4);
            }
            catch
            {
                Console.WriteLine("Неверный ввод данных. Введите целые числа:");
            }
        }
    }
   
    static void task3()
    {
        string res;
        int a, b, c;
        
        Console.WriteLine("Введите три целых числа:");
        
        int flag = 1;
        while (flag == 1)
        {
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                c = Convert.ToInt32(Console.ReadLine());
                flag = 0;

                int pro = a * b * c;
                int sym = a + b + c;

                if (pro == sym) res = "Равны";
                else res = (a * b * c) > (a + b + c) ? "Произведение" : "Сумма";

                Console.WriteLine(res);
            }
            catch
            {
                Console.WriteLine("Неверный ввод данных. Введите целые числа:");
            }
        }
    }

    static void task4()
    {
        double y, x, R, a, b;
        Console.WriteLine("Выберите 1-4");
        
        int k;
        int flag = 1;
        while (flag == 1)
        {
            try
            {
                k = Convert.ToInt32(Console.ReadLine());
                flag = 0;

                switch (k)
                {
                    case 1:
                        Console.WriteLine("Введите x:");
                        x = Convert.ToDouble(Console.ReadLine());
                        y = Math.Exp(2) * Math.Sin(x) * Math.Pow(Math.Tan(x), 2);
                        Console.WriteLine(y);
                        break;
                    case 2:
                        Console.WriteLine("Введите R:");
                        R = Convert.ToDouble(Console.ReadLine());
                        y = Math.PI * R * R;
                        Console.WriteLine(y);
                        break;
                    case 3:
                        Console.WriteLine("Введите R:");
                        R = Convert.ToDouble(Console.ReadLine());
                        y = 4 / (3 * Math.PI * R) + 2.1;
                        Console.WriteLine(y);
                        break;
                    case 4:
                        Console.WriteLine("Введите a, b и x:");
                        a = Convert.ToDouble(Console.ReadLine());
                        b = Convert.ToDouble(Console.ReadLine());
                        x = Convert.ToDouble(Console.ReadLine());
                        y = Math.Pow(a * Math.Cos(b * x), 2);
                        Console.WriteLine(y);
                        break;
                    default:
                        Console.WriteLine("Неверный выбор");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Неверный ввод данных. Введите число от 1 до 4:");
            }
        }
    }
}
