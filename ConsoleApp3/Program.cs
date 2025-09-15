using System;
class Program()
{
    static void Main(string[] args)
    {

        task1();
        
    }
    static void task1()
    {
        double a = 0.0;
        double b = 0.0;

        double x = 0;
        double y = 0;
        double z = 0;

        int flag = 1;
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
        int x1 = Convert.ToInt32(Console.ReadLine());
        int y1 = Convert.ToInt32(Console.ReadLine());
        int x2 = Convert.ToInt32(Console.ReadLine());
        int y2 = Convert.ToInt32(Console.ReadLine());
        int x3 = Convert.ToInt32(Console.ReadLine());
        int y3 = Convert.ToInt32(Console.ReadLine());
        if (y1 == y2)
        {
            y4 = y3;
            x4 = Math.Abs(x1 - x2) + x3;
        } else if (y1 == y3)
        {
            y4 = y2;
            x4 = Math.Abs(x1 - x3) + x2;
        } else if(y3 == y2)
        {
            y4 = y1;
            x4 = Math.Abs(x3 - x2) + x1;
        }
        Console.WriteLine();
        Console.WriteLine(x4 + " " + y4);
    }
   
    static void task3()
    {
        string res;
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());

        int pro = a * b * c;
        int sym = a + b + c;

        if (pro == sym) res = "Равны";
        else res = (a * b * c) > (a + b + c) ? "Произведение" : "Сумма";

        Console.WriteLine(res);
    }

    static void task4()
    {
        double y, x, R, a, b;
        Console.WriteLine("Выберите 1-4");
        int k = Convert.ToInt32(Console.ReadLine());
        switch (k)
        {
            case 1:
                x = Convert.ToDouble(Console.ReadLine());
                y = Math.Exp(2)*Math.Sin(x)*Math.Pow(Math.Tan(x), 2);
                Console.WriteLine(y);
                break;
            case 2:
                R = Convert.ToDouble(Console.ReadLine());
                y = Math.PI * R * R;
                Console.WriteLine(y);
                break;
            case 3:
                R = Convert.ToDouble(Console.ReadLine());
                y = 4 / (3 * Math.PI * R) + 2.1;
                Console.WriteLine(y);
                break;
            case 4:
                a = Convert.ToDouble(Console.ReadLine());
                b = Convert.ToDouble(Console.ReadLine());
                x = Convert.ToDouble(Console.ReadLine());
                y = Math.Pow(a * Math.Cos(b * x), 2);
                Console.WriteLine(y);
                break;
        }
    }

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
    }
}
