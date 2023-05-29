
namespace Numerics_Project
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.LU = new System.Windows.Forms.Button();
            this.Cramer = new System.Windows.Forms.Button();
            this.Guass = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.newton = new System.Windows.Forms.Button();
            this.Fixed = new System.Windows.Forms.Button();
            this.False = new System.Windows.Forms.Button();
            this.Bisection = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Chapter1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.LU);
            this.panel2.Controls.Add(this.Cramer);
            this.panel2.Controls.Add(this.Guass);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.newton);
            this.panel2.Controls.Add(this.Fixed);
            this.panel2.Controls.Add(this.False);
            this.panel2.Controls.Add(this.Bisection);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Chapter1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1212, 712);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(619, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(394, 49);
            this.button1.TabIndex = 14;
            this.button1.Text = "Gauss Jordan Elimination";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LU
            // 
            this.LU.BackColor = System.Drawing.Color.SkyBlue;
            this.LU.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LU.ForeColor = System.Drawing.Color.Black;
            this.LU.Location = new System.Drawing.Point(619, 385);
            this.LU.Name = "LU";
            this.LU.Size = new System.Drawing.Size(394, 49);
            this.LU.TabIndex = 13;
            this.LU.Text = "LU Decomposition";
            this.LU.UseVisualStyleBackColor = false;
            this.LU.Click += new System.EventHandler(this.LU_Click);
            // 
            // Cramer
            // 
            this.Cramer.BackColor = System.Drawing.Color.SkyBlue;
            this.Cramer.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Cramer.ForeColor = System.Drawing.Color.Black;
            this.Cramer.Location = new System.Drawing.Point(619, 525);
            this.Cramer.Name = "Cramer";
            this.Cramer.Size = new System.Drawing.Size(394, 49);
            this.Cramer.TabIndex = 12;
            this.Cramer.Text = "Cramer\'s Rule";
            this.Cramer.UseVisualStyleBackColor = false;
            this.Cramer.Click += new System.EventHandler(this.Cramer_Click);
            // 
            // Guass
            // 
            this.Guass.BackColor = System.Drawing.Color.SkyBlue;
            this.Guass.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Guass.ForeColor = System.Drawing.Color.Black;
            this.Guass.Location = new System.Drawing.Point(619, 315);
            this.Guass.Name = "Guass";
            this.Guass.Size = new System.Drawing.Size(394, 49);
            this.Guass.TabIndex = 11;
            this.Guass.Text = "Gauss Elimination";
            this.Guass.UseVisualStyleBackColor = false;
            this.Guass.Click += new System.EventHandler(this.Guass_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.SkyBlue;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(70, 595);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(394, 49);
            this.button5.TabIndex = 10;
            this.button5.Text = "  Secant Method";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // newton
            // 
            this.newton.BackColor = System.Drawing.Color.SkyBlue;
            this.newton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newton.ForeColor = System.Drawing.Color.Black;
            this.newton.Location = new System.Drawing.Point(70, 525);
            this.newton.Name = "newton";
            this.newton.Size = new System.Drawing.Size(394, 49);
            this.newton.TabIndex = 9;
            this.newton.Text = "Newton Method";
            this.newton.UseVisualStyleBackColor = false;
            this.newton.Click += new System.EventHandler(this.newton_Click);
            // 
            // Fixed
            // 
            this.Fixed.BackColor = System.Drawing.Color.SkyBlue;
            this.Fixed.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Fixed.ForeColor = System.Drawing.Color.Black;
            this.Fixed.Location = new System.Drawing.Point(70, 455);
            this.Fixed.Name = "Fixed";
            this.Fixed.Size = new System.Drawing.Size(394, 49);
            this.Fixed.TabIndex = 8;
            this.Fixed.Text = "Simple Fixed Point Method";
            this.Fixed.UseVisualStyleBackColor = false;
            this.Fixed.Click += new System.EventHandler(this.Fixed_Click);
            // 
            // False
            // 
            this.False.BackColor = System.Drawing.Color.SkyBlue;
            this.False.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.False.ForeColor = System.Drawing.Color.Black;
            this.False.Location = new System.Drawing.Point(70, 385);
            this.False.Name = "False";
            this.False.Size = new System.Drawing.Size(394, 49);
            this.False.TabIndex = 7;
            this.False.Text = "False Position Method";
            this.False.UseVisualStyleBackColor = false;
            this.False.Click += new System.EventHandler(this.False_Click);
            // 
            // Bisection
            // 
            this.Bisection.BackColor = System.Drawing.Color.SkyBlue;
            this.Bisection.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Bisection.ForeColor = System.Drawing.Color.Black;
            this.Bisection.Location = new System.Drawing.Point(70, 315);
            this.Bisection.Name = "Bisection";
            this.Bisection.Size = new System.Drawing.Size(394, 49);
            this.Bisection.TabIndex = 6;
            this.Bisection.Text = "Bisection Method";
            this.Bisection.UseVisualStyleBackColor = false;
            this.Bisection.Click += new System.EventHandler(this.Bisection_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.MediumBlue;
            this.label3.Location = new System.Drawing.Point(245, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(610, 57);
            this.label3.TabIndex = 5;
            this.label3.Text = "Welcome to our application";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(752, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chapter 2";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // Chapter1
            // 
            this.Chapter1.AutoSize = true;
            this.Chapter1.BackColor = System.Drawing.Color.Transparent;
            this.Chapter1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Chapter1.Location = new System.Drawing.Point(199, 273);
            this.Chapter1.Name = "Chapter1";
            this.Chapter1.Size = new System.Drawing.Size(133, 32);
            this.Chapter1.TabIndex = 3;
            this.Chapter1.Text = "Chapter 1";
            this.Chapter1.Click += new System.EventHandler(this.label2_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1212, 712);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Numerical Project";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_go;
        private System.Windows.Forms.Label Chapter1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button LU;
        private System.Windows.Forms.Button Cramer;
        private System.Windows.Forms.Button Guass;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button newton;
        private System.Windows.Forms.Button Fixed;
        private System.Windows.Forms.Button False;
        private System.Windows.Forms.Button Bisection;
    }
}

