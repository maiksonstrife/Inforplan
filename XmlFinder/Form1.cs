﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XmlFinder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            homePage1.BringToFront();
        }
        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            page11.BringToFront();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            page21.BringToFront();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            page41.BringToFront();
        }

        private void bunifuCards2_Paint(object sender, PaintEventArgs e)
        {


        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            homePage1.BringToFront();
        }

        private void homePage1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click_1(object sender, EventArgs e)
        {
            page31.BringToFront();
        }

        private void bunifuFlatButton4_Click_1(object sender, EventArgs e)
        {
            page41.BringToFront();
        }

        private void page41_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            pagePdfReader2.BringToFront();
        }

        private void pagePdfReader2_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            pageBarcodeReader1.BringToFront();
        }

        private void pageBarcodeReader1_Load(object sender, EventArgs e)
        {

        }
    }
}
