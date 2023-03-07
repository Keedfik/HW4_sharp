// Задача 25: Напишите цикл, который принимает 
// на вход два числа (A и B) и возводит 
// число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
/*
Console.Write("Input a number ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input an exponent ");
int b = Convert.ToInt32(Console.ReadLine());
int result = 1;
for(int i = 0; i < b; i++ ){
    result *= a;
}
Console.WriteLine($"Number {a} raised to the power of {b} is {result}");
*/

// Задача 27: Напишите программу, которая 
// принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
/*
 int Sum(int num){
    int result = 0;
    while(num > 0){
        result += num % 10;
        num = num / 10; 
    }
    return result;
}

System.Console.Write("Input number ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Sum(num));
*/

// Задача 29: Напишите программу, которая 
// задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
/*
int[] FillArray(int size, int a, int b){
    int[] arr = new int[size];
    Random rnd = new Random();

    for(int i = 0; i < arr.Length; i++){
        arr[i] = rnd.Next(a, b);
    }
    return arr;
}
Console.Write("Input array size ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min number ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max number ");
int b = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(size, a, b);
Console.WriteLine($"[{string.Join(", ", array)}]");
*/