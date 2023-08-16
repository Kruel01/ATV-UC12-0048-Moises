namespace ATV_UC12_0048_Moises
{
    partial class Form1
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
            TxtID = new TextBox();
            TxtNome = new TextBox();
            TxtCPF = new TextBox();
            TxtSalario = new TextBox();
            DTNascimento = new DateTimePicker();
            BtnCadastrar = new Button();
            LblId = new Label();
            LblNome = new Label();
            LblCpf = new Label();
            LblDataNascimento = new Label();
            LblSalario = new Label();
            BTNCorrentista2 = new Button();
            BTNCorrentista1 = new Button();
            SuspendLayout();
            // 
            // TxtID
            // 
            TxtID.Location = new Point(99, 52);
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(74, 23);
            TxtID.TabIndex = 0;
            TxtID.TextChanged += TxtID_TextChanged;
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(99, 99);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(244, 23);
            TxtNome.TabIndex = 1;
            TxtNome.TextChanged += TxtNome_TextChanged;
            // 
            // TxtCPF
            // 
            TxtCPF.Location = new Point(99, 143);
            TxtCPF.Name = "TxtCPF";
            TxtCPF.Size = new Size(244, 23);
            TxtCPF.TabIndex = 2;
            TxtCPF.TextChanged += TxtCPF_TextChanged;
            TxtCPF.KeyPress += KeyPress;
            // 
            // TxtSalario
            // 
            TxtSalario.Location = new Point(167, 227);
            TxtSalario.Name = "TxtSalario";
            TxtSalario.Size = new Size(113, 23);
            TxtSalario.TabIndex = 4;
            TxtSalario.TextChanged += TxtSalario_TextChanged;
            // 
            // DTNascimento
            // 
            DTNascimento.Location = new Point(167, 185);
            DTNascimento.Name = "DTNascimento";
            DTNascimento.Size = new Size(246, 23);
            DTNascimento.TabIndex = 3;
            DTNascimento.ValueChanged += DTNascimento_ValueChanged;
            // 
            // BtnCadastrar
            // 
            BtnCadastrar.Location = new Point(230, 267);
            BtnCadastrar.Name = "BtnCadastrar";
            BtnCadastrar.Size = new Size(75, 23);
            BtnCadastrar.TabIndex = 5;
            BtnCadastrar.Text = "Cadastrar";
            BtnCadastrar.UseVisualStyleBackColor = true;
            BtnCadastrar.Click += BtnCadastrar_Click;
            // 
            // LblId
            // 
            LblId.AutoSize = true;
            LblId.Location = new Point(47, 52);
            LblId.Name = "LblId";
            LblId.Size = new Size(17, 15);
            LblId.TabIndex = 6;
            LblId.Text = "Id";
            // 
            // LblNome
            // 
            LblNome.AutoSize = true;
            LblNome.Location = new Point(43, 102);
            LblNome.Name = "LblNome";
            LblNome.Size = new Size(40, 15);
            LblNome.TabIndex = 7;
            LblNome.Text = "Nome";
            // 
            // LblCpf
            // 
            LblCpf.AutoSize = true;
            LblCpf.Location = new Point(43, 146);
            LblCpf.Name = "LblCpf";
            LblCpf.Size = new Size(28, 15);
            LblCpf.TabIndex = 8;
            LblCpf.Text = "CPF";
            // 
            // LblDataNascimento
            // 
            LblDataNascimento.AutoSize = true;
            LblDataNascimento.Location = new Point(43, 191);
            LblDataNascimento.Name = "LblDataNascimento";
            LblDataNascimento.Size = new Size(114, 15);
            LblDataNascimento.TabIndex = 9;
            LblDataNascimento.Text = "Data de Nascimento";
            // 
            // LblSalario
            // 
            LblSalario.AutoSize = true;
            LblSalario.Location = new Point(47, 235);
            LblSalario.Name = "LblSalario";
            LblSalario.Size = new Size(42, 15);
            LblSalario.TabIndex = 10;
            LblSalario.Text = "Salário";
            // 
            // BTNCorrentista2
            // 
            BTNCorrentista2.Location = new Point(102, 303);
            BTNCorrentista2.Name = "BTNCorrentista2";
            BTNCorrentista2.Size = new Size(75, 23);
            BTNCorrentista2.TabIndex = 11;
            BTNCorrentista2.Text = "VER 2";
            BTNCorrentista2.UseVisualStyleBackColor = true;
            BTNCorrentista2.Click += BTNCorrentista2_Click;
            // 
            // BTNCorrentista1
            // 
            BTNCorrentista1.Location = new Point(353, 307);
            BTNCorrentista1.Name = "BTNCorrentista1";
            BTNCorrentista1.Size = new Size(75, 23);
            BTNCorrentista1.TabIndex = 12;
            BTNCorrentista1.Text = "VER 1";
            BTNCorrentista1.UseVisualStyleBackColor = true;
            BTNCorrentista1.Click += BTNCorrentista1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 346);
            Controls.Add(BTNCorrentista1);
            Controls.Add(BTNCorrentista2);
            Controls.Add(LblSalario);
            Controls.Add(LblDataNascimento);
            Controls.Add(LblCpf);
            Controls.Add(LblNome);
            Controls.Add(LblId);
            Controls.Add(BtnCadastrar);
            Controls.Add(DTNascimento);
            Controls.Add(TxtSalario);
            Controls.Add(TxtCPF);
            Controls.Add(TxtNome);
            Controls.Add(TxtID);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtID;
        private TextBox TxtNome;
        private TextBox TxtCPF;
        private TextBox TxtSalario;
        private DateTimePicker DTNascimento;
        private Button BtnCadastrar;
        private Label LblId;
        private Label LblNome;
        private Label LblCpf;
        private Label LblDataNascimento;
        private Label LblSalario;
        private Button BTNCorrentista2;
        private Button BTNCorrentista1;
    }
}