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


        private void button1_Click(object sender, EventArgs e)
        {
            //click checkBox -> checkBox -> button -> button -> checkBox -> checkBox
            // Массив с порядком действий
            string[] sequence = { "check", "check", "button", "button", "check", "check" };


            for (int i = 0; i < sequence.Length; i++)
            {
                string currentStep = sequence[i];

                // Имитация логики для каждого шага о
                if (currentStep == "check")
                {
                    if (checkBox1.Checked)
                    {
                        // Если чекбокс нажат, меняем цвет лейбла
                        label1.BackColor = (label1.BackColor == Color.Blue) ? Color.Red : Color.Blue;
                        Console.WriteLine($"Шаг {i + 1}: Чекбокс сработал");
                    }
                    else
                    {
                        MessageBox.Show("The box is not checked");
                        break; // Прерываем цикл, если условие не выполнено
                    }
                }
                else if (currentStep == "button")
                {
                    // Логика для кнопки (например, просто смена цвета)
                    label1.BackColor = (label1.BackColor == Color.Blue) ? Color.Red : Color.Blue;
                    Console.WriteLine($"Шаг {i + 1}: Кнопка сработала");
                }
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
}

