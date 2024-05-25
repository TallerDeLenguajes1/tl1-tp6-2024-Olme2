// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
using System.Reflection.Emit;
Console.WriteLine("Ingrese un numero mayor o igual a 0");
float num;
do{
    num=float.Parse(Console.ReadLine());
}while(num<0);
Console.WriteLine("Valor absoluto: "+Math.Abs(num));
Console.WriteLine("Cuadrado: "+Math.Pow(num,2));
Console.WriteLine("Raiz Cuadrada: "+Math.Sqrt(num));
Console.WriteLine("Seno: "+Math.Sin(num));
Console.WriteLine("Coseno: "+Math.Cos(num));
Console.WriteLine("Parte entera de un float: "+Math.Truncate(num));
Console.WriteLine("Ingrese dos numeros: ");
float num1=float.Parse(Console.ReadLine());
float num2=float.Parse(Console.ReadLine());
Console.WriteLine("Maximo numero: "+Math.Max(num1,num2));
Console.WriteLine("Minimo numero: "+Math.Min(num1,num2));