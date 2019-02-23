using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SahteVeri
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        List<FakeData> blist = new List<FakeData>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Doldur();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //for (int i = 1; i <= 100; i++)
            //{

            //    FakeData o1 = new FakeData();
                


            //}



        }

        private void Doldur()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = FakeData.Karma();

            
        }

    }
}
