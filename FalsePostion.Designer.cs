
namespace Numerics_Project
{
    partial class FalsePostion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FalsePostion));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_sum = new System.Windows.Forms.Button();
            this.txt_Ferror = new System.Windows.Forms.TextBox();
            this.txt_root = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_error = new System.Windows.Forms.TextBox();
            this.txt_xu = new System.Windows.Forms.TextBox();
            this.txt_fx = new System.Windows.Forms.TextBox();
            this.txt_xl = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_clear);
            this.panel2.Controls.Add(this.btn_sum);
            this.panel2.Controls.Add(this.txt_Ferror);
            this.panel2.Controls.Add(this.txt_root);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txt_error);
            this.panel2.Controls.Add(this.txt_xu);
            this.panel2.Controls.Add(this.txt_fx);
            this.panel2.Controls.Add(this.txt_xl);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1235, 757);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(3, 233);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1235, 267);
            this.dataGridView1.TabIndex = 19;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column8.FillWeight = 513.369F;
            this.Column8.HeaderText = "Iter";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 86;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 40.94728F;
            this.Column1.HeaderText = "XL";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 40.94728F;
            this.Column2.HeaderText = "f(XL)";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 40.94728F;
            this.Column3.HeaderText = "Xu";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 40.94728F;
            this.Column4.HeaderText = "f(Xu)";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 40.94728F;
            this.Column5.HeaderText = "Xr";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 40.94728F;
            this.Column6.HeaderText = "f(Xr)";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 40.94728F;
            this.Column7.HeaderText = "Error";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(1, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 47);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(-3, 503);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 38);
            this.label1.TabIndex = 18;
            this.label1.Text = "Result:";
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_clear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_clear.BackgroundImage")));
            this.btn_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_clear.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(1051, 138);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(156, 60);
            this.btn_clear.TabIndex = 17;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_sum
            // 
            this.btn_sum.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_sum.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_sum.ForeColor = System.Drawing.Color.White;
            this.btn_sum.Location = new System.Drawing.Point(1051, 46);
            this.btn_sum.Name = "btn_sum";
            this.btn_sum.Size = new System.Drawing.Size(156, 60);
            this.btn_sum.TabIndex = 16;
            this.btn_sum.Text = "Calculate";
            this.btn_sum.UseVisualStyleBackColor = false;
            this.btn_sum.Click += new System.EventHandler(this.btn_sum_Click);
            // 
            // txt_Ferror
            // 
            this.txt_Ferror.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Ferror.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_Ferror.ForeColor = System.Drawing.Color.Black;
            this.txt_Ferror.Location = new System.Drawing.Point(404, 523);
            this.txt_Ferror.Name = "txt_Ferror";
            this.txt_Ferror.Size = new System.Drawing.Size(168, 39);
            this.txt_Ferror.TabIndex = 15;
            this.txt_Ferror.TextChanged += new System.EventHandler(this.txt_Ferror_TextChanged);
            // 
            // txt_root
            // 
            this.txt_root.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_root.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_root.ForeColor = System.Drawing.Color.Black;
            this.txt_root.Location = new System.Drawing.Point(886, 523);
            this.txt_root.Name = "txt_root";
            this.txt_root.Size = new System.Drawing.Size(168, 39);
            this.txt_root.TabIndex = 14;
            this.txt_root.TextChanged += new System.EventHandler(this.txt_root_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(192, 523);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 32);
            this.label8.TabIndex = 13;
            this.label8.Text = "Final Error:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(760, 523);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 32);
            this.label9.TabIndex = 12;
            this.label9.Text = "Root: ";
            // 
            // txt_error
            // 
            this.txt_error.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_error.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_error.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_error.Location = new System.Drawing.Point(120, 155);
            this.txt_error.Name = "txt_error";
            this.txt_error.Size = new System.Drawing.Size(355, 38);
            this.txt_error.TabIndex = 11;
            this.txt_error.Text = "please enter the ERROR";
            this.txt_error.Click += new System.EventHandler(this.enterERROR_focus);
            this.txt_error.TextChanged += new System.EventHandler(this.txt_error_TextChanged);
            this.txt_error.Leave += new System.EventHandler(this.enter_notERROR_focus);
            // 
            // txt_xu
            // 
            this.txt_xu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_xu.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_xu.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_xu.Location = new System.Drawing.Point(699, 157);
            this.txt_xu.Name = "txt_xu";
            this.txt_xu.Size = new System.Drawing.Size(245, 38);
            this.txt_xu.TabIndex = 10;
            this.txt_xu.Text = "Enter the xu value";
            this.txt_xu.Click += new System.EventHandler(this.enterxu_focus);
            this.txt_xu.TextChanged += new System.EventHandler(this.txt_xu_TextChanged);
            this.txt_xu.Leave += new System.EventHandler(this.enter_notxu_focus);
            // 
            // txt_fx
            // 
            this.txt_fx.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_fx.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_fx.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_fx.Location = new System.Drawing.Point(120, 77);
            this.txt_fx.Name = "txt_fx";
            this.txt_fx.Size = new System.Drawing.Size(355, 38);
            this.txt_fx.TabIndex = 9;
            this.txt_fx.Text = "please enter the function";
            this.txt_fx.Click += new System.EventHandler(this.enter_focus);
            this.txt_fx.TextChanged += new System.EventHandler(this.txt_fx_TextChanged);
            this.txt_fx.Leave += new System.EventHandler(this.enter_not_focus);
            // 
            // txt_xl
            // 
            this.txt_xl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_xl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_xl.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_xl.Location = new System.Drawing.Point(699, 78);
            this.txt_xl.Name = "txt_xl";
            this.txt_xl.Size = new System.Drawing.Size(245, 38);
            this.txt_xl.TabIndex = 5;
            this.txt_xl.Text = "Enter the Xl value";
            this.txt_xl.Click += new System.EventHandler(this.enterXL_focus);
            this.txt_xl.TextChanged += new System.EventHandler(this.txt_xl_TextChanged);
            this.txt_xl.Leave += new System.EventHandler(this.enterXL_not_focus);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(23, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 32);
            this.label6.TabIndex = 4;
            this.label6.Text = "Error";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(50, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 32);
            this.label5.TabIndex = 3;
            this.label5.Text = "F(x)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(629, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "Xu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(629, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Xl";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(520, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Input";
            // 
            // FalsePostion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 568);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FalsePostion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FalsePostion";
            this.Load += new System.EventHandler(this.FalsePostion_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_sum;
        private System.Windows.Forms.TextBox txt_Ferror;
        private System.Windows.Forms.TextBox txt_root;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_error;
        private System.Windows.Forms.TextBox txt_xu;
        private System.Windows.Forms.TextBox txt_fx;
        private System.Windows.Forms.TextBox txt_xl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}