namespace CRUD
{
    partial class processandocs
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            panel3 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ico3;
            pictureBox1.Location = new Point(451, 124);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(257, 235);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(510, 419);
            label1.Name = "label1";
            label1.Size = new Size(123, 27);
            label1.TabIndex = 1;
            label1.Text = "Aguarde..";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-2, 559);
            panel1.Name = "panel1";
            panel1.Size = new Size(1153, 52);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(216, 176, 96);
            panel2.Location = new Point(-3, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(162, 53);
            panel2.TabIndex = 3;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 79, 64);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(-2, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1153, 562);
            panel3.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 14F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(497, 418);
            label2.Name = "label2";
            label2.Size = new Size(180, 28);
            label2.TabIndex = 7;
            label2.Text = "Processando..";
            label2.Click += label2_Click;
            // 
            // processandocs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1148, 611);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "processandocs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "processandocs";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private Panel panel3;
        private Label label2;
    }
}