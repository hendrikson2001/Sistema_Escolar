namespace CRUD
{
    partial class CadastroTurmas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroTurmas));
            groupBox1 = new GroupBox();
            button1 = new Button();
            button3 = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            label16 = new Label();
            label15 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            dataGridView1 = new DataGridView();
            panel3 = new Panel();
            label11 = new Label();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox4);
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button3);
            groupBox1.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ControlDarkDark;
            groupBox1.Location = new Point(31, 108);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(633, 337);
            groupBox1.TabIndex = 36;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro de Turma";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Rounded MT Bold", 12F);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(267, 242);
            button1.Name = "button1";
            button1.Padding = new Padding(20, 0, 0, 0);
            button1.Size = new Size(148, 43);
            button1.TabIndex = 42;
            button1.Text = "Cadastrar ";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 64, 64);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial Rounded MT Bold", 12F);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(436, 242);
            button3.Name = "button3";
            button3.Padding = new Padding(20, 0, 0, 0);
            button3.Size = new Size(140, 43);
            button3.TabIndex = 44;
            button3.Text = "Atualizar";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 43, 35);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(704, 73);
            panel2.TabIndex = 37;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(44, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(65, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 13F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(115, 23);
            label1.Name = "label1";
            label1.Size = new Size(81, 26);
            label1.TabIndex = 10;
            label1.Text = "Turma";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(612, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 47);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial Rounded MT Bold", 12F);
            label16.ForeColor = Color.FromArgb(0, 64, 64);
            label16.Location = new Point(244, 133);
            label16.Name = "label16";
            label16.Size = new Size(132, 23);
            label16.TabIndex = 79;
            label16.Text = "Licenciatura";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial Rounded MT Bold", 12F);
            label15.ForeColor = Color.FromArgb(0, 64, 64);
            label15.Location = new Point(584, 57);
            label15.Name = "label15";
            label15.Size = new Size(0, 23);
            label15.TabIndex = 80;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F);
            label2.ForeColor = Color.FromArgb(0, 64, 64);
            label2.Location = new Point(244, 45);
            label2.Name = "label2";
            label2.Size = new Size(112, 23);
            label2.TabIndex = 82;
            label2.Text = "Ano Letivo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F);
            label3.ForeColor = Color.FromArgb(0, 64, 64);
            label3.Location = new Point(425, 45);
            label3.Name = "label3";
            label3.Size = new Size(153, 23);
            label3.TabIndex = 83;
            label3.Text = "Ano Curricular";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F);
            label4.ForeColor = Color.FromArgb(0, 64, 64);
            label4.Location = new Point(29, 45);
            label4.Name = "label4";
            label4.Size = new Size(106, 23);
            label4.TabIndex = 85;
            label4.Text = "Professor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 12F);
            label5.ForeColor = Color.FromArgb(0, 64, 64);
            label5.Location = new Point(29, 133);
            label5.Name = "label5";
            label5.Size = new Size(166, 23);
            label5.TabIndex = 84;
            label5.Text = "Nome da Turma";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(29, 171);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(187, 31);
            textBox2.TabIndex = 83;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(29, 83);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(187, 34);
            comboBox1.TabIndex = 86;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(244, 83);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(152, 34);
            comboBox2.TabIndex = 87;
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(425, 83);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(153, 34);
            comboBox3.TabIndex = 88;
            // 
            // comboBox4
            // 
            comboBox4.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(244, 171);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(334, 34);
            comboBox4.TabIndex = 89;
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 552);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(633, 236);
            dataGridView1.TabIndex = 112;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 43, 35);
            panel3.Controls.Add(label11);
            panel3.Location = new Point(31, 474);
            panel3.Name = "panel3";
            panel3.Size = new Size(633, 64);
            panel3.TabIndex = 111;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Rounded MT Bold", 14F);
            label11.ForeColor = Color.MintCream;
            label11.Location = new Point(22, 20);
            label11.Name = "label11";
            label11.Size = new Size(197, 28);
            label11.TabIndex = 35;
            label11.Text = "Lista de Turmas";
            // 
            // CadastroTurmas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(704, 814);
            Controls.Add(dataGridView1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CadastroTurmas";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CadastroTurmas";
            Load += CadastroTurmas_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private Button button3;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label16;
        private Label label15;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private Label label5;
        private ComboBox comboBox1;
        private ComboBox comboBox4;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private DataGridView dataGridView1;
        private Panel panel3;
        private Label label11;
    }
}