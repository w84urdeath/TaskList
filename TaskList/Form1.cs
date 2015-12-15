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

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void newTask_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Успех";
            //List<Task> taskList = new List<Task>(); // я знаю что оно будет создавать каждый раз новую коллекцию
            Form2 f2 = new Form2();
            f2.ShowDialog();
            
            //Task obj = new Task ();
            //taskList.Add(obj);

        }
    }
}
