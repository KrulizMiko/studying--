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
    public partial class Task104 : Form
    {
        public Task104()
        {
            InitializeComponent();
        }

        private void Task104_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle; this.MaximizeBox = false;

        }


        int stepIndex = 0; // Номер текущего шага в массиве

         //click checkBox -> checkBox -> button -> button -> checkBox -> checkBox
        string[] sequence = { "check", "check", "button", "button", "check", "check" };

        private void button1_Click(object sender, EventArgs e)
        {
            CheckStep("button");
        }

        void CheckStep(string actionType)
        {
            if (stepIndex >= sequence.Length) return;

            if (sequence[stepIndex] == actionType)
            {
                // Если нажали правильно
                label1.BackColor = (label1.BackColor == Color.Blue) ? Color.Red : Color.Blue;
                stepIndex++; // Переходим к следующему шагу

                Console.WriteLine($"Правильно! Шаг {stepIndex} выполнен.");

                if (stepIndex == sequence.Length)
                {
                    MessageBox.Show("Поздравляю! Вся последовательность пройдена верно.");
                }
            }
            else
            {
                // Если нажали не то (например, кнопку вместо чекбокса)
                MessageBox.Show($"Ошибка! Ожидалось действие: {sequence[stepIndex]}. Попробуйте заново.");
                stepIndex = 0; // Сброс прогресса при ошибке
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckStep("check");
        }



        /* if (label1.BackColor == Color.Blue && checkBox1.Checked == true)
         {
             label1.BackColor = Color.Red;
         }

         else if (label1.BackColor == Color.Red && checkBox1.Checked == true)
         {
             label1.BackColor = Color.Blue;
         }

         else if (checkBox1.Checked == false)
         {
             MessageBox.Show("The box is not checked");
         }
         */

        /* if (checkBox1.Checked == true)
         {
             if (label1.BackColor == Color.Red)
             {
                 label1.BackColor = Color.Blue;
             }
             else
             {
                 label1.BackColor = Color.Red;
             }
         }
         else
         {
             MessageBox.Show("The box is not checked");
         }
        */
    }
    }


