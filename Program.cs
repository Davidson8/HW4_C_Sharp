
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/* 
int GetNumber (int a, int b) 
{   
    int number = a;
    for (int i = 1; i < b; i++){
       number *= a;
    }
    return number;
} 

double result = GetNumber(2,4);
System.Console.WriteLine(result);
 */

 // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/* 
int GetNumber (int value){
  int number = 0;
  while (value > 0)
  {
    number += value % 10;
    value = value / 10;
  }
  return number;
}

int result = GetNumber(9012);
System.Console.WriteLine(result);
 */

 // Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран
/* 
 int[] GetNumber (){
    int[] numbers = new int[8];

    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(0, 100);
    }
    return numbers;
 }

System.Console.WriteLine($"[{string.Join(", ", GetNumber())}]");
 */

        