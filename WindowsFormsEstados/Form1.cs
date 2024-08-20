using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsEstados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label7.Text = comboBox1.Items.Count.ToString();
            label8.Text = comboBox2.Items.Count.ToString();
            label9.Text = comboBox3.Items.Count.ToString();
            label10.Text = comboBox4.Items.Count.ToString();
            label11.Text = comboBox5.Items.Count.ToString();
            label12.Text = comboBox6.Items.Count.ToString();
        }
    }
}
