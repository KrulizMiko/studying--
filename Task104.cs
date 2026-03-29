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

            if (label1.BackColor == Color.Blue && checkBox1.Checked == true)
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
