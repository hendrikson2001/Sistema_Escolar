namespace CRUD
{
    partial class AnoLetivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnoLetivo));
            panel2 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            textBox_ano_de_fim = new TextBox();
            label2 = new Label();
            textBox_ano_de_inicio = new TextBox();
            button_cadastrar = new Button();
            button_atualizar = new Button();
            dataGridView1 = new DataGridView();
            panel3 = new Panel();
            label11 = new Label();
            label10 = new Label();
            pictureBox4 = new PictureBox();
            textBox_pesquisar = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 43, 35);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(5, 5, 5, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1890, 117);
            panel2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(68, 53);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(198, 39);
            label1.TabIndex = 12;
            label1.Text = "Ano Lectivo";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1747, 19);
            pictureBox2.Margin = new Padding(5, 5, 5, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(84, 75);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox_ano_de_fim);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox_ano_de_inicio);
            groupBox1.Controls.Add(button_cadastrar);
            groupBox1.Controls.Add(button_atualizar);
            groupBox1.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ControlDarkDark;
            groupBox1.Location = new Point(68, 178);
            groupBox1.Margin = new Padding(5, 5, 5, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 5, 5, 5);
            groupBox1.Size = new Size(887, 424);
            groupBox1.TabIndex = 133;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro de Ano Letivo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 18F);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(419, 168);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(37, 55);
            label4.TabIndex = 127;
            label4.Text = "/";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(466, 107);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(276, 37);
            label3.TabIndex = 125;
            label3.Text = "Fim do Ano Letivo";
            label3.Click += label3_Click_1;
            // 
            // textBox_ano_de_fim
            // 
            textBox_ano_de_fim.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_ano_de_fim.Location = new Point(466, 168);
            textBox_ano_de_fim.Margin = new Padding(5, 5, 5, 5);
            textBox_ano_de_fim.Name = "textBox_ano_de_fim";
            textBox_ano_de_fim.Size = new Size(345, 45);
            textBox_ano_de_fim.TabIndex = 126;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(54, 107);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(202, 37);
            label2.TabIndex = 110;
            label2.Text = "Ano de Início";
            // 
            // textBox_ano_de_inicio
            // 
            textBox_ano_de_inicio.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_ano_de_inicio.Location = new Point(54, 168);
            textBox_ano_de_inicio.Margin = new Padding(5, 5, 5, 5);
            textBox_ano_de_inicio.Name = "textBox_ano_de_inicio";
            textBox_ano_de_inicio.Size = new Size(345, 45);
            textBox_ano_de_inicio.TabIndex = 124;
            // 
            // button_cadastrar
            // 
            button_cadastrar.BackColor = Color.Green;
            button_cadastrar.FlatAppearance.BorderSize = 0;
            button_cadastrar.FlatStyle = FlatStyle.Flat;
            button_cadastrar.Font = new Font("Microsoft Sans Serif", 12F);
            button_cadastrar.ForeColor = SystemColors.ControlLightLight;
            button_cadastrar.ImageAlign = ContentAlignment.MiddleLeft;
            button_cadastrar.Location = new Point(346, 306);
            button_cadastrar.Margin = new Padding(5, 5, 5, 5);
            button_cadastrar.Name = "button_cadastrar";
            button_cadastrar.Padding = new Padding(32, 0, 0, 0);
            button_cadastrar.Size = new Size(236, 69);
            button_cadastrar.TabIndex = 121;
            button_cadastrar.Text = "Cadastrar ";
            button_cadastrar.TextAlign = ContentAlignment.MiddleLeft;
            button_cadastrar.UseVisualStyleBackColor = false;
            // 
            // button_atualizar
            // 
            button_atualizar.BackColor = Color.FromArgb(0, 64, 64);
            button_atualizar.FlatAppearance.BorderSize = 0;
            button_atualizar.FlatStyle = FlatStyle.Flat;
            button_atualizar.Font = new Font("Microsoft Sans Serif", 12F);
            button_atualizar.ForeColor = SystemColors.ControlLightLight;
            button_atualizar.ImageAlign = ContentAlignment.MiddleLeft;
            button_atualizar.Location = new Point(592, 306);
            button_atualizar.Margin = new Padding(5, 5, 5, 5);
            button_atualizar.Name = "button_atualizar";
            button_atualizar.Padding = new Padding(32, 0, 0, 0);
            button_atualizar.Size = new Size(223, 69);
            button_atualizar.TabIndex = 123;
            button_atualizar.Text = "Atualizar";
            button_atualizar.TextAlign = ContentAlignment.MiddleLeft;
            button_atualizar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1008, 355);
            dataGridView1.Margin = new Padding(5, 5, 5, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(821, 246);
            dataGridView1.TabIndex = 132;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 43, 35);
            panel3.Controls.Add(label11);
            panel3.Location = new Point(1008, 246);
            panel3.Margin = new Padding(5, 5, 5, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(824, 75);
            panel3.TabIndex = 131;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 12F);
            label11.ForeColor = Color.MintCream;
            label11.Location = new Point(20, 21);
            label11.Margin = new Padding(5, 0, 5, 0);
            label11.Name = "label11";
            label11.Size = new Size(168, 37);
            label11.TabIndex = 35;
            label11.Text = "Ano Letivo";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F);
            label10.ForeColor = Color.FromArgb(0, 64, 64);
            label10.Location = new Point(1008, 178);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(159, 37);
            label10.TabIndex = 129;
            label10.Text = "Pesquisar";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1745, 160);
            pictureBox4.Margin = new Padding(5, 5, 5, 5);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(86, 54);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 128;
            pictureBox4.TabStop = false;
            // 
            // textBox_pesquisar
            // 
            textBox_pesquisar.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_pesquisar.Location = new Point(1237, 171);
            textBox_pesquisar.Margin = new Padding(5, 5, 5, 5);
            textBox_pesquisar.Name = "textBox_pesquisar";
            textBox_pesquisar.Size = new Size(474, 45);
            textBox_pesquisar.TabIndex = 130;
            // 
            // AnoLetivo
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1890, 656);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(panel3);
            Controls.Add(label10);
            Controls.Add(pictureBox4);
            Controls.Add(textBox_pesquisar);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 5, 5, 5);
            Name = "AnoLetivo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AnoLetivo";
            Load += AnoLetivo_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox textBox_ano_de_fim;
        private Label label2;
        private TextBox textBox_ano_de_inicio;
        private Button button2;
        private Button button_cadastrar;
        private Button button_atualizar;
        private DataGridView dataGridView1;
        private Panel panel3;
        private Label label11;
        private Label label10;
        private PictureBox pictureBox4;
        private TextBox textBox_pesquisar;
        private Label label4;
    }
}