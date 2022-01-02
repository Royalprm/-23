using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Упражнение_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Введите число: ");
            int factor = Convert.ToInt32(Console.ReadLine());

            
            FactorAsync(factor, "Задача 1");

            
            FactorAsync(factor, "Задача 2");

            
            Console.WriteLine("==> Сумма калькуляции");
            int sum = Summ(factor, "Задача 3");

            
            Console.WriteLine("\nНажмите любую кнопку");
            Console.ReadKey();
        }
        static int Factor(int n, string name)
        {
            int result = 1;
            for (int i = 1; i < n + 1; i++)
            {
                result *= i;
                Console.WriteLine($"{name} - Итерация {i}: {result / i} * {i} = {result}");
                Thread.Sleep(500);
            }
            return result;
        }
        
        static int Summ(int n, string name)
        {
            int result = 1;
            for (int i = 1; i < n + 1; i++)
            {
                result += i;
                Console.WriteLine($"{name} - Итерация {i}: {result / i} + {i} = {result}");
                Thread.Sleep(500);
            }
            Console.WriteLine($"{name} - Метод суммы: Расчет закончен...\nSum = {result} <==");
            return result;
        }
        
        static async Task<int> FactorAsync(int n, string name)
        {
            Console.WriteLine($"==> {name} - Method FactorAsync: Расчет начат...");
            int result = await Task.Run(() => Factor(n, name));
            Console.WriteLine($"{name} - Method FactorAsync: Расчет закончен \n{n}! = {result} <==");
            return result;
        }
    }
}
