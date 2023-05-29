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
    public partial class Newton : Form
    {
        double Xnew = 0;
        double xi = 0;
        double error = 0;
        int counter = 0;
        public Newton()
        {
            InitializeComponent();
        }

        double f(double x)
        {
            string equationString = txt_fx.Text;
            // Use MathNet.Symbolics to parse the function string into a function
            var symbolExpr = SymbolicExpression.Parse(equationString);
            var lambda = symbolExpr.Compile("x");
            return lambda(x);
        }

        double fdash(double x)
        {
            string equationString = txt_fdash.Text;
            // Use MathNet.Symbolics to parse the function string into a function
            var symbolExpr = SymbolicExpression.Parse(equationString);
            var derivative = symbolExpr.Differentiate("x");
            var lambda = derivative.Compile("x");
            return lambda(x);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_sum_Click(object sender, EventArgs e)
        {
            double x0 = Convert.ToDouble(txt_x0.Text);
            Newto(x0);
        }

        void Newto(double x) 
        {
            if (counter == 0)
            {
                xi = x;
                dataGridView1.Rows.Add(counter.ToString(), Math.Round(xi,4).ToString(), Math.Round(f(xi),4).ToString() , Math.Round(fdash(xi)).ToString() , "---");
                counter++; Newto(xi);
            }
            else
            {
                xi = x;
                Xnew = xi - (f(xi) / fdash(xi));
                error = Math.Abs((Xnew - xi) / Xnew) * 100;

                dataGridView1.Rows.Add(counter.ToString(), Math.Round(Xnew,4).ToString(), Math.Round(f(Xnew),5).ToString(),Math.Round(fdash(Xnew),5).ToString(), Math.Round(error,4).ToString());
                counter++;
                double Err = Convert.ToDouble(txt_error.Text);
                if (error > Err)
                    Newto(Xnew);
            }
            txt_root.Text = Math.Round(Xnew, 4).ToString();
            txt_Ferror.Text = Math.Round(error, 4).ToString();
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

        private void txt_fdash_TextChanged(object sender, EventArgs e)
        {
            string equationString = txt_fdash.Text;
        }
        private void enterfdash_focus(object sender, EventArgs e)
        {
            if (txt_fdash.Text == "please enter the function")
                txt_fdash.Text = "";

        }
        private void enterfdash_not_focus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_fdash.Text))
                txt_fdash.Text = "please enter the function";
        }

        private void label5_Click(object sender, EventArgs e)
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

        private void txt_x0_TextChanged(object sender, EventArgs e)
        {

        }
        private void enterX0_focus(object sender, EventArgs e)
        {
            if (txt_x0.Text == "Enter the X0 value")
                txt_x0.Text = "";

        }
        private void enterX0_not_focus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_x0.Text))
                txt_x0.Text = "Enter the  X0 value";
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

        private void btn_clear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }
    }
}
