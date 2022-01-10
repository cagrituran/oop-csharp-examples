using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wek14oop
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();

            Task.Run(() =>
            {
                int t = 0;


                for (int i = 1; i <= 1000; i++)
                {
                    Thread.Sleep(10);
                    t += i;
                }

            });
            

            MessageBox.Show("Hoş geldiniz!");

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        int cnt = 10000000;
        int wait = 1;
        async Task FillOddNumbersAsync()
        {
           await Task.Run(() =>
            {
                for (int i = 1; i <= cnt; i++)
                {

                    Thread.Sleep(wait);
                    if (i % 2 != 0)
                        listBox1.Items.Add(i);

                }
            });
        }
        async Task FillEvenNumbersAsync()
        {
            await Task.Run(() =>
            {
                for (int i = 1; i <= cnt; i++)
                {
                    Thread.Sleep(wait);

                    if (i % 2 == 0)
                        listBox2.Items.Add(i);

                }
            });
        }

        async void button1_Click(object sender, EventArgs e)
        {
            await FillOddNumbersAsync();
            await FillEvenNumbersAsync();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var cnt = Process.GetCurrentProcess();

            MessageBox.Show(cnt.Threads.Count.ToString());
        }
    }
}
