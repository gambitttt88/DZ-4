/* Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
Console.Write("Введи число: ");
int limit = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма чисел от 1 до {limit} равна {GetSum(limit)}");
Console.Write("Введи число: ");
int Num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма чисел от 1 до {Num} равна {GetSum(Num)}");
// ------------Методы---------------
int GetSum(int A){
    int sum = 0;
    for(int i = 1; i <= A; i++){
        sum += i; // sum = sum + i
    }
    return sum;
}*/

/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Write("Введи число A ");
int Num = int.Parse(Console.ReadLine()!);
Console.Write("Введи число B ");
int Num2 = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{MetodStepeni(Num, Num2)}");

// ------------Методы---------------
int MetodStepeni(int A, int B){
    int result = 1;
    for(int i = 1; i <= B; i++){
        
        result = result * A;
    }
    return result;
}*/

/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр числа {N} равна {CountNums(N)}");


// метод //
int CountNums(int num){
    int count = 0;
    if (num == 0) return 1;
    while ( num > 0){
        count = count + (num % 10);
        num = num / 10;
    }
    return count;
}*/

//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] GetArray(int size){
    int[] myArray = new int[size];
    for(int i = 0; i < size; i++){
        myArray[i] = new Random().Next();
    }
    return myArray;
}

int[] myArray = GetArray(8);
Console.WriteLine($"[{String.Join(',', myArray)}]");