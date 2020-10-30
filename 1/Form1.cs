//Бороненкова Дария ИСП-31
//Практическая работа №1
//Разработка и оформление алгоритма циклической структуры
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib_7;

namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Кнопка "Выход"
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Кнопка "Справка"
        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Практическая работа №1. Бороненкова Дария, гр.ИСП - 31\r\n" +
                "Задание: Найти сумму n целых, случайных чисел (ДСЧ), распределенных в диапазоне от 0 до n и меньше n/2. \n" +
                " Вывести на экран на одной строке сгенерированные числа, на другой строке результат.  ", "О программе");
        }
        //Кнопка "Очистить"
        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
        //Кнопка "Рассчитать"
        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            //Проверка введенных данных
            if(Int32.TryParse(textBox1.Text, out int n))
            {
                int sum = Class1.Sum(n, textBox2);//Использование функции
                textBox3.Text = sum.ToString();//Вывод ответа на форму
            }
            else MessageBox.Show("Введите число", "Ошибка");
        }
    }
}


