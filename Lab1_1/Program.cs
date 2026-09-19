//Console.Writeline($"{Math.PI:F2}");
//Console.WriteLine($"{Maht.E:F1}");
//int a = int.Parse(Console.ReadLine());
//Console.WriteLine($"Вы ввели число:"); 
//int a = int.Parse( Console.ReadLine() );
//Console.WriteLine($"{a}-Вот какое число вы ввели");
//Console.WriteLine("1 13 49");
//Console.WriteLine("7  15  100");


//Console.Write("Введите a:");
//double a = double.Parse(Console.ReadLine());






Console.WriteLine("Введите четырехзначное число");
int x=int.Parse(Console.ReadLine());
int a = x % 10;
int b = x % 100/10;
int c = x % 1000/100;
int d = x / 1000;
int y = d + c*10 + b*100 + a*1000;
int z = c*1000 + d*100 + a*10 + b;
int w = d * 1000 + b*100 + c*10 + a;
int h = b*1000+ a*100 + c*10 + d;
int i = a*1000 + b*100 +d*10 +c;
Console.WriteLine($"а){y}");
Console.WriteLine($"б){z}");
Console.WriteLine($"в){w}");
Console.WriteLine($"г1){h}");
Console.WriteLine($"г2){i}");

