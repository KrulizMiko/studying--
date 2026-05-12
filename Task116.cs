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

            // Если пусто — ставим дефолтное слово, как на скрине
            if (string.IsNullOrEmpty(input))
            {
                input = "Вагончик";
            }

            // Делаем длину нечетной для симметрии
            if (input.Length % 2 == 0 && input.Length > 0)
            {
                input = input.Substring(0, input.Length - 1);
            }

            StringBuilder pyramid = new StringBuilder();
            int maxWidth = input.Length;

            // Строим уровни пирамиды
            for (int level = 0; level < (maxWidth + 1) / 2; level++)
            {
                int numChars = maxWidth - 2 * level;
                int startIndex = level;

                // Вырезаем часть слова для текущего уровня
                string currentLevel = input.Substring(startIndex, numChars);

                // Добавляем пробелы и текст
                string spaces = new string(' ', level);
                pyramid.Append(spaces);
                pyramid.AppendLine(currentLevel);
            }

            // Вывод результата
            MessageBox.Show(pyramid.ToString(), "Результат");
        }

    }

}


















