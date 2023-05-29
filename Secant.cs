using MathNet.Symbolics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Z.Expressions;

namespace Numerics_Project
{
    public partial class Secant : Form
    {
        double Xold = 0;
        double xi = 0;
        double error = 0;
        int counter = 0;
        double xnew = 0;

        public Secant()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private double f(double x)
        {
            string equationString = txt_fx.Text;
            SymbolicExpression equation = SymbolicExpression.Parse(equationString);
            Dictionary<string, FloatingPoint> variables = new Dictionary<string, FloatingPoint> { { "x", x } };
            double result = equation.Evaluate(variables).RealValue;
            return result;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_error.Text = "";
            txt_Ferror.Text = "";
            txt_fx.Text = "";
            txt_root.Text = "";
            txt_x0.Text = "";
            txt_xold.Text = "";
            dataGridView1.Rows.Clear();
        }

        private void btn_sum_Click(object sender, EventArgs e)
        {
            double xol = Convert.ToDouble(txt_xold.Text);
            double x0 = Convert.ToDouble(txt_x0.Text);
            Secan(xol , x0);
        }

        void Secan (double xol , double x0 )
        {
           
            if (counter == 0)
            {
                Xold = xol;
                xi = x0;
                dataGridView1.Rows.Add(counter.ToString(), Xold.ToString(), Math.Round(f(Xold),4).ToString() , xi.ToString() , Math.Round(f(xi),4).ToString() , "---" );
                counter++; Secan(Xold , xi );
            }
            else
            {
                Xold = xol;
                xi = x0;
                xnew =  xi - ((f(xi) * (Xold - xi)) / (f(Xold) - f(xi)));
                error = Math.Abs((xnew - xi) / xnew) * 100;

                dataGridView1.Rows.Add(counter.ToString(),Math.Round(xi,4).ToString(), Math.Round(f(xi),4).ToString(), Math.Round(xnew, 4).ToString(), Math.Round(f(xnew),4).ToString(), Math.Round(error, 4).ToString());
                counter++;
                double Err = Convert.ToDouble(txt_error.Text);
                if (error > Err)
                    Secan(xi , xnew);
            }
            txt_root.Text = Math.Round(xnew,4).ToString();
            txt_Ferror.Text = Math.Round(error,4).ToString();
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

        private void label4_Click(object sender, EventArgs e)
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

        private void txt_xold_TextChanged(object sender, EventArgs e)
        {

        }
        private void enterxu_focus(object sender, EventArgs e)
        {
            if (txt_xold.Text == "Enter the X(i-1) value")
                txt_xold.Text = "";

        }

        private void enter_notxu_focus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_xold.Text))
                txt_xold.Text = "Enter the X(i-1) value";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_x0_TextChanged(object sender, EventArgs e)
        {

        }
        private void enterx0_focus(object sender, EventArgs e)
        {
            if (txt_x0.Text == "Enter the x0 value")
                txt_x0.Text = "";

        }
        private void enter_notx0_focus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_x0.Text))
                txt_x0.Text = "Enter the x0 value";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }
    }
}
