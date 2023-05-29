using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Numerics_Project
{
    public partial class LU_Decomposition : Form
    {
        double m21 = 0, m31 = 0, m32 = 0;
        double x1 = 0, x2 = 0, x3 = 0;

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_00.Text = ""; txt_01.Text = ""; txt_02.Text = ""; txt_03.Text = "";
            txt_10.Text = ""; txt_11.Text = ""; txt_12.Text = ""; txt_13.Text = "";
            txt_20.Text = ""; txt_21.Text = ""; txt_22.Text = ""; txt_23.Text = "";

            lbl_r00.Text = ""; lbl_r01.Text = ""; lbl_r02.Text = ""; lbl_r03.Text = "";
            lbl_r10.Text = ""; lbl_r11.Text = ""; lbl_r12.Text = ""; lbl_r13.Text = "";
            lbl_r20.Text = ""; lbl_r21.Text = ""; lbl_r22.Text = ""; lbl_r23.Text = "";

            lbl_u00.Text = ""; lbl_u01.Text = ""; lbl_u02.Text = ""; 
            lbl_u10.Text = ""; lbl_u11.Text = ""; lbl_u12.Text = ""; 
            lbl_u20.Text = ""; lbl_u21.Text = ""; lbl_u22.Text = "";

            lbl_l00.Text = ""; lbl_l01.Text = ""; lbl_l02.Text = "";
            lbl_l10.Text = ""; lbl_l11.Text = ""; lbl_l12.Text = "";
            lbl_l20.Text = ""; lbl_l21.Text = ""; lbl_l22.Text = "";

            lbl_b03.Text = ""; lbl_b13.Text = ""; lbl_b23.Text = "";

            lbl_ll00.Text = ""; lbl_ll01.Text = ""; lbl_ll02.Text = "";
            lbl_ll10.Text = ""; lbl_ll11.Text = ""; lbl_ll12.Text = "";
            lbl_ll20.Text = ""; lbl_ll21.Text = ""; lbl_ll22.Text = "";

            lbl_bb03.Text = ""; lbl_bb13.Text = ""; lbl_bb23.Text = "";

            lbl_c1.Text = ""; lbl_c2.Text = ""; lbl_c3.Text = "";

            lbl_uu00.Text = ""; lbl_uu01.Text = ""; lbl_uu02.Text = "";
            lbl_uu10.Text = ""; lbl_uu11.Text = ""; lbl_uu12.Text = "";
            lbl_uu20.Text = ""; lbl_uu21.Text = ""; lbl_uu22.Text = "";

            lbl_cc1.Text = ""; lbl_cc2.Text = ""; lbl_cc3.Text = "";

            x1R.Text = ""; x2R.Text = ""; x3R.Text = "";
        }



        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

       

        

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void x1R_Click(object sender, EventArgs e)
        {

        }

        

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_back_Click_1(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        public LU_Decomposition()
        {
            InitializeComponent();
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

            double b03 = x03;  double b13 = x13;  double b23 = x23;

            m21 = x10 / x00;
            m31 = x20 / x00;

            x10 = x10 - (m21 * x00);  x11 = x11 - (m21 * x01);
            x12 = x12 - (m21 * x02);  x13 = x13 - (m21 * x03);

            x20 = x20 - (m31 * x00);  x21 = x21 - (m31 * x01);
            x22 = x22 - (m31 * x02);  x23 = x23 - (m31 * x03);

            m32 = x21 / x11;

            x20 = x20 - (m32 * x10);  x21 = x21 - (m32 * x11);
            x22 = x22 - (m32 * x12);  x23 = x23 - (m32 * x13);

            lbl_r00.Text = x00.ToString(); lbl_r01.Text = x01.ToString();
            lbl_r02.Text = x02.ToString(); lbl_r03.Text = x03.ToString();

            lbl_r10.Text = x10.ToString(); lbl_r11.Text = x11.ToString();
            lbl_r12.Text = x12.ToString(); lbl_r13.Text = x13.ToString();

            lbl_r20.Text = x20.ToString(); lbl_r21.Text = x21.ToString();
            lbl_r22.Text = x22.ToString(); lbl_r23.Text = x23.ToString();

            double u00 = x00; double u01 = x01; double u02 = x02;
            double u10 = x10; double u11 = x11; double u12 = x12;
            double u20 = x20; double u21 = x21; double u22 = x22;

            double l00 = 1; double l01 = 0; double l02 = 0;
            double l10 = m21; double l11 = 1; double l12 = 0;
            double l20 = m31; double l21 = m32; double l22 = 1;

            lbl_u00.Text = u00.ToString(); lbl_u01.Text = u01.ToString(); lbl_u02.Text = u02.ToString();
            lbl_u10.Text = u10.ToString(); lbl_u11.Text = u11.ToString(); lbl_u12.Text = u12.ToString();
            lbl_u20.Text = u20.ToString(); lbl_u21.Text = u21.ToString(); lbl_u22.Text = u22.ToString();

            lbl_l00.Text = l00.ToString(); lbl_l01.Text = l01.ToString(); lbl_l02.Text = l02.ToString();
            lbl_l10.Text = l10.ToString(); lbl_l11.Text = l11.ToString(); lbl_l12.Text = l12.ToString();
            lbl_l20.Text = l20.ToString(); lbl_l21.Text = l21.ToString(); lbl_l22.Text = l22.ToString();

            lbl_b03.Text = b03.ToString(); lbl_b13.Text = b13.ToString(); lbl_b23.Text = b23.ToString();

            lbl_ll00.Text = l00.ToString(); lbl_ll01.Text = l01.ToString(); lbl_ll02.Text = l02.ToString();
            lbl_ll10.Text = l10.ToString(); lbl_ll11.Text = l11.ToString(); lbl_ll12.Text = l12.ToString();
            lbl_ll20.Text = l20.ToString(); lbl_ll21.Text = l21.ToString(); lbl_ll22.Text = l22.ToString();

            lbl_bb03.Text = b03.ToString(); lbl_bb13.Text = b13.ToString(); lbl_bb23.Text = b23.ToString();

            double c1 = b03 / l00;
            double c2 = (b13 - (l10) * c1) / l11;
            double c3 = (b23 - ((l20 * c1) + (l21 * c2))) / l22;

            lbl_c1.Text = c1.ToString();
            lbl_c2.Text = c2.ToString();
            lbl_c3.Text = c3.ToString();

            lbl_uu00.Text = u00.ToString(); lbl_uu01.Text = u01.ToString(); lbl_uu02.Text = u02.ToString();
            lbl_uu10.Text = u10.ToString(); lbl_uu11.Text = u11.ToString(); lbl_uu12.Text = u12.ToString();
            lbl_uu20.Text = u20.ToString(); lbl_uu21.Text = u21.ToString(); lbl_uu22.Text = u22.ToString();

            lbl_cc1.Text = c1.ToString();
            lbl_cc2.Text = c2.ToString();
            lbl_cc3.Text = c3.ToString();

            double x3 = c3 / u22;
            double x2 = (c2 - (u12 * x3)) / u11;
            double x1 = (c1 - (u01 * x2) - (u02 * x3)) / u00;

            x1R.Text = x1.ToString();
            x2R.Text = x2.ToString();
            x3R.Text = x3.ToString();
        }
    }
}
