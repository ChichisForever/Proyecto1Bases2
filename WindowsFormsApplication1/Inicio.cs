﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void oracle_Click(object sender, EventArgs e)
        {
            oracleLog frm = new oracleLog();
            frm.Show();
            this.Hide();

        }
        private void sqlserver_Click(object sender, EventArgs e)
        {
            mssLog frm = new mssLog();
            frm.Show();
            this.Hide();
        }
    }
}