using System;
using System.Windows.Forms;

namespace Numerics_Project
{
    public partial class gauss_jorden : Form
    {
        double m21 = 0, m31 = 0, m32 = 0, m12 = 0, m23 = 0, m13 = 0, h1 = 0, h2 = 0, h3 = 0;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ah33_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        double x1 = 0, x2 = 0, x3 = 0;
        public gauss_jorden()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
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
            h1 = 1 / x00;
            x00 = x00 * h1;
            x01 = x01 * h1;
            x02 = x02 * h1;
            x03 = x03 * h1;



            m21 = x10 / x00;
            m21box.Text = "m21= a21 / a11 -> m21=" + x10.ToString() + "/" + x00.ToString();

            m31 = x20 / x00;
            m31box.Text = "m31= a31 / a11 -> m31=" + x20.ToString() + "/" + x00.ToString();

            a21value.Text = "a21 =  " + x10.ToString() + " - " + " ( " + m21 + " * " + x00.ToString() + " ) " + "   =  " + (x10 - (m21 * x00));
            a22value.Text = "a22= " + x11.ToString() + " - " + "(" + m21 + " * " + x01.ToString() + " ) " + "   =  " + (x11 - (m21 * x01));

            a23value.Text = "a23= " + x12.ToString() + " - " + "(" + m21 + " * " + x02.ToString() + " ) " + "   =  " + (x12 - (m21 * x02));
            a24value.Text = "a24= " + x13.ToString() + " - " + "(" + m21 + " * " + x03.ToString() + " ) " + "   =  " + (x13 - (m21 * x03));



            a31value.Text = "a31 = " + x20.ToString() + " - " + "( " + m31 + " * " + x00.ToString() + ")" + "   =  " + (x20 - (m31 * x00));
            a32value.Text = "a32 = " + x21.ToString() + " - " + "( " + m31 + " * " + x01.ToString() + ")" + "   =  " + (x21 - (m31 * x01));

            a33value.Text = "a33 = " + x22.ToString() + " - " + "( " + m31 + " * " + x02.ToString() + ")" + "   =  " + (x22 - (m31 * x02));
            a34value.Text = "a34 = " + x23.ToString() + " - " + "( " + m31 + " * " + x03.ToString() + ")" + "   =  " + (x23 - (m31 * x03));

            //R2 - (m21) R1 --> R2
            //R3 - (m31) R1 --> R3

            x10 = (x10 - (m21 * x00));
            x11 = (x11 - (m21 * x01));
            x12 = (x12 - (m21 * x02));
            x13 = (x13 - (m21 * x03));

            x20 = (x20 - (m31 * x00));
            x21 = (x21 - (m31 * x01));
            x22 = (x22 - (m31 * x02));
            x23 = (x23 - (m31 * x03));

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



            h2 = 1 / x11;

            x10 = Math.Abs(x10 * h2);
            x11 = x11 * h2;
            x12 = x12 * h2;
            x13 = x13 * h2;

            m32 = x21 / x11;

            m31res.Text = "a31 = " + x20.ToString() + " - " + "( " + m32 + " * " + x10.ToString() + ")" + "   =  " + (x20 - (m32 * x10));
            m32res.Text = "a32 = " + x21.ToString() + " - " + "( " + m32 + " * " + x11.ToString() + ")" + "   =  " + (x21 - (m32 * x11));

            m33res.Text = "a33 = " + x22.ToString() + " - " + "( " + m32 + " * " + x12.ToString() + ")" + "   =  " + (x22 - (m32 * x12));
            m34res.Text = "a34 = " + x23.ToString() + " - " + "( " + m32 + " * " + x13.ToString() + ")" + "   =  " + (x23 - (m32 * x13));





            x20 = (x20 - (m32 * x10));
            x21 = (x21 - (m32 * x11));
            x22 = (x22 - (m32 * x12));
            x23 = (x23 - (m32 * x13));



