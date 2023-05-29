using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numerics_Project
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }
       


        private void Home_Load(object sender, EventArgs e)
        {
            
        }




        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Bisection_Click(object sender, EventArgs e)
        {
            Bisection b = new Bisection();
            this.Hide();
            b.Show();
        }

        private void False_Click(object sender, EventArgs e)
        {
            FalsePostion f = new FalsePostion();
            this.Hide();
            f.Show();
        }

        private void Fixed_Click(object sender, EventArgs e)
        {
            Fixed s = new Fixed();
            this.Hide();
            s.Show();
        }

        private void newton_Click(object sender, EventArgs e)
        {
            Newton n = new Newton();
            this.Hide();
            n.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Secant ss = new Secant();
            this.Hide();
            ss.Show();
        }

        private void Guass_Click(object sender, EventArgs e)
        {
            GaussElimination gg = new GaussElimination();
            this.Hide();
            gg.Show();
        }

        private void LU_Click(object sender, EventArgs e)
        {
            LU_Decomposition lu = new LU_Decomposition();
            this.Hide();
            lu.Show();
        }

        private void Cramer_Click(object sender, EventArgs e)
        {
            CramerRule cr = new CramerRule();
            this.Hide();
            cr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gauss_jorden cr = new gauss_jorden();
            this.Hide();
            cr.Show();
        }

        private void pp_Click(object sender, EventArgs e)
        {

        }
    }
}
