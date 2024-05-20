namespace CRUD
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            btEntrar = new Button();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            pictureBox3 = new PictureBox();
            btCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.login2;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(491, 598);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_user_32;
            pictureBox2.Location = new Point(556, 205);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 33);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 79, 64);
            label1.Location = new Point(556, 72);
            label1.Name = "label1";
            label1.Size = new Size(113, 34);
            label1.TabIndex = 2;
            label1.Text = "LOGIN";
            // 
            // btEntrar
            // 
            btEntrar.BackColor = Color.FromArgb(0, 79, 64);
            btEntrar.FlatAppearance.BorderColor = Color.FromArgb(0, 79, 64);
            btEntrar.FlatAppearance.BorderSize = 0;
            btEntrar.FlatStyle = FlatStyle.Flat;
            btEntrar.Font = new Font("Arial Rounded MT Bold", 12F);
            btEntrar.ForeColor = SystemColors.ControlLightLight;
            btEntrar.Location = new Point(614, 392);
            btEntrar.Name = "btEntrar";
            btEntrar.Size = new Size(141, 37);
            btEntrar.TabIndex = 3;
            btEntrar.Text = "Entrar";
            btEntrar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(614, 164);
            label2.Name = "label2";
            label2.Size = new Size(86, 23);
            label2.TabIndex = 5;
            label2.Text = "Usuário";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(614, 266);
            label3.Name = "label3";
            label3.Size = new Size(71, 23);
            label3.TabIndex = 6;
            label3.Text = "Senha";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Trebuchet MS", 13.2000008F);
            textBox1.Location = new Point(614, 205);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(314, 33);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Trebuchet MS", 13.2000008F);
            textBox2.Location = new Point(614, 309);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(314, 33);
            textBox2.TabIndex = 8;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(556, 309);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 33);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // btCancelar
            // 
            btCancelar.BackColor = Color.FromArgb(222, 84, 48);
            btCancelar.FlatAppearance.BorderColor = Color.FromArgb(0, 79, 64);
            btCancelar.FlatAppearance.BorderSize = 0;
            btCancelar.FlatStyle = FlatStyle.Flat;
            btCancelar.Font = new Font("Arial Rounded MT Bold", 12F);
            btCancelar.ForeColor = SystemColors.ControlLightLight;
            btCancelar.Location = new Point(786, 392);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(142, 37);
            btCancelar.TabIndex = 10;
            btCancelar.Text = "Sair";
            btCancelar.UseVisualStyleBackColor = false;
            btCancelar.Click += btCancelar_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1029, 598);
            ControlBox = false;
            Controls.Add(btCancelar);
            Controls.Add(pictureBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btEntrar);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Button btEntrar;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private PictureBox pictureBox3;
        private Button btCancelar;
    }
}