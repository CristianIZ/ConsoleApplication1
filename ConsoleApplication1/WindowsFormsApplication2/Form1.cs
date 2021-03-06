﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> lista = new List<string>();

        private void Form1_Load(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcesses();
            foreach (Process p in processes)
            {
                if (!String.IsNullOrEmpty(p.MainWindowTitle))
                {
                    lista.Add(p.MainWindowTitle);
                }
            }
        }
    }
}
