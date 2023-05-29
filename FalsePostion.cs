using MathNet.Symbolics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Z.Expressions;
using MathNet.Numerics;

namespace Numerics_Project
{
    public partial class FalsePostion : Form
    {
        double xolder = 0;
        double xr = 0;
        double error = 0;
        int counter = 1;

        public FalsePostion()
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
            double xl = Convert.ToDouble(txt_xl.Text);
            double xu = Convert.ToDouble(txt_xu.Text);
            double Err = Convert.ToDouble(txt_error.Text);

            if (f(xl) * f(xu) < 0)
            {
                do
                {
                    xr = xu - ((f(xu) * (xl - xu)) / (f(xl) - f(xu)));
                    error = Math.Abs((xr - xolder) / xr) * 100;
                    xolder = xr;

                    dataGridView1.Rows.Add(counter.ToString(), Math.Round(xl,4).ToString(), f(xl).ToString(), Math.Round(xu, 4).ToString(), f(xu).ToString(), Math.Round(xr, 4).ToString(), f(xr).ToString(), Math.Round(error, 4).ToString());
                    counter++;

                    if (f(xl) * f(xr) < 0)
                    {
                        xu = xr;
                    }
                    else if (f(xl) * f(xr) > 0)
                    {
                        xl = xr;
                    }
                } while (error > (Err / 100) * 100);

                txt_root.Text = xr.ToString();
                txt_Ferror.Text = error.ToString();
            }
            else
                MessageBox.Show("No solution", "Warnning Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void FalsePostion_Load(object sender, EventArgs e)
        {

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

        private void txt_xl_TextChanged(object sender, EventArgs e)
        {

        }
        private void enterXL_focus(object sender, EventArgs e)
        {
            if (txt_xl.Text == "Enter the Xl value")
                txt_xl.Text = "";

        }
        private void enterXL_not_focus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_xl.Text))
                txt_xl.Text = "Enter the  Xl value";
        }

        private void txt_xu_TextChanged(object sender, EventArgs e)
        {

        }
        private void enterxu_focus(object sender, EventArgs e)
        {
            if (txt_xu.Text == "Enter the xu value")
                txt_xu.Text = "";

        }
        private void enter_notxu_focus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_xu.Text))
                txt_xu.Text = "Enter the xu value";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void txt_Ferror_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_root_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