            m12 = x01 / x11;
            h11.Text = "a11 = " + x00.ToString() + " - " + "( " + m12 + " * " + x10.ToString() + ")" + "   =  " + (x00 - (m12 * x10));
            h12.Text = "a12 = " + x01.ToString() + " - " + "( " + m12 + " * " + x11.ToString() + ")" + "   =  " + (x01 - (m12 * x11));

            h13.Text = "a13 = " + x02.ToString() + " - " + "( " + m12 + " * " + x12.ToString() + ")" + "   =  " + (x02 - (m12 * x12));
            h14.Text = "a14 = " + x03.ToString() + " - " + "( " + m12 + " * " + x13.ToString() + ")" + "   =  " + (x03 - (m12 * x13));


            m31rule.Text = "m32= a32 / a22 -> m32=" + x21.ToString() + "/" + x11.ToString();

            x00 = (x00 - (m12 * x10));
            x01 = (x01 - (m12 * x11));
            x02 = (x02 - (m12 * x12));
            x03 = (x03 - (m12 * x13));






            ah11.Text = x00.ToString();
            ah12.Text = x01.ToString();
            ah13.Text = x02.ToString();
            ah14.Text = x03.ToString();

            ah21.Text = x10.ToString();
            ah22.Text = x11.ToString();
            ah23.Text = x12.ToString();
            ah24.Text = x13.ToString();

            ah31.Text = x20.ToString();
            ah32.Text = x21.ToString();
            ah33.Text = x22.ToString();
            ah34.Text = x23.ToString();

            //R3 - (m32) R2 --> R3

            //R2 - (m23) R3 --> R2
            //R1 - (m13) R3 --> R1
            //R1 - (m12) R2 --> R1

            h3 = 1 / x22;
            x20 = Math.Abs(x20 * h3);
            x21 = Math.Abs(x21 * h3);
            x22 = x22 * h3;
            x23 = x23 * h3;



            m13 = x02 / x22;
            l11.Text = "a11 = " + x00.ToString() + " - " + "( " + m13 + " * " + x20.ToString() + ")" + "   =  " + (x00 - (m13 * x20));
            l12.Text = "a12 = " + x01.ToString() + " - " + "( " + m13 + " * " + x21.ToString() + ")" + "   =  " + (x01 - (m13 * x21));

            l13.Text = "a13 = " + x02.ToString() + " - " + "( " + m13 + " * " + x22.ToString() + ")" + "   =  " + (x02 - (m13 * x22));
            l14.Text = "a14 = " + x03.ToString() + " - " + "( " + m13 + " * " + x23.ToString() + ")" + "   =  " + (x03 - (m13 * x23));
            x00 = (x00 - (m13 * x20));
            x01 = (x01 - (m13 * x21));
            x02 = (x02 - (m13 * x22));
            x03 = (x03 - (m13 * x23));



            m23 = x12 / x22;

            l21.Text = "a21 = " + x10.ToString() + " - " + "( " + m23 + " * " + x20.ToString() + ")" + "   =  " + (x10 - (m23 * x20));
            l22.Text = "a22 = " + x11.ToString() + " - " + "( " + m23 + " * " + x21.ToString() + ")" + "   =  " + (x11 - (m23 * x21));

            l23.Text = "a23 = " + x12.ToString() + " - " + "( " + m23 + " * " + x22.ToString() + ")" + "   =  " + (x12 - (m23 * x22));
            l24.Text = "a24 = " + x13.ToString() + " - " + "( " + m23 + " * " + x23.ToString() + ")" + "   =  " + (x13 - (m23 * x23));
            x10 = (x10 - (m23 * x20));
            x11 = (x11 - (m23 * x21));
            x12 = (x12 - (m23 * x22));
            x13 = (x13 - (m23 * x23));



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

            fun1.Text = x00.ToString() + " x1 " + x01.ToString() + " = " + x03.ToString();
            fun2.Text = x11.ToString() + " x2 " + x12.ToString() + "  = " + x13.ToString();
            fun3.Text = x22.ToString() + " x3 =  " + x23.ToString();
        }

        private void gauss_jorden_Load(object sender, EventArgs e)
        {

        }
    }
}
