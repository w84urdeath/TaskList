using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskList
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void yes_button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null) yes_button.Text = "Пусто(";

            else
            {
                Task task = new Task(textBox1.Text);
               
            }
        }
        private void labelF2_Click(object sender, EventArgs a)
        {
            
        }

    }
}
