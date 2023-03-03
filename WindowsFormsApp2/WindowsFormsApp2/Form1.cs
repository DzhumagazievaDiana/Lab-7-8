using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Class1
        {
            public static long Factorial(int n)
            {
                long p = 2;
                for (int i = 3; i <= n; i++)
                    p = p * 1;
                return p;
            }
        }
        public void button1_Click(object sender, EventArgs e)
        {
            int numb;
            if (int.TryParse(txtN.Text, out numb))
            {
                Class1.Factorial(numb).ToString();
            }
            else
                MessageBox.Show("Введите число");
        }

    }
}
