/*
Задача 2: Напишите программу,
 которая на вход принимает два числа и выдаёт, 
 какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
/*
Console.Write("Input first number: "); 
int num1=Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: "); 
int num2=Convert.ToInt32(Console.ReadLine());
if(num1>num2)
{
    Console.WriteLine("Max number is:" + num1 + "Min number is: " + num2);

}
else
{
     Console.WriteLine("Max number is:" + num2 +"  " + "Min number is: " + num1);

}
*/

/*
Задача 4: Напишите программу, 
которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

/*
Console.Write("Input first number: ");
int num1=Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: "); 
int num2=Convert.ToInt32(Console.ReadLine());
Console.Write("Input third number: ");
int num3=Convert.ToInt32(Console.ReadLine());
if(num1>num2&num1>num3)
{
    Console.WriteLine("Max is: " + num1);
}
else if(num2>num3)
{
    Console.WriteLine("Max is: " + num2);
}
else
{
    Console.WriteLine("Max is: " + num3);
}
*/

/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
 является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

/*
Console.Write("Input your number: ");
int num=Convert.ToInt32(Console.ReadLine());
if(num%2==0)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}
*/
/*
 Напишите программу, которая на вход принимает число (N),
  а на выходе показывает все чётные числа от 1 до N.
   5 -> 2, 4
   8 -> 2, 4, 6, 8
*/
/*
Console.Write("Input your number N: ");
int numN=Convert.ToInt32(Console.ReadLine());
int i=1;
if (numN>2)
{
while(i<numN)
{
    if(i%2==0)
    {
        Console.Write(i+"  ");
    }
    i++;
}
}
else
{
    Console.WriteLine("Input number greater 2");

}
*/