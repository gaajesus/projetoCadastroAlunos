namespace PerfilAluno
{
	partial class cadastro_alunos
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
            this.lblMatricula = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTurma = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.rdbMasc = new System.Windows.Forms.RadioButton();
            this.rdbFem = new System.Windows.Forms.RadioButton();
            this.chkTrab = new System.Windows.Forms.CheckBox();
            this.chkEsp = new System.Windows.Forms.CheckBox();
            this.cmbTurma = new System.Windows.Forms.ComboBox();
            this.dtpDatanascimento = new System.Windows.Forms.DateTimePicker();
            this.mskDatacancelamento = new System.Windows.Forms.MaskedTextBox();
            this.rdbInfo = new System.Windows.Forms.RadioButton();
            this.rdbMec = new System.Windows.Forms.RadioButton();
            this.rdbEletro = new System.Windows.Forms.RadioButton();
            this.gpbCurso = new System.Windows.Forms.GroupBox();
            this.rdbMedio = new System.Windows.Forms.RadioButton();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnValidar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gpbCurso.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(12, 19);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(52, 13);
            this.lblMatricula.TabIndex = 0;
            this.lblMatricula.Text = "Matrícula";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(15, 36);
            this.txtMatricula.MaxLength = 7;
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtMatricula.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 108);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(237, 20);
            this.txtNome.TabIndex = 2;
            this.txtNome.Validating += new System.ComponentModel.CancelEventHandler(this.txtNome_Validating);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 76);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(80, 13);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome do Aluno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data Nascimento";
            // 
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.Location = new System.Drawing.Point(215, 19);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(37, 13);
            this.lblTurma.TabIndex = 5;
            this.lblTurma.Text = "Turma";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data Cancelamento ";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(12, 192);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 7;
            this.lblSexo.Text = "Sexo";
            // 
            // rdbMasc
            // 
            this.rdbMasc.AutoSize = true;
            this.rdbMasc.Checked = true;
            this.rdbMasc.Location = new System.Drawing.Point(15, 211);
            this.rdbMasc.Name = "rdbMasc";
            this.rdbMasc.Size = new System.Drawing.Size(73, 17);
            this.rdbMasc.TabIndex = 8;
            this.rdbMasc.TabStop = true;
            this.rdbMasc.Text = "&Masculino";
            this.rdbMasc.UseVisualStyleBackColor = true;
            // 
            // rdbFem
            // 
            this.rdbFem.AutoSize = true;
            this.rdbFem.Location = new System.Drawing.Point(15, 234);
            this.rdbFem.Name = "rdbFem";
            this.rdbFem.Size = new System.Drawing.Size(67, 17);
            this.rdbFem.TabIndex = 9;
            this.rdbFem.Text = "&Feminino";
            this.rdbFem.UseVisualStyleBackColor = true;
            // 
            // chkTrab
            // 
            this.chkTrab.AutoSize = true;
            this.chkTrab.Location = new System.Drawing.Point(15, 272);
            this.chkTrab.Name = "chkTrab";
            this.chkTrab.Size = new System.Drawing.Size(77, 17);
            this.chkTrab.TabIndex = 10;
            this.chkTrab.Text = "&Trabalha ?";
            this.chkTrab.UseVisualStyleBackColor = true;
            // 
            // chkEsp
            // 
            this.chkEsp.AutoSize = true;
            this.chkEsp.Location = new System.Drawing.Point(15, 295);
            this.chkEsp.Name = "chkEsp";
            this.chkEsp.Size = new System.Drawing.Size(103, 17);
            this.chkEsp.TabIndex = 11;
            this.chkEsp.Text = "&Cursa Espanol ?";
            this.chkEsp.UseVisualStyleBackColor = true;
            // 
            // cmbTurma
            // 
            this.cmbTurma.DropDownHeight = 200;
            this.cmbTurma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurma.FormattingEnabled = true;
            this.cmbTurma.IntegralHeight = false;
            this.cmbTurma.Items.AddRange(new object[] {
            "71A",
            "72A",
            "73A",
            "51A",
            "52A",
            "53A",
            "81A",
            "82A",
            "81B"});
            this.cmbTurma.Location = new System.Drawing.Point(208, 35);
            this.cmbTurma.Name = "cmbTurma";
            this.cmbTurma.Size = new System.Drawing.Size(76, 21);
            this.cmbTurma.TabIndex = 12;
            this.cmbTurma.SelectedValueChanged += new System.EventHandler(this.cmbTurma_SelectedValueChanged);
            // 
            // dtpDatanascimento
            // 
            this.dtpDatanascimento.CustomFormat = "dd/MM";
            this.dtpDatanascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatanascimento.Location = new System.Drawing.Point(20, 167);
            this.dtpDatanascimento.Name = "dtpDatanascimento";
            this.dtpDatanascimento.Size = new System.Drawing.Size(120, 20);
            this.dtpDatanascimento.TabIndex = 13;
            // 
            // mskDatacancelamento
            // 
            this.mskDatacancelamento.Location = new System.Drawing.Point(197, 166);
            this.mskDatacancelamento.Mask = "00/00/0000";
            this.mskDatacancelamento.Name = "mskDatacancelamento";
            this.mskDatacancelamento.Size = new System.Drawing.Size(100, 20);
            this.mskDatacancelamento.TabIndex = 15;
            this.mskDatacancelamento.ValidatingType = typeof(System.DateTime);
            // 
            // rdbInfo
            // 
            this.rdbInfo.AutoSize = true;
            this.rdbInfo.Location = new System.Drawing.Point(6, 39);
            this.rdbInfo.Name = "rdbInfo";
            this.rdbInfo.Size = new System.Drawing.Size(77, 17);
            this.rdbInfo.TabIndex = 16;
            this.rdbInfo.Text = "&Informática";
            this.rdbInfo.UseVisualStyleBackColor = true;
            // 
            // rdbMec
            // 
            this.rdbMec.AutoSize = true;
            this.rdbMec.Location = new System.Drawing.Point(6, 59);
            this.rdbMec.Name = "rdbMec";
            this.rdbMec.Size = new System.Drawing.Size(72, 17);
            this.rdbMec.TabIndex = 17;
            this.rdbMec.Text = "&Mecanica";
            this.rdbMec.UseVisualStyleBackColor = true;
            // 
            // rdbEletro
            // 
            this.rdbEletro.AutoSize = true;
            this.rdbEletro.Checked = true;
            this.rdbEletro.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.rdbEletro.Location = new System.Drawing.Point(6, 19);
            this.rdbEletro.Name = "rdbEletro";
            this.rdbEletro.Size = new System.Drawing.Size(72, 17);
            this.rdbEletro.TabIndex = 18;
            this.rdbEletro.TabStop = true;
            this.rdbEletro.Text = "&Eletrônica";
            this.rdbEletro.UseVisualStyleBackColor = true;
            // 
            // gpbCurso
            // 
            this.gpbCurso.Controls.Add(this.rdbMedio);
            this.gpbCurso.Controls.Add(this.rdbMec);
            this.gpbCurso.Controls.Add(this.rdbEletro);
            this.gpbCurso.Controls.Add(this.rdbInfo);
            this.gpbCurso.Location = new System.Drawing.Point(176, 211);
            this.gpbCurso.Name = "gpbCurso";
            this.gpbCurso.Size = new System.Drawing.Size(149, 101);
            this.gpbCurso.TabIndex = 19;
            this.gpbCurso.TabStop = false;
            this.gpbCurso.Text = "Curso";
            // 
            // rdbMedio
            // 
            this.rdbMedio.AutoSize = true;
            this.rdbMedio.Location = new System.Drawing.Point(6, 78);
            this.rdbMedio.Name = "rdbMedio";
            this.rdbMedio.Size = new System.Drawing.Size(89, 17);
            this.rdbMedio.TabIndex = 19;
            this.rdbMedio.Text = "&Ensino Médio";
            this.rdbMedio.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(14, 329);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 20;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(141, 329);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(75, 23);
            this.btnValidar.TabIndex = 21;
            this.btnValidar.Text = "&Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(268, 329);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 22;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // cadastro_alunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(356, 356);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.gpbCurso);
            this.Controls.Add(this.mskDatacancelamento);
            this.Controls.Add(this.dtpDatanascimento);
            this.Controls.Add(this.cmbTurma);
            this.Controls.Add(this.chkEsp);
            this.Controls.Add(this.chkTrab);
            this.Controls.Add(this.rdbFem);
            this.Controls.Add(this.rdbMasc);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTurma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblMatricula);
            this.Name = "cadastro_alunos";
            this.Text = "Cadastro de Alunos";
            this.Load += new System.EventHandler(this.cadastro_alunos_Load);
            this.gpbCurso.ResumeLayout(false);
            this.gpbCurso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblMatricula;
		private System.Windows.Forms.TextBox txtMatricula;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.Label lblNome;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblTurma;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblSexo;
		private System.Windows.Forms.RadioButton rdbMasc;
		private System.Windows.Forms.RadioButton rdbFem;
		private System.Windows.Forms.CheckBox chkTrab;
		private System.Windows.Forms.CheckBox chkEsp;
		private System.Windows.Forms.ComboBox cmbTurma;
		private System.Windows.Forms.DateTimePicker dtpDatanascimento;
        private System.Windows.Forms.MaskedTextBox mskDatacancelamento;
        private System.Windows.Forms.RadioButton rdbInfo;
        private System.Windows.Forms.RadioButton rdbMec;
        private System.Windows.Forms.RadioButton rdbEletro;
        private System.Windows.Forms.GroupBox gpbCurso;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.RadioButton rdbMedio;
    }
}

