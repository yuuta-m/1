using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib_7
{
    public class Class1
    {
        /*Входные параметры: 
        int n – некоторое число n
        TextBox textBox2 – форма для вывода сгенерированных чисел
        Выходные параметры:
        sum – сумма чисел*/
        public static int Sum(int n, TextBox textBox2)
        {
           //Создание объекта рандом
           Random rnd = new Random();
            int sum = 0, kol = 0;
            while (kol < n)
            {
                //Генерация числа из диапазона
                int a = rnd.Next(0, n);
                //Вывод сгенерированного числа в строку
                textBox2.Text = textBox2.Text + " " + a.ToString();
                //Суммирование чисел
                if (a < ((n / 2)))
                {
                  sum = sum +a;
                }
                kol = kol +1;
            }
            return sum;
        }
    }
}
