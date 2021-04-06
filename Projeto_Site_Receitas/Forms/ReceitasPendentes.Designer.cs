
namespace Projeto_Site_Receitas.Forms
{
    partial class ReceitasPendentes
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
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.groupBox_Preparacao = new System.Windows.Forms.GroupBox();
            this.textBox_Prep = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_Atualizar = new System.Windows.Forms.Button();
            this.listBox_listaIngredientes = new System.Windows.Forms.ListBox();
            this.button_Editar = new System.Windows.Forms.Button();
            this.lbl_Porcao = new System.Windows.Forms.Label();
            this.lbl_Categoria = new System.Windows.Forms.Label();
            this.lbl_Dificuldade = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox_AlterarEstado = new System.Windows.Forms.GroupBox();
            this.button_Rejeitar = new System.Windows.Forms.Button();
            this.button_Aprovar = new System.Windows.Forms.Button();
            this.lbl_InfoEstado = new System.Windows.Forms.Label();
            this.comboBox_Porcao = new System.Windows.Forms.ComboBox();
            this.comboBox_Categoria = new System.Windows.Forms.ComboBox();
            this.comboBox_Dificuldade = new System.Windows.Forms.ComboBox();
            this.comboBox_Duracao = new System.Windows.Forms.ComboBox();
            this.textBox_Estado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Data = new System.Windows.Forms.TextBox();
            this.textBox_Nome = new System.Windows.Forms.TextBox();
            this.lbl_Identificacao = new System.Windows.Forms.Label();
            this.comboBox_ID = new System.Windows.Forms.ComboBox();
            this.button_Pesquisar = new System.Windows.Forms.Button();
            this.groupBox_Preparacao.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox_AlterarEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nome.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_Nome.Location = new System.Drawing.Point(12, 78);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(57, 24);
            this.lbl_Nome.TabIndex = 0;
            this.lbl_Nome.Text = "Nome";
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estado.ForeColor = System.Drawing.Color.White;
            this.lbl_estado.Location = new System.Drawing.Point(956, 78);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(66, 24);
            this.lbl_estado.TabIndex = 1;
            this.lbl_estado.Text = "Estado";
            // 
            // groupBox_Preparacao
            // 
            this.groupBox_Preparacao.Controls.Add(this.textBox_Prep);
            this.groupBox_Preparacao.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Preparacao.ForeColor = System.Drawing.Color.White;
            this.groupBox_Preparacao.Location = new System.Drawing.Point(37, 129);
            this.groupBox_Preparacao.Name = "groupBox_Preparacao";
            this.groupBox_Preparacao.Size = new System.Drawing.Size(1218, 380);
            this.groupBox_Preparacao.TabIndex = 3;
            this.groupBox_Preparacao.TabStop = false;
            this.groupBox_Preparacao.Text = "Preparação";
            // 
            // textBox_Prep
            // 
            this.textBox_Prep.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Prep.Location = new System.Drawing.Point(7, 33);
            this.textBox_Prep.Multiline = true;
            this.textBox_Prep.Name = "textBox_Prep";
            this.textBox_Prep.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Prep.Size = new System.Drawing.Size(1205, 340);
            this.textBox_Prep.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_Atualizar);
            this.groupBox2.Controls.Add(this.listBox_listaIngredientes);
            this.groupBox2.Controls.Add(this.button_Editar);
            this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(37, 544);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 530);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingredientes";
            // 
            // button_Atualizar
            // 
            this.button_Atualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Atualizar.Location = new System.Drawing.Point(21, 463);
            this.button_Atualizar.Name = "button_Atualizar";
            this.button_Atualizar.Size = new System.Drawing.Size(179, 41);
            this.button_Atualizar.TabIndex = 22;
            this.button_Atualizar.Text = "Atualizar";
            this.button_Atualizar.UseVisualStyleBackColor = false;
            this.button_Atualizar.Click += new System.EventHandler(this.button_Atualizar_Click);
            // 
            // listBox_listaIngredientes
            // 
            this.listBox_listaIngredientes.FormattingEnabled = true;
            this.listBox_listaIngredientes.ItemHeight = 24;
            this.listBox_listaIngredientes.Location = new System.Drawing.Point(21, 30);
            this.listBox_listaIngredientes.Name = "listBox_listaIngredientes";
            this.listBox_listaIngredientes.Size = new System.Drawing.Size(372, 412);
            this.listBox_listaIngredientes.TabIndex = 21;
            // 
            // button_Editar
            // 
            this.button_Editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Editar.Location = new System.Drawing.Point(206, 463);
            this.button_Editar.Name = "button_Editar";
            this.button_Editar.Size = new System.Drawing.Size(187, 41);
            this.button_Editar.TabIndex = 20;
            this.button_Editar.Text = "Editar";
            this.button_Editar.UseVisualStyleBackColor = false;
            this.button_Editar.Click += new System.EventHandler(this.button_Editar_Click);
            // 
            // lbl_Porcao
            // 
            this.lbl_Porcao.AutoSize = true;
            this.lbl_Porcao.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Porcao.ForeColor = System.Drawing.Color.White;
            this.lbl_Porcao.Location = new System.Drawing.Point(493, 544);
            this.lbl_Porcao.Name = "lbl_Porcao";
            this.lbl_Porcao.Size = new System.Drawing.Size(65, 24);
            this.lbl_Porcao.TabIndex = 5;
            this.lbl_Porcao.Text = "Porção";
            // 
            // lbl_Categoria
            // 
            this.lbl_Categoria.AutoSize = true;
            this.lbl_Categoria.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Categoria.ForeColor = System.Drawing.Color.White;
            this.lbl_Categoria.Location = new System.Drawing.Point(790, 542);
            this.lbl_Categoria.Name = "lbl_Categoria";
            this.lbl_Categoria.Size = new System.Drawing.Size(87, 24);
            this.lbl_Categoria.TabIndex = 7;
            this.lbl_Categoria.Text = "Categoria";
            // 
            // lbl_Dificuldade
            // 
            this.lbl_Dificuldade.AutoSize = true;
            this.lbl_Dificuldade.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dificuldade.ForeColor = System.Drawing.Color.White;
            this.lbl_Dificuldade.Location = new System.Drawing.Point(774, 597);
            this.lbl_Dificuldade.Name = "lbl_Dificuldade";
            this.lbl_Dificuldade.Size = new System.Drawing.Size(101, 24);
            this.lbl_Dificuldade.TabIndex = 8;
            this.lbl_Dificuldade.Text = "Dificuldade";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(802, 639);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 24);
            this.label8.TabIndex = 9;
            this.label8.Text = "Duração";
            // 
            // groupBox_AlterarEstado
            // 
            this.groupBox_AlterarEstado.Controls.Add(this.button_Rejeitar);
            this.groupBox_AlterarEstado.Controls.Add(this.button_Aprovar);
            this.groupBox_AlterarEstado.Controls.Add(this.lbl_InfoEstado);
            this.groupBox_AlterarEstado.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_AlterarEstado.ForeColor = System.Drawing.Color.White;
            this.groupBox_AlterarEstado.Location = new System.Drawing.Point(497, 749);
            this.groupBox_AlterarEstado.Name = "groupBox_AlterarEstado";
            this.groupBox_AlterarEstado.Size = new System.Drawing.Size(758, 148);
            this.groupBox_AlterarEstado.TabIndex = 6;
            this.groupBox_AlterarEstado.TabStop = false;
            this.groupBox_AlterarEstado.Text = "Alterar estado da receita";
            // 
            // button_Rejeitar
            // 
            this.button_Rejeitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Rejeitar.Location = new System.Drawing.Point(418, 92);
            this.button_Rejeitar.Name = "button_Rejeitar";
            this.button_Rejeitar.Size = new System.Drawing.Size(320, 41);
            this.button_Rejeitar.TabIndex = 19;
            this.button_Rejeitar.Text = "Rejeitar";
            this.button_Rejeitar.UseVisualStyleBackColor = false;
            this.button_Rejeitar.Click += new System.EventHandler(this.button_Rejeitar_Click);
            // 
            // button_Aprovar
            // 
            this.button_Aprovar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Aprovar.Location = new System.Drawing.Point(35, 92);
            this.button_Aprovar.Name = "button_Aprovar";
            this.button_Aprovar.Size = new System.Drawing.Size(324, 41);
            this.button_Aprovar.TabIndex = 18;
            this.button_Aprovar.Text = "Aprovar";
            this.button_Aprovar.UseVisualStyleBackColor = false;
            this.button_Aprovar.Click += new System.EventHandler(this.button_Aprovar_Click);
            // 
            // lbl_InfoEstado
            // 
            this.lbl_InfoEstado.AutoSize = true;
            this.lbl_InfoEstado.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InfoEstado.Location = new System.Drawing.Point(30, 50);
            this.lbl_InfoEstado.Name = "lbl_InfoEstado";
            this.lbl_InfoEstado.Size = new System.Drawing.Size(447, 19);
            this.lbl_InfoEstado.TabIndex = 17;
            this.lbl_InfoEstado.Text = "Verifique toda a informação da receita antes de tomar uma decisão.";
            // 
            // comboBox_Porcao
            // 
            this.comboBox_Porcao.FormattingEnabled = true;
            this.comboBox_Porcao.Location = new System.Drawing.Point(573, 544);
            this.comboBox_Porcao.Name = "comboBox_Porcao";
            this.comboBox_Porcao.Size = new System.Drawing.Size(187, 28);
            this.comboBox_Porcao.TabIndex = 10;
            // 
            // comboBox_Categoria
            // 
            this.comboBox_Categoria.FormattingEnabled = true;
            this.comboBox_Categoria.Location = new System.Drawing.Point(894, 540);
            this.comboBox_Categoria.Name = "comboBox_Categoria";
            this.comboBox_Categoria.Size = new System.Drawing.Size(361, 28);
            this.comboBox_Categoria.TabIndex = 11;
            // 
            // comboBox_Dificuldade
            // 
            this.comboBox_Dificuldade.FormattingEnabled = true;
            this.comboBox_Dificuldade.Location = new System.Drawing.Point(894, 590);
            this.comboBox_Dificuldade.Name = "comboBox_Dificuldade";
            this.comboBox_Dificuldade.Size = new System.Drawing.Size(361, 28);
            this.comboBox_Dificuldade.TabIndex = 12;
            // 
            // comboBox_Duracao
            // 
            this.comboBox_Duracao.FormattingEnabled = true;
            this.comboBox_Duracao.Location = new System.Drawing.Point(894, 639);
            this.comboBox_Duracao.Name = "comboBox_Duracao";
            this.comboBox_Duracao.Size = new System.Drawing.Size(361, 28);
            this.comboBox_Duracao.TabIndex = 13;
            // 
            // textBox_Estado
            // 
            this.textBox_Estado.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox_Estado.Location = new System.Drawing.Point(1034, 76);
            this.textBox_Estado.Name = "textBox_Estado";
            this.textBox_Estado.ReadOnly = true;
            this.textBox_Estado.Size = new System.Drawing.Size(201, 28);
            this.textBox_Estado.TabIndex = 16;
            this.textBox_Estado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(510, 601);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Data";
            // 
            // textBox_Data
            // 
            this.textBox_Data.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox_Data.Location = new System.Drawing.Point(573, 597);
            this.textBox_Data.Name = "textBox_Data";
            this.textBox_Data.ReadOnly = true;
            this.textBox_Data.Size = new System.Drawing.Size(187, 28);
            this.textBox_Data.TabIndex = 25;
            // 
            // textBox_Nome
            // 
            this.textBox_Nome.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Nome.Location = new System.Drawing.Point(75, 76);
            this.textBox_Nome.Multiline = true;
            this.textBox_Nome.Name = "textBox_Nome";
            this.textBox_Nome.Size = new System.Drawing.Size(813, 30);
            this.textBox_Nome.TabIndex = 18;
            // 
            // lbl_Identificacao
            // 
            this.lbl_Identificacao.AutoSize = true;
            this.lbl_Identificacao.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Identificacao.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_Identificacao.Location = new System.Drawing.Point(12, 21);
            this.lbl_Identificacao.Name = "lbl_Identificacao";
            this.lbl_Identificacao.Size = new System.Drawing.Size(119, 24);
            this.lbl_Identificacao.TabIndex = 27;
            this.lbl_Identificacao.Text = "Identificação";
            // 
            // comboBox_ID
            // 
            this.comboBox_ID.AllowDrop = true;
            this.comboBox_ID.FormattingEnabled = true;
            this.comboBox_ID.Location = new System.Drawing.Point(137, 21);
            this.comboBox_ID.MaxDropDownItems = 100;
            this.comboBox_ID.Name = "comboBox_ID";
            this.comboBox_ID.Size = new System.Drawing.Size(756, 28);
            this.comboBox_ID.TabIndex = 28;
            // 
            // button_Pesquisar
            // 
            this.button_Pesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Pesquisar.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Pesquisar.ForeColor = System.Drawing.Color.White;
            this.button_Pesquisar.Location = new System.Drawing.Point(932, 13);
            this.button_Pesquisar.Name = "button_Pesquisar";
            this.button_Pesquisar.Size = new System.Drawing.Size(231, 43);
            this.button_Pesquisar.TabIndex = 30;
            this.button_Pesquisar.Text = "Pesquisar";
            this.button_Pesquisar.UseVisualStyleBackColor = false;
            this.button_Pesquisar.Click += new System.EventHandler(this.button_Pesquisar_Click);
            // 
            // ReceitasPendentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1337, 858);
            this.Controls.Add(this.button_Pesquisar);
            this.Controls.Add(this.lbl_estado);
            this.Controls.Add(this.textBox_Estado);
            this.Controls.Add(this.comboBox_ID);
            this.Controls.Add(this.lbl_Identificacao);
            this.Controls.Add(this.textBox_Nome);
            this.Controls.Add(this.textBox_Data);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Duracao);
            this.Controls.Add(this.comboBox_Dificuldade);
            this.Controls.Add(this.comboBox_Categoria);
            this.Controls.Add(this.comboBox_Porcao);
            this.Controls.Add(this.groupBox_AlterarEstado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_Dificuldade);
            this.Controls.Add(this.lbl_Categoria);
            this.Controls.Add(this.lbl_Porcao);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox_Preparacao);
            this.Controls.Add(this.lbl_Nome);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ReceitasPendentes";
            this.Text = "Receitas Pendentes";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.ReceitasPendentes_Load);
            this.groupBox_Preparacao.ResumeLayout(false);
            this.groupBox_Preparacao.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox_AlterarEstado.ResumeLayout(false);
            this.groupBox_AlterarEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.GroupBox groupBox_Preparacao;
        private System.Windows.Forms.TextBox textBox_Prep;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_Editar;
        private System.Windows.Forms.Label lbl_Porcao;
        private System.Windows.Forms.Label lbl_Categoria;
        private System.Windows.Forms.Label lbl_Dificuldade;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox_AlterarEstado;
        private System.Windows.Forms.Button button_Rejeitar;
        private System.Windows.Forms.Button button_Aprovar;
        private System.Windows.Forms.Label lbl_InfoEstado;
        private System.Windows.Forms.ComboBox comboBox_Porcao;
        private System.Windows.Forms.ComboBox comboBox_Categoria;
        private System.Windows.Forms.ComboBox comboBox_Dificuldade;
        private System.Windows.Forms.ComboBox comboBox_Duracao;
        private System.Windows.Forms.TextBox textBox_Estado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Data;
        private System.Windows.Forms.TextBox textBox_Nome;
        private System.Windows.Forms.Label lbl_Identificacao;
        private System.Windows.Forms.ComboBox comboBox_ID;
        private System.Windows.Forms.Button button_Pesquisar;
        private System.Windows.Forms.ListBox listBox_listaIngredientes;
        private System.Windows.Forms.Button button_Atualizar;
    }
}