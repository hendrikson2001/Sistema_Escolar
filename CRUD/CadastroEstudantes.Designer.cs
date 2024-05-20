namespace CRUD
{
    partial class CadastroEstudantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroEstudantes));
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            groupBox1 = new GroupBox();
            groupBox4 = new GroupBox();
            label9 = new Label();
            textBox_licenciatura = new TextBox();
            groupBox3 = new GroupBox();
            label16 = new Label();
            textBox_municipio = new TextBox();
            label15 = new Label();
            textBox_bairro = new TextBox();
            label13 = new Label();
            textBox_rua = new TextBox();
            button_cadastro = new Button();
            groupBox2 = new GroupBox();
            textBox_primero_nome = new TextBox();
            label4 = new Label();
            textBox_numero_bilhete = new TextBox();
            textBox_email = new TextBox();
            label14 = new Label();
            textBox_ultimo_nome = new TextBox();
            label3 = new Label();
            label5 = new Label();
            textBox_numero_passaporte = new TextBox();
            label2 = new Label();
            textBox_nacionalidade = new TextBox();
            label7 = new Label();
            label10 = new Label();
            textBox_genero = new TextBox();
            textBox_teletone = new TextBox();
            label6 = new Label();
            textBox_data_de_nascimento = new TextBox();
            label8 = new Label();
            button_atualizar = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 43, 35);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(5, 5, 5, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1934, 117);
            panel2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(72, 19);
            pictureBox1.Margin = new Padding(5, 5, 5, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(106, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(210, 53);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(173, 39);
            label1.TabIndex = 10;
            label1.Text = "Estudante";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1794, 19);
            pictureBox2.Margin = new Padding(5, 5, 5, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(84, 75);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(button_cadastro);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(button_atualizar);
            groupBox1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ControlDarkDark;
            groupBox1.Location = new Point(91, 187);
            groupBox1.Margin = new Padding(5, 5, 5, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 5, 5, 5);
            groupBox1.Size = new Size(1788, 1141);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro de Estudante";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(textBox_licenciatura);
            groupBox4.Location = new Point(63, 787);
            groupBox4.Margin = new Padding(5, 5, 5, 5);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(5, 5, 5, 5);
            groupBox4.Size = new Size(1659, 208);
            groupBox4.TabIndex = 75;
            groupBox4.TabStop = false;
            groupBox4.Text = "Acadêmico";
            groupBox4.Enter += groupBox4_Enter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F);
            label9.ForeColor = Color.FromArgb(0, 64, 64);
            label9.Location = new Point(39, 74);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(208, 37);
            label9.TabIndex = 70;
            label9.Text = "Lincenciatura";
            // 
            // textBox_licenciatura
            // 
            textBox_licenciatura.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_licenciatura.Location = new Point(39, 115);
            textBox_licenciatura.Margin = new Padding(5, 5, 5, 5);
            textBox_licenciatura.Name = "textBox_licenciatura";
            textBox_licenciatura.Size = new Size(417, 45);
            textBox_licenciatura.TabIndex = 69;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(textBox_municipio);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(textBox_bairro);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(textBox_rua);
            groupBox3.Location = new Point(63, 546);
            groupBox3.Margin = new Padding(5, 5, 5, 5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(5, 5, 5, 5);
            groupBox3.Size = new Size(1659, 208);
            groupBox3.TabIndex = 74;
            groupBox3.TabStop = false;
            groupBox3.Text = "Endereço";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 12F);
            label16.ForeColor = Color.FromArgb(0, 64, 64);
            label16.Location = new Point(39, 67);
            label16.Margin = new Padding(5, 0, 5, 0);
            label16.Name = "label16";
            label16.Size = new Size(152, 37);
            label16.TabIndex = 72;
            label16.Text = "Município";
            // 
            // textBox_municipio
            // 
            textBox_municipio.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_municipio.Location = new Point(39, 109);
            textBox_municipio.Margin = new Padding(5, 5, 5, 5);
            textBox_municipio.Name = "textBox_municipio";
            textBox_municipio.Size = new Size(417, 45);
            textBox_municipio.TabIndex = 71;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 12F);
            label15.ForeColor = Color.FromArgb(0, 64, 64);
            label15.Location = new Point(478, 67);
            label15.Margin = new Padding(5, 0, 5, 0);
            label15.Name = "label15";
            label15.Size = new Size(103, 37);
            label15.TabIndex = 72;
            label15.Text = "Bairro";
            label15.Click += label15_Click;
            // 
            // textBox_bairro
            // 
            textBox_bairro.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_bairro.Location = new Point(478, 109);
            textBox_bairro.Margin = new Padding(5, 5, 5, 5);
            textBox_bairro.Name = "textBox_bairro";
            textBox_bairro.Size = new Size(417, 45);
            textBox_bairro.TabIndex = 71;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 12F);
            label13.ForeColor = Color.FromArgb(0, 64, 64);
            label13.Location = new Point(928, 67);
            label13.Margin = new Padding(5, 0, 5, 0);
            label13.Name = "label13";
            label13.Size = new Size(75, 37);
            label13.TabIndex = 72;
            label13.Text = "Rua";
            // 
            // textBox_rua
            // 
            textBox_rua.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_rua.Location = new Point(928, 109);
            textBox_rua.Margin = new Padding(5, 5, 5, 5);
            textBox_rua.Name = "textBox_rua";
            textBox_rua.Size = new Size(232, 45);
            textBox_rua.TabIndex = 71;
            // 
            // button_cadastro
            // 
            button_cadastro.BackColor = Color.Green;
            button_cadastro.FlatAppearance.BorderSize = 0;
            button_cadastro.FlatStyle = FlatStyle.Flat;
            button_cadastro.Font = new Font("Microsoft Sans Serif", 12F);
            button_cadastro.ForeColor = SystemColors.ControlLightLight;
            button_cadastro.ImageAlign = ContentAlignment.MiddleLeft;
            button_cadastro.Location = new Point(1220, 1030);
            button_cadastro.Margin = new Padding(5, 5, 5, 5);
            button_cadastro.Name = "button_cadastro";
            button_cadastro.Padding = new Padding(32, 0, 0, 0);
            button_cadastro.Size = new Size(240, 69);
            button_cadastro.TabIndex = 42;
            button_cadastro.Text = "Cadastrar ";
            button_cadastro.TextAlign = ContentAlignment.MiddleLeft;
            button_cadastro.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox_primero_nome);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textBox_numero_bilhete);
            groupBox2.Controls.Add(textBox_email);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(textBox_ultimo_nome);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textBox_numero_passaporte);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBox_nacionalidade);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(textBox_genero);
            groupBox2.Controls.Add(textBox_teletone);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(textBox_data_de_nascimento);
            groupBox2.Controls.Add(label8);
            groupBox2.ForeColor = Color.FromArgb(64, 64, 64);
            groupBox2.Location = new Point(63, 77);
            groupBox2.Margin = new Padding(5, 5, 5, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5, 5, 5, 5);
            groupBox2.Size = new Size(1659, 440);
            groupBox2.TabIndex = 73;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dados Pessoais";
            // 
            // textBox_primero_nome
            // 
            textBox_primero_nome.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_primero_nome.Location = new Point(39, 112);
            textBox_primero_nome.Margin = new Padding(5, 5, 5, 5);
            textBox_primero_nome.Name = "textBox_primero_nome";
            textBox_primero_nome.Size = new Size(371, 45);
            textBox_primero_nome.TabIndex = 47;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.ForeColor = Color.FromArgb(0, 64, 64);
            label4.Location = new Point(39, 70);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(231, 37);
            label4.TabIndex = 48;
            label4.Text = "Primeiro Nome";
            // 
            // textBox_numero_bilhete
            // 
            textBox_numero_bilhete.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_numero_bilhete.Location = new Point(838, 112);
            textBox_numero_bilhete.Margin = new Padding(5, 5, 5, 5);
            textBox_numero_bilhete.Name = "textBox_numero_bilhete";
            textBox_numero_bilhete.Size = new Size(386, 45);
            textBox_numero_bilhete.TabIndex = 49;
            // 
            // textBox_email
            // 
            textBox_email.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_email.Location = new Point(1254, 243);
            textBox_email.Margin = new Padding(5, 5, 5, 5);
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(362, 45);
            textBox_email.TabIndex = 67;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 12F);
            label14.ForeColor = Color.FromArgb(0, 64, 64);
            label14.Location = new Point(439, 184);
            label14.Margin = new Padding(5, 0, 5, 0);
            label14.Name = "label14";
            label14.Size = new Size(123, 37);
            label14.TabIndex = 68;
            label14.Text = "Gênero";
            // 
            // textBox_ultimo_nome
            // 
            textBox_ultimo_nome.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_ultimo_nome.Location = new Point(439, 112);
            textBox_ultimo_nome.Margin = new Padding(5, 5, 5, 5);
            textBox_ultimo_nome.Name = "textBox_ultimo_nome";
            textBox_ultimo_nome.Size = new Size(371, 45);
            textBox_ultimo_nome.TabIndex = 61;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.ForeColor = Color.FromArgb(0, 64, 64);
            label3.Location = new Point(1254, 70);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(224, 37);
            label3.TabIndex = 64;
            label3.Text = "Nº Passaporte";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F);
            label5.ForeColor = Color.FromArgb(0, 64, 64);
            label5.Location = new Point(838, 70);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(91, 37);
            label5.TabIndex = 50;
            label5.Text = "Nº BI";
            // 
            // textBox_numero_passaporte
            // 
            textBox_numero_passaporte.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_numero_passaporte.Location = new Point(1254, 112);
            textBox_numero_passaporte.Margin = new Padding(5, 5, 5, 5);
            textBox_numero_passaporte.Name = "textBox_numero_passaporte";
            textBox_numero_passaporte.Size = new Size(362, 45);
            textBox_numero_passaporte.TabIndex = 63;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.ForeColor = Color.FromArgb(0, 64, 64);
            label2.Location = new Point(439, 70);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(203, 37);
            label2.TabIndex = 62;
            label2.Text = "Último Nome";
            // 
            // textBox_nacionalidade
            // 
            textBox_nacionalidade.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_nacionalidade.Location = new Point(39, 243);
            textBox_nacionalidade.Margin = new Padding(5, 5, 5, 5);
            textBox_nacionalidade.Name = "textBox_nacionalidade";
            textBox_nacionalidade.Size = new Size(371, 45);
            textBox_nacionalidade.TabIndex = 53;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F);
            label7.ForeColor = Color.FromArgb(0, 64, 64);
            label7.Location = new Point(838, 184);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(308, 37);
            label7.TabIndex = 54;
            label7.Text = "Data de Nascimento";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F);
            label10.ForeColor = Color.FromArgb(0, 64, 64);
            label10.Location = new Point(39, 184);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(221, 37);
            label10.TabIndex = 66;
            label10.Text = "Nacionalidade";
            // 
            // textBox_genero
            // 
            textBox_genero.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_genero.Location = new Point(439, 243);
            textBox_genero.Margin = new Padding(5, 5, 5, 5);
            textBox_genero.Name = "textBox_genero";
            textBox_genero.Size = new Size(371, 45);
            textBox_genero.TabIndex = 55;
            // 
            // textBox_teletone
            // 
            textBox_teletone.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_teletone.Location = new Point(29, 363);
            textBox_teletone.Margin = new Padding(5, 5, 5, 5);
            textBox_teletone.Name = "textBox_teletone";
            textBox_teletone.Size = new Size(381, 45);
            textBox_teletone.TabIndex = 65;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F);
            label6.ForeColor = Color.FromArgb(0, 64, 64);
            label6.Location = new Point(29, 322);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(140, 37);
            label6.TabIndex = 56;
            label6.Text = "Telefone";
            // 
            // textBox_data_de_nascimento
            // 
            textBox_data_de_nascimento.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_data_de_nascimento.Location = new Point(838, 243);
            textBox_data_de_nascimento.Margin = new Padding(5, 5, 5, 5);
            textBox_data_de_nascimento.Name = "textBox_data_de_nascimento";
            textBox_data_de_nascimento.Size = new Size(386, 45);
            textBox_data_de_nascimento.TabIndex = 55;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F);
            label8.ForeColor = Color.FromArgb(0, 64, 64);
            label8.Location = new Point(1254, 184);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(97, 37);
            label8.TabIndex = 56;
            label8.Text = "Email";
            // 
            // button_atualizar
            // 
            button_atualizar.BackColor = Color.FromArgb(0, 64, 64);
            button_atualizar.FlatAppearance.BorderSize = 0;
            button_atualizar.FlatStyle = FlatStyle.Flat;
            button_atualizar.Font = new Font("Microsoft Sans Serif", 12F);
            button_atualizar.ForeColor = SystemColors.ControlLightLight;
            button_atualizar.ImageAlign = ContentAlignment.MiddleLeft;
            button_atualizar.Location = new Point(1495, 1030);
            button_atualizar.Margin = new Padding(5, 5, 5, 5);
            button_atualizar.Name = "button_atualizar";
            button_atualizar.Padding = new Padding(32, 0, 0, 0);
            button_atualizar.Size = new Size(228, 69);
            button_atualizar.TabIndex = 44;
            button_atualizar.Text = "Atualizar";
            button_atualizar.TextAlign = ContentAlignment.MiddleLeft;
            button_atualizar.UseVisualStyleBackColor = false;
            // 
            // CadastroEstudantes
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1934, 1378);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 5, 5, 5);
            Name = "CadastroEstudantes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadastroEstudantes";
            Load += CadastroEstudantes_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label8;
        private TextBox textBox_genero;
        private Label label7;
        private TextBox textBox_nacionalidade;
        private Label label5;
        private TextBox textBox_numero_bilhete;
        private Label label4;
        private TextBox textBox_primero_nome;
        private Button button_atualizar;
        private Button button_cadastro;
        private Label label2;
        private TextBox textBox_ultimo_nome;
        private Label label3;
        private TextBox textBox_numero_passaporte;
        private Label label10;
        private TextBox textBox_teletone;
        private Label label14;
        private TextBox textBox_email;
        private Label label9;
        private TextBox textBox_licenciatura;
        private Label label6;
        private TextBox textBox_data_de_nascimento;
        private Label label15;
        private TextBox textBox_bairro;
        private Label label13;
        private TextBox textBox_rua;
        private GroupBox groupBox2;
        private Label label16;
        private TextBox textBox_municipio;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
    }
}