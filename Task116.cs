using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDK06._03
{
    public partial class Task116 : Form
    {
        public Task116()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int len = Talker.BlahBlahBlah(
                textBox1.Text,
                (int)numericUpDown1.Value);

            MessageBox.Show("The message length is " + len);
        
    }

        private void button2_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;

            if (string.IsNullOrEmpty(input))
            {
                input = "123456789"; // Дефолтное значение для теста
            }

            StringBuilder pyramid = new StringBuilder();
            string currentWord = input;

            // Цикл работает, пока длина строки позволяет отрезать символы
            while (currentWord.Length > 0)
            {
                // 1. Вычисляем пробелы для центрирования относительно исходного слова
                int totalSpacesNeeded = input.Length - currentWord.Length;
                int spacesLeft = totalSpacesNeeded / 2;

                // Вместо обычного пробела ' ' используем Юникод-пробел '\u2003'
                string paddedLine = new string('\u2007', spacesLeft) + currentWord;

                pyramid.AppendLine(paddedLine);

                // 2. Если остался 1 или 2 символа, после удаления ничего не останется
                if (currentWord.Length <= 2)
                {
                    break;
                }

                // 3. Отсекаем первый и последний символ для следующего уровня
                currentWord = currentWord.Substring(1, currentWord.Length - 2);
            }

            // Вывод в MessageBox с использованием системного моноширинного шрифта
            MessageBox.Show(
                pyramid.ToString()
                

            );





        }

    }

}


















