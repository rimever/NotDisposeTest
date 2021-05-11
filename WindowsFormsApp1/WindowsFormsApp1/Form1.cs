#region

using System;
using System.Windows.Forms;

#endregion

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1000; i++)
            {
                var f = new Form2();
                f.Show();
                f.Close();
            }
        }
    }
}