﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taller5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnir_Click_1(object sender, EventArgs e)
        {
            int impar = 0, i = 0;
            for (i = 0; i < Convert.ToInt16(txtnumero.Text); i++)
            {
                if (i % 2 != 0)
                {
                    impar += i;

                    lbxnumeros.Items.Add(i.ToString());
                }
            }
            MessageBox.Show("la suma es: " + impar);
        }
    }
}
