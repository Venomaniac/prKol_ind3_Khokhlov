using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace prKol_ind3_v2_Khokhlov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ArrayList complexNumbers = new ArrayList();
                Console.WriteLine("Кол-во комплексных чисел");
                int kol = int.Parse(Console.ReadLine());
                if (kol % 2 != 0)
                {
                    Console.WriteLine("Количество чисел должно быть четным!");
                    return;
                }
                else if (kol <= 0)
                {
                    Console.WriteLine("Количество чисел не должно быть меньше либо равно нулю!");
                }
                else
                {
                    for (int i = 0; i < kol; i++)
                    {
                        Console.WriteLine("Действительная часть:");
                        int a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Мнимая часть:");
                        int b = int.Parse(Console.ReadLine());
                        CNumbers num = new CNumbers(a, b);
                        complexNumbers.Add(num);
                    }
                }
                Console.WriteLine("Выберите операцию над комплексными числами:\n1 - Сложение;\n2 - Вычитание;\n3 - Умножение;\n0 - Выход.");
                int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.WriteLine("Сложение:");
                        for (int i = 0; i < complexNumbers.Count; i += 2)
                        {
                            CNumbers num1 = (CNumbers)complexNumbers[i];
                            CNumbers num2 = (CNumbers)complexNumbers[i + 1];
                            CNumbers sum = num1.Add(num2);
                            Console.WriteLine($"{num1} + {num2} = {sum}");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Вычитание:");
                        for (int i = 0; i < complexNumbers.Count; i += 2)
                        {
                            CNumbers num1 = (CNumbers)complexNumbers[i];
                            CNumbers num2 = (CNumbers)complexNumbers[i + 1];
                            CNumbers diff = num1.Substract(num2);
                            Console.WriteLine($"{num1} - {num2} = {diff}");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Умножение");
                        for (int i = 0; i < complexNumbers.Count; i += 2)
                        {
                            CNumbers num1 = (CNumbers)complexNumbers[i];
                            CNumbers num2 = (CNumbers)complexNumbers[i + 1];
                            CNumbers umn = num1.Multiply(num2);
                            Console.WriteLine($"{num1} * {num2} = {umn}");
                        }
                        break;
                    case 0:
                        return;

                }
            }
            catch 
            {
                Console.WriteLine("Неверный формат записи!");
            }

        }
    }
}
