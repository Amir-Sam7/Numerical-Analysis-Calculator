using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Z.Expressions;
using MathNet.Numerics;
using MathNet.Symbolics;

namespace Numerics_Project
{
    public partial class Fixed : Form
    {
        double Xnew = 0;
        double xi = 0;
        double error = 0;
        int counter = 0;

        public Fixed()
        {
            InitializeComponent();
        }
        private double f(double x)
        {
            string equationString = txt_fx.Text;
            SymbolicExpression equation = SymbolicExpression.Parse(equationString);
            Dictionary<string, FloatingPoint> variables = new Dictionary<string, FloatingPoint> { { "x", x } };
            double result = equation.Evaluate(variables).RealValue;
            return result;
        }

        private void btn_sum_Click(object sender, EventArgs e)
        {
            double x0 = Convert.ToDouble(txt_x0.Text);
            double Err = Convert.ToDouble(txt_error.Text);
            xi = x0;

            do
            {
                double xiPlus1 = f(xi);
                error = Math.Abs((xiPlus1 - xi) / xiPlus1) * 100;

                dataGridView1.Rows.Add(counter, xi, xiPlus1, error);

                xi = xiPlus1;
                counter++;
            }
            while (error > Err);

            txt_root.Text = xi.ToString();
            txt_Ferror.Text = error.ToString();

        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_error.Text = "";
            txt_Ferror.Text = "";
            txt_fx.Text = "";
            txt_root.Text = "";
            txt_x0.Text = "";
            dataGridView1.Rows.Clear();
        }

        private void txt_x0_TextChanged(object sender, EventArgs e)
        {

        }

        private void enterxu_focus(object sender, EventArgs e)
        {
            if (txt_x0.Text == "Enter the x0 value")
                txt_x0.Text = "";
        }

        private void enter_notxu_focus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_x0.Text))
                txt_x0.Text = "Enter the x0 value";
        }

        private void txt_fx_TextChanged(object sender, EventArgs e)
        {
            string equationString = txt_fx.Text;
        }

        private void enter_focus(object sender, EventArgs e)
        {
            if (txt_fx.Text == "please enter the function")
                txt_fx.Text = "";
        }

        private void enter_not_focus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_fx.Text))
                txt_fx.Text = "please enter the function";
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_error_TextChanged(object sender, EventArgs e)
        {

        }

        private void enterERROR_focus(object sender, EventArgs e)
        {
            if (txt_error.Text == "please enter the ERROR")
                txt_error.Text = "";

        }

        private void enter_notERROR_focus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_error.Text))
                txt_error.Text = "please enter the ERROR";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Fixed_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

 
        private void txt_root_TextChanged(object sender, EventArgs e)
        {

        }
    }
}