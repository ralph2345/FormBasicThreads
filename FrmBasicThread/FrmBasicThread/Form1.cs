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

namespace FrmBasicThread
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThreadStart delThreadObj = new ThreadStart(MyThreadClass.Thread1);

            Thread ThreadA = new Thread(delThreadObj);
            ThreadA.Name = "Thread A Process";

            Thread ThreadB = new Thread(delThreadObj);
            ThreadB.Name = "Thread B Process";
            //Starting threads
            ThreadA.Start();
            ThreadB.Start();
            //Joining two threads
            ThreadA.Join(); 
            ThreadB.Join();

            label1.Text = "-End of Thread-";
            Console.WriteLine(label1.Text);

        }
    }
}
