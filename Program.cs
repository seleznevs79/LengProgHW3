// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
// (первое == последнему, второе == предпоследнему).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write(" Введите  число ");
int number = int.Parse(Console.ReadLine()!);
string NumStr = number.ToString();

 if(NumStr.Length == 5){
    if(NumStr[0] == NumStr[4] && NumStr[1] == NumStr[3]){
           Console.WriteLine($"Число {number} является полиндромом"); 
    }
    else Console.WriteLine($"Число {number} не является полиндромом");
}
else
 Console.WriteLine($"Число {number} не пятизначное");




// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


// Console.Write("Введите x точки A: ");
// int xa = int.Parse(Console.ReadLine()!);

// Console.Write("Введите y точки A: ");
// int ya = int.Parse(Console.ReadLine()!);

// Console.Write("Введите z точки A: ");
// int za = int.Parse(Console.ReadLine()!);

// Console.Write("Введите x точки B: ");
// int xb = int.Parse(Console.ReadLine()!);

// Console.Write("Введите y точки B: ");
// int yb = int.Parse(Console.ReadLine()!);

// Console.Write("Введите z точки B: ");
// int zb = int.Parse(Console.ReadLine()!);

// double s = Math.Sqrt(Math.Pow((xb-xa), 2)+Math.Pow((yb-ya), 2)+Math.Pow((zb-za), 2) );
// Console.WriteLine($"Расстояние между A и B равно {s:f2}");


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.WriteLine("Введите число ");
// int num = int.Parse(Console.ReadLine()!);

// int index = 1;

// while (index <= num)
// {
// Console.WriteLine(Math.Pow(index, 3));

// index++;
// }
