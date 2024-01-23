using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._1
{
    class Program
    {
        static void Main (string[] args)
        {
            try
            {
                //14
                /*int m = -1, n = -1;
                while ((m < 0 || n < 0 || m > 70 || n > 30))
                {
                    Console.WriteLine("Введите кол-во вагонов у поезда");
                    m = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите кол-во мест у Вагона");
                    n = Convert.ToInt32(Console.ReadLine());
                }
                int[,] mass = new int[m, n];
                int[,] answ_mass = new int[m, 1];
                Random perc = new Random();
                for (int i = 0; i < mass.GetLength(0); i++)
                {
                    int count = 0;
                    for (int j = 0; j < mass.GetLength(1); j++)
                    {
                        Console.WriteLine($"Пожалуйста скажите занято ли в {i} вагоне {j + 1} место (вам необходимо вписать да или нет)");
                        string answ = Console.ReadLine();
                        answ = answ.ToLower();
                        switch (answ)
                        {
                            case "да":
                                mass[i, j] = 1;
                                count++;
                                break;
                            case "нет":
                                mass[i, j] = 0;
                                break;
                            default:
                                Console.WriteLine("Извинити но вы не корректно ввели ответа попробуйте еще раз");
                                j--;
                                break;
                        }
                        if (j == mass.GetLength(1) - 1)
                        {
                            answ_mass[i, 0] = count;
                        }
                    }
                }
                Console.WriteLine("Введите вагон в котором вы хотите узнать кол-во свободных мест ну меровка вагонов идет с 0");
                int vag = Convert.ToInt32(Console.ReadLine());
                if (vag > m)
                {
                    Console.WriteLine("Вы ввели вагон которого не существует");
                }
                else
                {
                    for (int i = vag; i != vag + 1; i++)
                    {
                        for (int j = 0; j < answ_mass.GetLength(1); j++)
                        {
                            Console.WriteLine($"В вагоне {vag} щас свободных мест:" + answ_mass[i, j]);
                            ;
                        }
                    }
                }
                Console.ReadLine();*/

                //7
                int m = -1, n = -1;
                while ((m < 0 || n < 0 || m > 10 || n > 15))
                {
                    Console.WriteLine("Введите кол-во строк у массива");
                    m = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите кол-во столбиков у массива");
                    n = Convert.ToInt32(Console.ReadLine());
                }
                int[,] mass = new int[m, n];
                Random rn = new Random();
                int sum = 0;
                int sr = 0;
                int count_nc = 0;
                Console.WriteLine("Выберите строку  в которой мы будем искать среднее арифм. нечетных чисел");
                int answ_strok = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < mass.GetLength(0); i++)
                {
                    for(int j = 0; j < mass.GetLength(1); j++)
                    {
                        mass[i, j] = rn.Next(-30, 35);
                        Console.Write($"{mass[i, j],4}");
                        if (i == answ_strok && (mass[i, j] % 2 != 0))
                        {
                                sum +=mass[i, j];
                                count_nc++;
                                if (j == mass.GetLength(1) -1)
                                    sr = sum / count_nc;
                        }
                    }
                    Console.WriteLine();
                }
                int count = 0;
                int sum_4 = 0;
                double sr_4 = 0;
                int count_dl4 = 0;
                Console.WriteLine("Выберите столбец в котором мы будем искать числа которые больше 15");
                int answ_stolb1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Выберите стролбец в котором мы будем искать среднее арифм. чисел кратных 4");
                int answ_stolb2 = Convert.ToInt32(Console.ReadLine());
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    for(int i = 0; i < mass.GetLength(0); i++)
                    {
                        if (j == answ_stolb1 && mass[i, j] > 15)
                            count++;
                        if (j == answ_stolb2 && (mass[i, j] % 4 == 0))
                        {
                            sum_4 += mass[i, j];
                            count_dl4++;
                            if (i == mass.GetLength(0) - 1)
                                sr_4 = sum_4 / count_dl4;
                        }
                           
                    }
                }
                Console.WriteLine("Кол-во ненулевых элементов второго столбца,которые больше 15:" + count);
                Console.WriteLine("Среднее арифм. нечетных элементов пятой строки:" + sr);
                Console.WriteLine("Среднее арифм. элементов 4 столбца,кратных 4:" + sr_4);
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Извините,но при вводе данных вы не правильно их ввели ");
                Console.ReadLine();
            }

        }
    }
}
