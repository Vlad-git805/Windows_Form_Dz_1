using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        public int count = 0;
        public int min = 0;
        public int max = 100;
        public int avg = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            
            while (true)
            {
                avg = (max + min) / 2;

                DialogResult res = MessageBox.Show("Іs your secret number " + avg + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.No)
                {
                    count++;
                    DialogResult res2 = MessageBox.Show("Your number less than " + avg + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    count++;

                    if (res2 == DialogResult.Yes)
                        max = avg - 1;

                    else if (res2 == DialogResult.No)
                        min = avg + 1;

                    else
                        MessageBox.Show("I do not understand your command");
                }
                else if(res == DialogResult.Yes)
                {

                    DialogResult res3 = MessageBox.Show("Game over. Your secret number was: " + avg + "; Number of attempts: " + count + "; You want tp play again?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if(res3 == DialogResult.No)
                        break;
                    else if (res3 == DialogResult.Yes)
                    {
                        count = 0;
                        min = 0;
                        max = 100;
                        avg = 0;
                    }

                }
            }
        }
    }
}
