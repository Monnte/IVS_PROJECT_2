using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IVS_Calculator
{
    public partial class Colours : Form
    {
        public Colours()
        {
            InitializeComponent();
            this.dialog_memory_mc = new System.Windows.Forms.ColorDialog();
            this.dialog_memory_mr = new System.Windows.Forms.ColorDialog();
            this.dialog_memory_plus = new System.Windows.Forms.ColorDialog();
            this.dialog_memory_minus = new System.Windows.Forms.ColorDialog();
            this.dialog_oper_percent = new System.Windows.Forms.ColorDialog();
            this.dialog_oper_ce = new System.Windows.Forms.ColorDialog();

            this.dialog_oper_del = new System.Windows.Forms.ColorDialog();
            this.dialog_oper_factorial = new System.Windows.Forms.ColorDialog();
            this.dialog_oper_power = new System.Windows.Forms.ColorDialog();
            this.dialog_oper_root = new System.Windows.Forms.ColorDialog();
            this.dialog_oper_abs = new System.Windows.Forms.ColorDialog();
            this.dialog_oper_fraction = new System.Windows.Forms.ColorDialog();

            this.dialog_oper_power2 = new System.Windows.Forms.ColorDialog();
            this.dialog_oper_root2 = new System.Windows.Forms.ColorDialog();
            this.dialog_oper_division = new System.Windows.Forms.ColorDialog();
            this.dialog_oper_multiply = new System.Windows.Forms.ColorDialog();
            this.dialog_oper_minus = new System.Windows.Forms.ColorDialog();
            this.dialog_oper_plus = new System.Windows.Forms.ColorDialog();

            this.dialog_oper_equal = new System.Windows.Forms.ColorDialog();
            this.dialog_oper_dot = new System.Windows.Forms.ColorDialog();
            this.dialog_oper_change = new System.Windows.Forms.ColorDialog();

            this.dialog_num_0 = new System.Windows.Forms.ColorDialog();
            this.dialog_num_1 = new System.Windows.Forms.ColorDialog();
            this.dialog_num_2 = new System.Windows.Forms.ColorDialog();
            this.dialog_num_3 = new System.Windows.Forms.ColorDialog();
            this.dialog_num_4 = new System.Windows.Forms.ColorDialog();
            this.dialog_num_5 = new System.Windows.Forms.ColorDialog();
            this.dialog_num_6 = new System.Windows.Forms.ColorDialog();
            this.dialog_num_7 = new System.Windows.Forms.ColorDialog();
            this.dialog_num_8 = new System.Windows.Forms.ColorDialog();
            this.dialog_num_9 = new System.Windows.Forms.ColorDialog();

            this.background_color = new System.Windows.Forms.ColorDialog();


        }

        private void button_memory_mc_Click(object sender, EventArgs e)
        {
            this.dialog_memory_mc.ShowDialog();
        }

        private void button_memory_mr_Click(object sender, EventArgs e)
        {
            this.dialog_memory_mr.ShowDialog();
        }

        private void button_memory_plus_Click(object sender, EventArgs e)
        {
            this.dialog_memory_plus.ShowDialog();
        }

        private void button_memory_minus_Click(object sender, EventArgs e)
        {
            this.dialog_memory_minus.ShowDialog();
        }

        private void button_memory_ms_Click(object sender, EventArgs e)
        {
            this.dialog_memory_ms.ShowDialog();
        }

        private void button_oper_factorial_Click(object sender, EventArgs e)
        {
            this.dialog_oper_factorial.ShowDialog();
        }

        private void button_oper_power_Click(object sender, EventArgs e)
        {
            this.dialog_oper_power.ShowDialog();
        }

        private void button_oper_root_Click(object sender, EventArgs e)
        {
            this.dialog_oper_root.ShowDialog();
        }

        private void button_oper_abs_Click(object sender, EventArgs e)
        {
            this.dialog_oper_abs.ShowDialog();
        }

        private void button_oper_fraction_Click(object sender, EventArgs e)
        {
            this.dialog_oper_fraction.ShowDialog();
        }

        private void button_oper_power2_Click(object sender, EventArgs e)
        {
            this.dialog_oper_power2.ShowDialog();
        }

        private void button_oper_root2_Click(object sender, EventArgs e)
        {
            this.dialog_oper_root2.ShowDialog();
        }

        private void button_oper_division_Click(object sender, EventArgs e)
        {
            this.dialog_oper_division.ShowDialog();
        }

        private void button_num_7_Click(object sender, EventArgs e)
        {
            this.dialog_num_7.ShowDialog();
        }

        private void button_num_8_Click(object sender, EventArgs e)
        {
            this.dialog_num_8.ShowDialog();
        }

        private void button_num_9_Click(object sender, EventArgs e)
        {
            this.dialog_num_9.ShowDialog();
        }

        private void button_num_4_Click(object sender, EventArgs e)
        {
            this.dialog_num_4.ShowDialog();
        }

        private void button_num_5_Click(object sender, EventArgs e)
        {
            this.dialog_num_5.ShowDialog();
        }

        private void button_num_6_Click(object sender, EventArgs e)
        {
            this.dialog_num_6.ShowDialog();
        }

        private void button_num_1_Click(object sender, EventArgs e)
        {
            this.dialog_num_1.ShowDialog();
        }

        private void button_num_2_Click(object sender, EventArgs e)
        {
            this.dialog_num_2.ShowDialog();
        }

        private void button_num_3_Click(object sender, EventArgs e)
        {
            this.dialog_num_3.ShowDialog();
        }

        private void button_num_0_Click(object sender, EventArgs e)
        {
            this.dialog_num_0.ShowDialog();
        }

        private void button_oper_multiply_Click(object sender, EventArgs e)
        {
            this.dialog_oper_multiply.ShowDialog();
        }

        private void button_oper_minus_Click(object sender, EventArgs e)
        {
            this.dialog_oper_minus.ShowDialog();
        }

        private void button_oper_plus_Click(object sender, EventArgs e)
        {
            this.dialog_oper_plus.ShowDialog();
        }

        private void button_oper_change_Click(object sender, EventArgs e)
        {
            this.dialog_oper_change.ShowDialog();
        }

        private void button_oper_dot_Click(object sender, EventArgs e)
        {
            this.dialog_oper_dot.ShowDialog();
        }

        private void button_oper_equal_Click(object sender, EventArgs e)
        {
            this.dialog_oper_equal.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.background_color.ShowDialog();
        }
    }
}
