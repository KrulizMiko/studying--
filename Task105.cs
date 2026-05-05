using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDK06._03
{
    public partial class Task105 : Form
    {
        public Task105()
        {
            InitializeComponent();
        }

        bool isRunning = false;


        private int GetDelay()
        {
            // 0 speed 
            if (checkBox1.Checked)
                return 100; //100ms = 10 милисекунд = 0.1 секунда

            // 1 / 2 speed
            if (comboBox1.SelectedItem != null)
            {
                if (comboBox1.SelectedItem.ToString() == "1st speed")
                    return 50;//50ms =  50 милисекунд = 0.05

                if (comboBox1.SelectedItem.ToString() == "2nd speed")
                    return 10;//10ms =  10 милисекунд = 0.01
            }

            // 3 speed 
            if (radioButton1.Checked)
                return 0; //0ms - без задержкит = 0 секунд

            return 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            isRunning = true;

            while (isRunning)
            {     
                for (int c = 0; c < 254 && isRunning; c++)
                {
                    this.BackColor = Color.FromArgb(c, 255 - c, c);
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(GetDelay());
                }

                for (int c = 254; c >= 0 && isRunning; c--)
                {
                    this.BackColor = Color.FromArgb(c, 255 - c, c);
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(GetDelay());
                }

                Application.DoEvents(); 
            }
        }


       

        private void button2_Click(object sender, EventArgs e)
        {

            isRunning = false;

            // сброс элементов
            checkBox1.Checked = false;
            radioButton1.Checked = false;
            comboBox1.SelectedIndex = -1;

            // вернуть стандартный цвет
            this.BackColor = SystemColors.Control;
        }
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                checkBox1.Checked = false;
                radioButton1.Checked = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
              if (checkBox1.Checked)
              {
                  comboBox1.SelectedIndex = -1;
                  radioButton1.Checked = false;
              }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                checkBox1.Checked = false;
                comboBox1.SelectedIndex = -1;
            }
        }
    }
}
