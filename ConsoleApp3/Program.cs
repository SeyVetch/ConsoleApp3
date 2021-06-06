using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

/// <summary>
/// 1ИСП11-17 Маханов А.А.
/// </summary>

namespace ConsoleApp2
{
    class Program
    {
        static public void prog1()
        {
            //listing
        }
        static public void prog2()
        {
            //программа 2
            Console.WriteLine("Напишите число");
            int n = Int32.Parse(Console.ReadLine());
            if (n >= 1)
            {
                int[] x = new int[n];
                for (int i = 0; i < n; i++)
                {
                    x[i] = i * 5 + 2;
                    Console.Write(x[i] + " ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Ошибка при вводе числа");
            }

        }
        static public void prog3()
        {
            //программа 3
            Console.WriteLine("Напишите число");
            int[] x = new int[11];
            for (int i = 0; i < 12; i++)
            {
                x[i] = Convert.ToInt32(Math.Pow(2, i));
            }
            for (int i = 0; i < 12; i++)
            {
                Console.Write(x[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < 12; i++)
            {
                Console.Write(x[10 - i] + " ");
            }
            Console.WriteLine();
        }
        static public void prog4()
        {
            //программа 4
            char[] s = new char[10];
            for (int i = 0; i <= 10; i += 1)
            {
                s[i] = (char) (97 + i * 2);
            }
            for (int i = 0; i < 10; i++)
            {
                Console.Write(s[i] + " ");
            }
            Console.WriteLine();
        }
        static public void prog5()
        {
            //программа 5
            char[] s = new char[10];
            int x = 0;
            char c = 'A';
            bool isVowel = true;
            for (int i = 0; i <= 10; i += 1)
            {
                while (isVowel)
                {
                    c = (char)('A' + x);
                    isVowel = "AEIOU".IndexOf(c) >= 0;
                }
                s[i] = c;
            }
            for (int i = 0; i < 10; i++)
            {
                Console.Write(s[i] + " ");
            }
            Console.WriteLine();
        }
        static public void prog6()
        {
            //программа 6
            Console.WriteLine("Напишите число");
            int n = Int32.Parse(Console.ReadLine());
            if (n >= 1)
            {
                int a = int.MaxValue, b = -1;
                int[] x = new int[n];
                Random rnd = new Random();
                for (int i = 0; i < n; i++)
                {
                    x[i] = rnd.Next();
                    Console.Write(x[i] + " ");
                    if (x[i] < a)
                    {
                        b = i;
                        x[i] = a;
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Число мин: " + a + ", номер числа: " + b);
            }
            else
            {
                Console.WriteLine("Ошибка при вводе числа");
            }
        }
        static public void prog7()
        {
            //программа 7
            Console.WriteLine("Напишите число");
            int n = Int32.Parse(Console.ReadLine());
            if (n >= 1)
            {
                int[] x = new int[n];
                Random rnd = new Random();
                for (int i = 0; i < n; i++)
                {
                    x[i] = rnd.Next();
                    Console.Write(x[i] + " ");
                }
                Console.WriteLine();
                bool flag = true;
                while (flag)
                {
                    flag = false;
                    for (int i = 0; i < n - 1; i++)
                    {
                        if (x[i] < x[i + 1])
                        {
                            flag = true;
                            int temp = x[i];
                            x[i] = x[i + 1];
                            x[i + 1] = temp;
                        }
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    Console.Write(x[i] + " ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Ошибка при вводе числа");
            }
        }
        static public void prog8()
        {
            //программа 8
            char[] s = new char[10];
            for (int i = 0; i <= 10; i += 1)
            {
                s[i] = (char)('A' + i);
            }
            char[] c = new char[10];
            s.CopyTo(c, 0);
            for (int i = 0; i <= 10; i += 1)
            {
                s[i] = c[9 - i];
            }
            for (int i = 0; i < 10; i++)
            {
                Console.Write(s[i] + " ");
            }
            Console.WriteLine();
        }
        static public void prog9()
        {
            //программа 9
            Random rnd = new Random();
            int[,] x = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    x[i, j] = rnd.Next();
                    Console.Write(x[i, j] + " ");
                }
                Console.WriteLine();
            }
            int[,] y = new int[10, 10];
            x.CopyTo(x, 0);
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    x[i, j] = y[j, i];
                    Console.Write(x[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static public void prog10()
        {
            //программа 10
            Random rnd = new Random();
            int[,] x = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    x[i, j] = rnd.Next();
                    Console.Write(x[i, j] + " ");
                }
                Console.WriteLine();
            }
            int[,] y = new int[9, 9];
            int a = rnd.Next(0, 9);
            int b = rnd.Next(0, 9);
            int c = 0;
            for (int i = 0; i < 10; i++)
            {
                if (i != a)
                {
                    int d = 0;
                    for (int j = 0; j < 10; j++)
                    {
                        if (j != b)
                        {
                            x[c, d] = rnd.Next();
                            d++;
                        }
                        Console.Write(x[i, j] + " ");
                    }
                    c++;
                    Console.WriteLine();
                }
            }
        }
        static int[] dir(int cx, int cy, int dx, int dy, int[,] ma)
        {
            int[] directions = new int[2];
            directions[0] = dx;
            directions[1] = dy;
            bool flagborderxpos = cx == 8;
            if (!flagborderxpos)
            {
                Console.WriteLine(cx+cy+" ");
                flagborderxpos = ma[cx + 1, cy] == 1;
            }
            bool flagborderypos = cy == 8;
            if (!flagborderypos)
            {
                flagborderypos = ma[cx, cy + 1] == 1;
            }
            bool flagborderxneg = cx == 0;
            if (!flagborderxneg)
            {
                flagborderxneg = ma[cx - 1, cy] == 1;
            }
            bool flagborderyneg = cy == 0;
            if (!flagborderyneg)
            {
                flagborderyneg = ma[cx, cy - 1] == 1;
            }
            bool up = dx == 0 && dy == 1;
            bool down = dx == 0 && dy == -1;
            bool right = dx == 1 && dy == 0;
            bool left = dx == -1 && dy == 0;
            if (flagborderxpos && right)
            {
                directions[0] = 0;
                directions[1] = 1;
            }
            if (flagborderyneg && down)
            {
                directions[0] = -1;
                directions[1] = 0;
            }
            if (flagborderxneg && left)
            {
                directions[0] = 0;
                directions[1] = -1;
            }
            if (flagborderypos && up)
            {
                directions[0] = 1;
                directions[1] = 0;
            }
            return directions;
        }
        static public void prog11()
        {
            //программа 11
            //недоработал :(
            int[,] a = new int[9, 9];
            int[,] b = new int[9, 9];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    a[i, j] = 0;
                }
            }
            int dirx = 1;
            int diry = 0;
            int x = 0;
            int y = 0;
            int n = 0;
            while (true)
            {
                a[x, y] = 1;
                b[x, y] = n;
                x += dirx;
                y += diry;
                int[] d = dir(x, y, dirx, diry, a);
                dirx = d[0];
                diry = d[1];
                if (x == 4 && y == 4 || n == 80)
                {
                    break;
                }
                n++;
            }
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(b[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            string num = Interaction.InputBox("Какую программу открыть?", "Программа");
            //выбор программы 1-11
            switch (num)
            {
                case "1":
                    prog1();
                    break;
                case "2":
                    prog2();
                    break;
                case "3":
                    prog3();
                    break;
                case "4":
                    prog4();
                    break;
                case "5":
                    prog5();
                    break;
                case "6":
                    prog6();
                    break;
                case "7":
                    prog7();
                    break;
                case "8":
                    prog8();
                    break;
                case "9":
                    prog9();
                    break;
                case "10":
                    prog10();
                    break;
                case "11":
                    prog11();
                    break;
                default:
                    MessageBox.Show("Неверный номер");
                    break;
            }
            Console.ReadLine();
        }
    }
}