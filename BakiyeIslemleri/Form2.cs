﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakiyeIslemleri
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //private void Form2_FormClosing(object sender, FormClosingEventArgs e)
            //{
            //    Application.Exit();
            //}
            //private void Form1_FormClosing(object sender, FormClosingEventArgs e)
            //{
            //    Application.Exit();
            //}

           Form1 form1 = new Form1();
            form1.Show(); //form1 göster deriz.
            this.Hide(); //form2 gizle anlamındadır.
            
        }
    }
}
