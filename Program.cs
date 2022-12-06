/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

/*Console.WriteLine("Please enter a natural number greater than 1");
int Number = Convert.ToInt32(Console.ReadLine());

void EnteredNumber(int Number)
{
    if (Number < 0)
    {
        Console.WriteLine($"{Number} - is not a natural number");
        return;
    }
    else if (Number == 0) return;

    else
    {
        Console.Write("{0,4}", Number);
        EnteredNumber(Number - 1);
    }
}

Console.WriteLine();
EnteredNumber(Number);*/


/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/


/*Console.Write("Please enter the number A - ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter the number B -  ");
int B = Convert.ToInt32(Console.ReadLine());

void SumNumber(int A, int B, int sum)
{
    if (A > B)
    {
        Console.WriteLine($"The sum = {sum}");
        return;
    }
    sum = sum + (A++);
    SumNumber(A, B, sum);
}

Console.WriteLine();
SumNumber(A, B, 0);*/

/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

/*int A = InputNumbers("Please enter Number A - ");
int B = InputNumbers("Please enter Number B - ");

int functionAkkerman = Ack(A, B);

Console.WriteLine($"Ackermann function = {functionAkkerman}");

int Ack(int A, int B)
{
  if (A == 0)
  {
    return B + 1;
  }
  else 
  {
    if (B == 0)
    {
        return Ack(A - 1, 1);
    }
    else 
    {
        return Ack(A - 1, Ack(A, B - 1));
    }
  }
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}*/