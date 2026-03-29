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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void firsttask_Click(object sender, EventArgs e)
        { 
            string Result = "";

            int x = 3;//4 магинитик

            //Последний 6 магнитик
            while (x > 0)
            {
               // 3 МАГНИТИк
                if (x > 2)
                {
                    Result = Result + "a";
                }

                //2 магнитик 
                if (x == 2)
                {
                    Result = Result + "b c";
                }

                //5 магнит
                x = x - 1;
                Result = Result + "-";

                //1 магинти
                if (x == 1)
                {
                    Result = Result + "d";
                    x = x - 1;
                }
            }

            MessageBox.Show(Result);

        }

        private void secondtask_Click(object sender, EventArgs e)
        {
            Task104 taskSw = new Task104();
            taskSw.Show();
        }

        private void thrihdtask_Click(object sender, EventArgs e)
        {
            Task105 taskSw = new Task105();
            taskSw.Show();
        }

        private void fourthtask_Click(object sender, EventArgs e)
        {
            int x = 0;
            string Poem = "";
            while (x < 4)
            {
                Poem = Poem + "a";
                if (x < 1)
                {
                    Poem = Poem + " ";
                }
                Poem = Poem + "n";
                if (x > 1)
                {
                    Poem = Poem + " oyster";
                    x = x + 2;
                }
                if (x == 1)
                {
                    Poem = Poem + "noys ";
                }
                if (x < 1)
                {
                    Poem = Poem + "oise ";
                }
                x = x + 1;
            }
            MessageBox.Show(Poem);
        }
    }
}
