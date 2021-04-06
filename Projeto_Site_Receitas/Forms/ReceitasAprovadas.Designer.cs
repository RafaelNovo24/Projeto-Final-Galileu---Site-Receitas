
namespace Projeto_Site_Receitas.Forms
{
    partial class ReceitasAprovadas
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
            this.button_Atualizar = new System.Windows.Forms.Button();
            this.button_Editar = new System.Windows.Forms.Button();
            this.button_Pesquisar = new System.Windows.Forms.Button();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.textBox_Estado = new System.Windows.Forms.TextBox();
            this.comboBox_ID = new System.Windows.Forms.ComboBox();
            this.lbl_Identificacao = new System.Windows.Forms.Label();
            this.textBox_Nome = new System.Windows.Forms.TextBox();
            this.textBox_Data = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_Rating = new System.Windows.Forms.TextBox();
            this.comboBox_Duracao = new System.Windows.Forms.ComboBox();
            this.comboBox_Dificuldade = new System.Windows.Forms.ComboBox();
            this.comboBox_Categoria = new System.Windows.Forms.ComboBox();
            this.comboBox_Porcao = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_Dificuldade = new System.Windows.Forms.Label();
            this.lbl_Categoria = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_Porcao = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox_listaIngredientes = new System.Windows.Forms.ListBox();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.groupBox_Preparacao = new System.Windows.Forms.GroupBox();
            this.textBox_Prep = new System.Windows.Forms.TextBox();
            this.button_Comentarios = new System.Windows.Forms.Button();
            this.label_comentarios = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.button_AtualizarReceita = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox_Preparacao.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Atualizar
            // 
            this.button_Atualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Atualizar.Location = new System.Drawing.Point(21, 529);
            this.button_Atualizar.Name = "button_Atualizar";
            this.button_Atualizar.Size = new System.Drawing.Size(179, 46);
            this.button_Atualizar.TabIndex = 22;
            this.button_Atualizar.Text = "Atualizar";
            this.button_Atualizar.UseVisualStyleBackColor = false;
            this.button_Atualizar.Click += new System.EventHandler(this.button_Atualizar_Click);
            // 
            // button_Editar
            // 
            this.button_Editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Editar.Location = new System.Drawing.Point(206, 529);
            this.button_Editar.Name = "button_Editar";
            this.button_Editar.Size = new System.Drawing.Size(187, 46);
            this.button_Editar.TabIndex = 20;
            this.button_Editar.Text = "Editar";
            this.button_Editar.UseVisualStyleBackColor = false;
            this.button_Editar.Click += new System.EventHandler(this.button_Editar_Click);
            // 
            // button_Pesquisar
            // 
            this.button_Pesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Pesquisar.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Pesquisar.ForeColor = System.Drawing.Color.White;
            this.button_Pesquisar.Location = new System.Drawing.Point(932, 17);
            this.button_Pesquisar.Name = "button_Pesquisar";
            this.button_Pesquisar.Size = new System.Drawing.Size(231, 48);
            this.button_Pesquisar.TabIndex = 54;
            this.button_Pesquisar.Text = "Pesquisar";
            this.button_Pesquisar.UseVisualStyleBackColor = false;
            this.button_Pesquisar.Click += new System.EventHandler(this.button_Pesquisar_Click);
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estado.ForeColor = System.Drawing.Color.White;
            this.lbl_estado.Location = new System.Drawing.Point(962, 90);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(66, 24);
            this.lbl_estado.TabIndex = 32;
            this.lbl_estado.Text = "Estado";
            // 
            // textBox_Estado
            // 
            this.textBox_Estado.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox_Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Estado.Location = new System.Drawing.Point(1034, 88);
            this.textBox_Estado.Multiline = true;
            this.textBox_Estado.Name = "textBox_Estado";
            this.textBox_Estado.ReadOnly = true;
            this.textBox_Estado.Size = new System.Drawing.Size(201, 31);
            this.textBox_Estado.TabIndex = 45;
            this.textBox_Estado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox_ID
            // 
            this.comboBox_ID.AllowDrop = true;
            this.comboBox_ID.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_ID.FormattingEnabled = true;
            this.comboBox_ID.Location = new System.Drawing.Point(137, 26);
            this.comboBox_ID.MaxDropDownItems = 100;
            this.comboBox_ID.Name = "comboBox_ID";
            this.comboBox_ID.Size = new System.Drawing.Size(756, 28);
            this.comboBox_ID.TabIndex = 53;
            // 
            // lbl_Identificacao
            // 
            this.lbl_Identificacao.AutoSize = true;
            this.lbl_Identificacao.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Identificacao.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_Identificacao.Location = new System.Drawing.Point(12, 26);
            this.lbl_Identificacao.Name = "lbl_Identificacao";
            this.lbl_Identificacao.Size = new System.Drawing.Size(119, 24);
            this.lbl_Identificacao.TabIndex = 52;
            this.lbl_Identificacao.Text = "Identificação";
            // 
            // textBox_Nome
            // 
            this.textBox_Nome.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Nome.Location = new System.Drawing.Point(75, 90);
            this.textBox_Nome.Multiline = true;
            this.textBox_Nome.Name = "textBox_Nome";
            this.textBox_Nome.Size = new System.Drawing.Size(813, 37);
            this.textBox_Nome.TabIndex = 47;
            // 
            // textBox_Data
            // 
            this.textBox_Data.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox_Data.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Data.Location = new System.Drawing.Point(573, 721);
            this.textBox_Data.Multiline = true;
            this.textBox_Data.Name = "textBox_Data";
            this.textBox_Data.ReadOnly = true;
            this.textBox_Data.Size = new System.Drawing.Size(187, 31);
            this.textBox_Data.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(493, 719);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 24);
            this.label1.TabIndex = 49;
            this.label1.Text = "Data";
            // 
            // txtBox_Rating
            // 
            this.txtBox_Rating.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtBox_Rating.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Rating.Location = new System.Drawing.Point(573, 666);
            this.txtBox_Rating.Multiline = true;
            this.txtBox_Rating.Name = "txtBox_Rating";
            this.txtBox_Rating.ReadOnly = true;
            this.txtBox_Rating.Size = new System.Drawing.Size(187, 31);
            this.txtBox_Rating.TabIndex = 48;
            // 
            // comboBox_Duracao
            // 
            this.comboBox_Duracao.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Duracao.FormattingEnabled = true;
            this.comboBox_Duracao.Location = new System.Drawing.Point(894, 721);
            this.comboBox_Duracao.Name = "comboBox_Duracao";
            this.comboBox_Duracao.Size = new System.Drawing.Size(361, 28);
            this.comboBox_Duracao.TabIndex = 44;
            // 
            // comboBox_Dificuldade
            // 
            this.comboBox_Dificuldade.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Dificuldade.FormattingEnabled = true;
            this.comboBox_Dificuldade.Location = new System.Drawing.Point(894, 666);
            this.comboBox_Dificuldade.Name = "comboBox_Dificuldade";
            this.comboBox_Dificuldade.Size = new System.Drawing.Size(361, 28);
            this.comboBox_Dificuldade.TabIndex = 43;
            // 
            // comboBox_Categoria
            // 
            this.comboBox_Categoria.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Categoria.FormattingEnabled = true;
            this.comboBox_Categoria.Location = new System.Drawing.Point(894, 610);
            this.comboBox_Categoria.Name = "comboBox_Categoria";
            this.comboBox_Categoria.Size = new System.Drawing.Size(361, 28);
            this.comboBox_Categoria.TabIndex = 42;
            // 
            // comboBox_Porcao
            // 
            this.comboBox_Porcao.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Porcao.FormattingEnabled = true;
            this.comboBox_Porcao.Location = new System.Drawing.Point(573, 614);
            this.comboBox_Porcao.Name = "comboBox_Porcao";
            this.comboBox_Porcao.Size = new System.Drawing.Size(187, 28);
            this.comboBox_Porcao.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(802, 721);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 24);
            this.label8.TabIndex = 40;
            this.label8.Text = "Duração";
            // 
            // lbl_Dificuldade
            // 
            this.lbl_Dificuldade.AutoSize = true;
            this.lbl_Dificuldade.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dificuldade.ForeColor = System.Drawing.Color.White;
            this.lbl_Dificuldade.Location = new System.Drawing.Point(777, 670);
            this.lbl_Dificuldade.Name = "lbl_Dificuldade";
            this.lbl_Dificuldade.Size = new System.Drawing.Size(101, 24);
            this.lbl_Dificuldade.TabIndex = 39;
            this.lbl_Dificuldade.Text = "Dificuldade";
            // 
            // lbl_Categoria
            // 
            this.lbl_Categoria.AutoSize = true;
            this.lbl_Categoria.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Categoria.ForeColor = System.Drawing.Color.White;
            this.lbl_Categoria.Location = new System.Drawing.Point(791, 610);
            this.lbl_Categoria.Name = "lbl_Categoria";
            this.lbl_Categoria.Size = new System.Drawing.Size(87, 24);
            this.lbl_Categoria.TabIndex = 38;
            this.lbl_Categoria.Text = "Categoria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(493, 664);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 24);
            this.label5.TabIndex = 37;
            this.label5.Text = "Rating";
            // 
            // lbl_Porcao
            // 
            this.lbl_Porcao.AutoSize = true;
            this.lbl_Porcao.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Porcao.ForeColor = System.Drawing.Color.White;
            this.lbl_Porcao.Location = new System.Drawing.Point(493, 614);
            this.lbl_Porcao.Name = "lbl_Porcao";
            this.lbl_Porcao.Size = new System.Drawing.Size(65, 24);
            this.lbl_Porcao.TabIndex = 35;
            this.lbl_Porcao.Text = "Porção";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_Atualizar);
            this.groupBox2.Controls.Add(this.listBox_listaIngredientes);
            this.groupBox2.Controls.Add(this.button_Editar);
            this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(37, 614);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 586);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingredientes";
            // 
            // listBox_listaIngredientes
            // 
            this.listBox_listaIngredientes.FormattingEnabled = true;
            this.listBox_listaIngredientes.ItemHeight = 24;
            this.listBox_listaIngredientes.Location = new System.Drawing.Point(21, 34);
            this.listBox_listaIngredientes.Name = "listBox_listaIngredientes";
            this.listBox_listaIngredientes.Size = new System.Drawing.Size(372, 460);
            this.listBox_listaIngredientes.TabIndex = 21;
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nome.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_Nome.Location = new System.Drawing.Point(12, 90);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(57, 24);
            this.lbl_Nome.TabIndex = 31;
            this.lbl_Nome.Text = "Nome";
            // 
            // groupBox_Preparacao
            // 
            this.groupBox_Preparacao.Controls.Add(this.textBox_Prep);
            this.groupBox_Preparacao.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Preparacao.ForeColor = System.Drawing.Color.White;
            this.groupBox_Preparacao.Location = new System.Drawing.Point(37, 147);
            this.groupBox_Preparacao.Name = "groupBox_Preparacao";
            this.groupBox_Preparacao.Size = new System.Drawing.Size(1183, 428);
            this.groupBox_Preparacao.TabIndex = 33;
            this.groupBox_Preparacao.TabStop = false;
            this.groupBox_Preparacao.Text = "Preparação";
            // 
            // textBox_Prep
            // 
            this.textBox_Prep.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Prep.Location = new System.Drawing.Point(6, 34);
            this.textBox_Prep.Multiline = true;
            this.textBox_Prep.Name = "textBox_Prep";
            this.textBox_Prep.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Prep.Size = new System.Drawing.Size(1171, 386);
            this.textBox_Prep.TabIndex = 17;
            // 
            // button_Comentarios
            // 
            this.button_Comentarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Comentarios.Location = new System.Drawing.Point(451, 40);
            this.button_Comentarios.Name = "button_Comentarios";
            this.button_Comentarios.Size = new System.Drawing.Size(230, 46);
            this.button_Comentarios.TabIndex = 20;
            this.button_Comentarios.Text = "Ver";
            this.button_Comentarios.UseVisualStyleBackColor = false;
            this.button_Comentarios.Click += new System.EventHandler(this.button_Comentarios_Click);
            // 
            // label_comentarios
            // 
            this.label_comentarios.AutoSize = true;
            this.label_comentarios.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_comentarios.ForeColor = System.Drawing.Color.White;
            this.label_comentarios.Location = new System.Drawing.Point(34, 60);
            this.label_comentarios.Name = "label_comentarios";
            this.label_comentarios.Size = new System.Drawing.Size(341, 24);
            this.label_comentarios.TabIndex = 26;
            this.label_comentarios.Text = "Veja todos os comentários desta receita.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Comentarios);
            this.groupBox1.Controls.Add(this.label_comentarios);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(485, 821);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 117);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comentários";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRemover);
            this.groupBox3.Controls.Add(this.button_AtualizarReceita);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(485, 991);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(758, 174);
            this.groupBox3.TabIndex = 56;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Atualizar Receita";
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRemover.Location = new System.Drawing.Point(467, 105);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(230, 46);
            this.btnRemover.TabIndex = 27;
            this.btnRemover.Text = "Eliminar";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // button_AtualizarReceita
            // 
            this.button_AtualizarReceita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_AtualizarReceita.Location = new System.Drawing.Point(45, 105);
            this.button_AtualizarReceita.Name = "button_AtualizarReceita";
            this.button_AtualizarReceita.Size = new System.Drawing.Size(230, 46);
            this.button_AtualizarReceita.TabIndex = 20;
            this.button_AtualizarReceita.Text = "Atualizar";
            this.button_AtualizarReceita.UseVisualStyleBackColor = false;
            this.button_AtualizarReceita.Click += new System.EventHandler(this.button_AtualizarReceita_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "Atualize os dados da receita se necessário.";
            // 
            // ReceitasAprovadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1262, 662);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Pesquisar);
            this.Controls.Add(this.lbl_estado);
            this.Controls.Add(this.textBox_Estado);
            this.Controls.Add(this.comboBox_ID);
            this.Controls.Add(this.lbl_Identificacao);
            this.Controls.Add(this.textBox_Nome);
            this.Controls.Add(this.textBox_Data);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_Rating);
            this.Controls.Add(this.comboBox_Duracao);
            this.Controls.Add(this.comboBox_Dificuldade);
            this.Controls.Add(this.comboBox_Categoria);
            this.Controls.Add(this.comboBox_Porcao);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_Dificuldade);
            this.Controls.Add(this.lbl_Categoria);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_Porcao);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbl_Nome);
            this.Controls.Add(this.groupBox_Preparacao);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ReceitasAprovadas";
            this.Text = "ReceitasAprovadas";
            this.Load += new System.EventHandler(this.ReceitasAprovadas_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox_Preparacao.ResumeLayout(false);
            this.groupBox_Preparacao.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Atualizar;
        private System.Windows.Forms.Button button_Editar;
        private System.Windows.Forms.Button button_Pesquisar;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.TextBox textBox_Estado;
        private System.Windows.Forms.ComboBox comboBox_ID;
        private System.Windows.Forms.Label lbl_Identificacao;
        private System.Windows.Forms.TextBox textBox_Nome;
        private System.Windows.Forms.TextBox textBox_Data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_Rating;
        private System.Windows.Forms.ComboBox comboBox_Duracao;
        private System.Windows.Forms.ComboBox comboBox_Dificuldade;
        private System.Windows.Forms.ComboBox comboBox_Categoria;
        private System.Windows.Forms.ComboBox comboBox_Porcao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_Dificuldade;
        private System.Windows.Forms.Label lbl_Categoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_Porcao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox_listaIngredientes;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.GroupBox groupBox_Preparacao;
        private System.Windows.Forms.TextBox textBox_Prep;
        private System.Windows.Forms.Button button_Comentarios;
        private System.Windows.Forms.Label label_comentarios;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_AtualizarReceita;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRemover;
    }
}