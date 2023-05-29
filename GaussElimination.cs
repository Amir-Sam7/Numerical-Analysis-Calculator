using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Numerics_Project
{
    public partial class GaussElimination : Form
    {
        double m21 = 0, m31 = 0, m32 = 0;
        double x1 = 0, x2 = 0, x3 = 0;
        public GaussElimination()
        {
            InitializeComponent();
        }

        private void GaussElimination_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void m21box_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txt_r12_Click(object sender, EventArgs e)
        {

        }

        private void txt_r22_Click(object sender, EventArgs e)
        {

        }

        private void txt_00_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_01_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_02_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_03_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_10_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_11_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_12_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_13_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_23_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_22_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_21_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_20_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void m31box_Click(object sender, EventArgs e)
        {

        }

        private void txt_m21_Click(object sender, EventArgs e)
        {

        }

        private void txt_m31_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void m21box_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_r03_Click(object sender, EventArgs e)
        {

        }

        private void txt_r13_Click(object sender, EventArgs e)
        {

        }

        private void txt_r02_Click(object sender, EventArgs e)
        {

        }

        private void txt_r23_Click(object sender, EventArgs e)
        {

        }

        private void txt_r01_Click(object sender, EventArgs e)
        {

        }

        private void txt_r11_Click(object sender, EventArgs e)
        {

        }

        private void txt_r00_Click(object sender, EventArgs e)
        {

        }

        private void txt_r21_Click(object sender, EventArgs e)
        {

        }

        private void txt_r10_Click(object sender, EventArgs e)
        {

        }

        private void txt_x2_Click(object sender, EventArgs e)
        {

        }

        private void txt_r20_Click(object sender, EventArgs e)
        {

        }

        private void txt_x3_Click(object sender, EventArgs e)
        {

        }

        private void fun3_Click(object sender, EventArgs e)
        {

        }

        private void fun2_Click(object sender, EventArgs e)
        {

        }

        private void txt_x1_Click(object sender, EventArgs e)
        {

        }

        private void fun1_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void m31res_Click(object sender, EventArgs e)
        {

        }

        private void m32res_Click(object sender, EventArgs e)
        {

        }

        private void m33res_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void m34res_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void m31rule_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void a14box_Click(object sender, EventArgs e)
        {

        }

        private void a24box_Click(object sender, EventArgs e)
        {

        }

        private void a34box_Click(object sender, EventArgs e)
        {

        }

        private void a13box_Click(object sender, EventArgs e)
        {

        }

        private void a23box_Click(object sender, EventArgs e)
        {

        }

        private void a33box_Click(object sender, EventArgs e)
        {

        }

        private void a12box_Click(object sender, EventArgs e)
        {

        }

        private void a22box_Click(object sender, EventArgs e)
        {

        }

        private void a32box_Click(object sender, EventArgs e)
        {

        }

        private void a11box_Click(object sender, EventArgs e)
        {

        }

        private void a21box_Click(object sender, EventArgs e)
        {

        }

        private void a31box_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void a23value_Click(object sender, EventArgs e)
        {

        }

        private void a24value_Click(object sender, EventArgs e)
        {

        }

        private void a31value_Click(object sender, EventArgs e)
        {

        }

        private void a32value_Click(object sender, EventArgs e)
        {

        }

        private void a33value_Click(object sender, EventArgs e)
        {

        }

        private void a34value_Click(object sender, EventArgs e)
        {

        }

        private void a22value_Click(object sender, EventArgs e)
        {

        }

        private void a21value_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

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

        private void btn_sum_Click(object sender, EventArgs e)
        {
            double x00 = Convert.ToDouble(txt_00.Text);
            double x01 = Convert.ToDouble(txt_01.Text);
            double x02 = Convert.ToDouble(txt_02.Text);
            double x03 = Convert.ToDouble(txt_03.Text);

            double x10 = Convert.ToDouble(txt_10.Text);
            double x11 = Convert.ToDouble(txt_11.Text);
            double x12 = Convert.ToDouble(txt_12.Text);
            double x13 = Convert.ToDouble(txt_13.Text);

            double x20 = Convert.ToDouble(txt_20.Text);
            double x21 = Convert.ToDouble(txt_21.Text);
            double x22 = Convert.ToDouble(txt_22.Text);
            double x23 = Convert.ToDouble(txt_23.Text);

            m21 = x10 / x00;
            m21box.Text = "m21= a21 / a11 -> m21=" + x10.ToString() + "/" + x00.ToString();

            m31 = x20 / x00;
            m31box.Text = "m31= a31 / a11 -> m31=" + x20.ToString() + "/" + x00.ToString();

            a21value.Text = "a21 =  " + x10.ToString() + " - " + " ( " + m21 + " * " + x00.ToString() + " ) " + "   =  " + (x10 - (m21 * x00));
            a22value.Text = "a22=" + x11.ToString() + "-" + " ( " + m21 + " * " + x01.ToString() + " ) " + "   =  " + (x11 - (m21 * x01));

            a23value.Text = "a23=" + x12.ToString() + "-" + " ( " + m21 + " * " + x02.ToString() + " ) " + "   =  " + (x12 - (m21 * x02));
            a24value.Text = "a24=" + x13.ToString() + "-" + " ( " + m21 + " * " + x03.ToString() + " ) " + "   =  " + (x13 - (m21 * x03));



            a31value.Text = "a31 = " + x20.ToString() + " - " + " ( " + m31 + " * " + x00.ToString() + " ) " + "   =  " + (x20 - (m31 * x00));
            a32value.Text = "a32 = " + x21.ToString() + " - " + " ( " + m31 + " * " + x01.ToString() + " ) " + "   =  " + (x21 - (m31 * x01));

            a33value.Text = "a33 = " + x22.ToString() + " - " + " ( " + m31 + " * " + x02.ToString() + " ) " + "   =  " + (x22 - (m31 * x02));
            a34value.Text = "a34 = " + x23.ToString() + " - " + " ( " + m31 + " * " + x03.ToString() + " ) " + "   =  " + (x23 - (m31 * x03));
            x10 = x10 - (m21 * x00);
            x11 = x11 - (m21 * x01);
            x12 = x12 - (m21 * x02);
            x13 = x13 - (m21 * x03);

            x20 = x20 - (m31 * x00);
            x21 = x21 - (m31 * x01);
            x22 = x22 - (m31 * x02);
            x23 = x23 - (m31 * x03);

            a11box.Text = x00.ToString();
            a12box.Text = x01.ToString();
            a13box.Text = x02.ToString();
            a14box.Text = x03.ToString();
            a21box.Text = x10.ToString();
            a22box.Text = x11.ToString();
            a23box.Text = x12.ToString();
            a24box.Text = x13.ToString();

            a31box.Text = x20.ToString();
            a32box.Text = x21.ToString();
            a33box.Text = x22.ToString();
            a34box.Text = x23.ToString();

            m32 = x21 / x11;
            m31rule.Text = "m32= a32 / a22 -> m32=" + x21.ToString() + "/" + x11.ToString();



            m31res.Text = "a31 = " + x20.ToString() + " - " + " ( " + m32 + " * " + x10.ToString() + " ) " + "   =  " + (x20 - (m32 * x10));
            m32res.Text = "a32 = " + x21.ToString() + " - " + " ( " + m32 + " * " + x11.ToString() + " ) " + "   =  " + (x21 - (m32 * x11));

            m33res.Text = "a33 = " + x22.ToString() + " - " + " ( " + m32 + " * " + x12.ToString() + " ) " + "   =  " + (x22 - (m32 * x12));
            m34res.Text = "a34 = " + x23.ToString() + " - " + " ( " + m32 + " * " + x13.ToString() + " ) " + "   =  " + (x23 - (m32 * x13));

            x20 = x20 - (m32 * x10);
            x21 = x21 - (m32 * x11);
            x22 = x22 - (m32 * x12);
            x23 = x23 - (m32 * x13);

            txt_r00.Text = x00.ToString();
            txt_r01.Text = x01.ToString();
            txt_r02.Text = x02.ToString();
            txt_r03.Text = x03.ToString();

            txt_r10.Text = x10.ToString();
            txt_r11.Text = x11.ToString();
            txt_r12.Text = x12.ToString();
            txt_r13.Text = x13.ToString();

            txt_r20.Text = x20.ToString();
            txt_r21.Text = x21.ToString();
            txt_r22.Text = x22.ToString();
            txt_r23.Text = x23.ToString();

            x3 = x23 / x22;
            x2 = (x13 - (x12 * x3)) / x11;
            x1 = (x03 - (x01 * x2) - (x02 * x3)) / x00;

            txt_x1.Text = x1.ToString();
            txt_x2.Text = x2.ToString();
            txt_x3.Text = x3.ToString();

            txt_m21.Text = m21.ToString();
            txt_m31.Text = m31.ToString();
            txt_m32.Text = m32.ToString();

            fun1.Text = x00.ToString() + " x1 " + " + " + x01.ToString() + " x2 " + " + " + x02.ToString() + " x3 = " + x03.ToString();
            fun2.Text = x11.ToString() + " x2 " + " + " + x12.ToString() + " x3 = " + x13.ToString();
            fun3.Text = x22.ToString() + " x3 =  " + x23.ToString();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_00.Text = ""; txt_01.Text = "";
            txt_02.Text = ""; txt_03.Text = "";

            txt_10.Text = ""; txt_11.Text = "";
            txt_12.Text = ""; txt_13.Text = "";

            txt_20.Text = ""; txt_21.Text = "";
            txt_22.Text = ""; txt_23.Text = "";

            txt_x1.Text = ""; txt_x2.Text = ""; txt_x3.Text = "";
            txt_m21.Text = ""; txt_m31.Text = ""; txt_m32.Text = "";

            txt_r00.Text = ""; txt_r01.Text = "";
            txt_r02.Text = ""; txt_r03.Text = "";

            txt_r10.Text = ""; txt_r11.Text = "";
            txt_r12.Text = ""; txt_r13.Text = "";

            txt_r20.Text = ""; txt_r21.Text = "";
            txt_r22.Text = ""; txt_r23.Text = "";

        }
    }
}