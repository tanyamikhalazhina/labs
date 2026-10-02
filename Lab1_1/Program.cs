//Console.WriteLine("Введите четырехзначное число");
//int x=int.Parse(Console.ReadLine());
//int a = x % 10;
//int b = x % 100/10;
//int c = x % 1000/100;
//int d = x / 1000;
//int y = d + c*10 + b*100 + a*1000;
//int z = c*1000 + d*100 + a*10 + b;
//int w = d * 1000 + b*100 + c*10 + a;
//int h = b*1000+ a*100 + c*10 + d;
//int i = a*1000 + b*100 +d*10 +c;
//Console.WriteLine($"а){y}");
//Console.WriteLine($"б){z}");
//Console.WriteLine($"в){w}");
//Console.WriteLine($"г1){h}");
//Console.WriteLine($"г2){i}");

//try
//{
//    Console.WriteLine("Введите x:");
//    double x = double.Parse(Console.ReadLine());
//    if (x < 4) Console.WriteLine("Первая область:");
//    else Console.WriteLine("Вторая область:");
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}


//try
//{
//    Console.WriteLine("Введите x:");
//    double x = double.Parse(Console.ReadLine());
//    Console.WriteLine("Введите y:");
//    double y = double.Parse(Console.ReadLine());
//    double max, min;
//    if(x>y)
//    {
//        max = x;
//        min = y;
//    }
//    Console.WriteLine($"max={max},min={min}");
// }
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//Console.WriteLine("Введите a:");
//double a = double.Parse(Console.ReadLine());
//Console.WriteLine("Введите b:");
//double b = double.Parse(Console.ReadLine());
//Console.WriteLine("Введите c:");
//double c = double.Parse(Console.ReadLine());
//if ((a < b) && (b < c)) Console.WriteLine($"");
//else Console.WriteLine("");


//try
//{
//    Console.Write("Введите m:");
//    int m = int.Parse(Console.ReadLine());
//    int a = m / 100;
//    int b = m / 10 % 10;
//    int c = m % 10;
//    if ((a == 3 || b == 3 || c == 3) || (a == 6 || b == 6 || c == 6) || (a == 9 || b == 9 || c == 9)) Console.WriteLine("Да");
//    else Console.WriteLine("Нет");
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}


using System.ComponentModel.Design;

//Вариант 8 Базовый уровень
//try
//{
//    Console.WriteLine("Введите стороны первого треугольника:");
//    Console.WriteLine("Введите a1:");
//    double a1 = double.Parse(Console.ReadLine());
//    Console.WriteLine("Введите b1:");
//    double b1 = double.Parse(Console.ReadLine());
//    Console.WriteLine("Введите c1:");
//    double c1 = double.Parse(Console.ReadLine());
//    Console.WriteLine("Введите стороны второго треугольника:");
//    Console.WriteLine("Введите a2:");
//    double a2 = double.Parse(Console.ReadLine());
//    Console.WriteLine("Введите b2:");
//    double b2 = double.Parse(Console.ReadLine());
//    Console.WriteLine("Введите c2:");
//    double c2 = double.Parse(Console.ReadLine());
//    double h1 = Math.Sqrt(a1 * a1 - c1 * c1 / 4);
//    double h2 = Math.Sqrt(a2 * a2 - c2 * c2 / 4);
//    double s1 = a1 * h1 / 2;
//    double s2 = a2 * h2 / 2;
//    if (s1 > s2)
//        Console.WriteLine("Площадь первого треугольника больше");
//    else Console.WriteLine("Площадь второго треугольника больше");
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}