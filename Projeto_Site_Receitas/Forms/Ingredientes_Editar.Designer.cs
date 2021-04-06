
namespace Projeto_Site_Receitas.Forms
{
    partial class Ingredientes_Editar
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
            this.lbl_Ingredientes = new System.Windows.Forms.Label();
            this.button_eliminar = new System.Windows.Forms.Button();
            this.groupBox_adicionarIngrientes = new System.Windows.Forms.GroupBox();
            this.textBox1_Quantidade = new System.Windows.Forms.TextBox();
            this.comboBox_Nome = new System.Windows.Forms.ComboBox();
            this.comboBox_UnidadeMedida = new System.Windows.Forms.ComboBox();
            this.label_unidadeMedida = new System.Windows.Forms.Label();
            this.lbl_quantidade = new System.Windows.Forms.Label();
            this.lbl_nomeIngrediente = new System.Windows.Forms.Label();
            this.button_adicionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_IngredientesReceita = new System.Windows.Forms.TextBox();
            this.listBox_Ingredientes = new System.Windows.Forms.ListBox();
            this.groupBox_adicionarIngrientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Ingredientes
            // 
            this.lbl_Ingredientes.AutoSize = true;
            this.lbl_Ingredientes.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ingredientes.Location = new System.Drawing.Point(12, 9);
            this.lbl_Ingredientes.Name = "lbl_Ingredientes";
            this.lbl_Ingredientes.Size = new System.Drawing.Size(160, 33);
            this.lbl_Ingredientes.TabIndex = 1;
            this.lbl_Ingredientes.Text = "Ingredientes";
            // 
            // button_eliminar
            // 
            this.button_eliminar.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_eliminar.Location = new System.Drawing.Point(12, 401);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(390, 36);
            this.button_eliminar.TabIndex = 3;
            this.button_eliminar.Text = "Eliminar";
            this.button_eliminar.UseVisualStyleBackColor = true;
            this.button_eliminar.Click += new System.EventHandler(this.button_eliminar_Click);
            // 
            // groupBox_adicionarIngrientes
            // 
            this.groupBox_adicionarIngrientes.Controls.Add(this.textBox1_Quantidade);
            this.groupBox_adicionarIngrientes.Controls.Add(this.comboBox_Nome);
            this.groupBox_adicionarIngrientes.Controls.Add(this.comboBox_UnidadeMedida);
            this.groupBox_adicionarIngrientes.Controls.Add(this.label_unidadeMedida);
            this.groupBox_adicionarIngrientes.Controls.Add(this.lbl_quantidade);
            this.groupBox_adicionarIngrientes.Controls.Add(this.lbl_nomeIngrediente);
            this.groupBox_adicionarIngrientes.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_adicionarIngrientes.Location = new System.Drawing.Point(426, 132);
            this.groupBox_adicionarIngrientes.Name = "groupBox_adicionarIngrientes";
            this.groupBox_adicionarIngrientes.Size = new System.Drawing.Size(526, 253);
            this.groupBox_adicionarIngrientes.TabIndex = 4;
            this.groupBox_adicionarIngrientes.TabStop = false;
            this.groupBox_adicionarIngrientes.Text = "Adicionar ingredientes";
            // 
            // textBox1_Quantidade
            // 
            this.textBox1_Quantidade.Location = new System.Drawing.Point(104, 118);
            this.textBox1_Quantidade.Name = "textBox1_Quantidade";
            this.textBox1_Quantidade.Size = new System.Drawing.Size(416, 35);
            this.textBox1_Quantidade.TabIndex = 5;
            // 
            // comboBox_Nome
            // 
            this.comboBox_Nome.DropDownHeight = 200;
            this.comboBox_Nome.FormattingEnabled = true;
            this.comboBox_Nome.IntegralHeight = false;
            this.comboBox_Nome.ItemHeight = 28;
            this.comboBox_Nome.Location = new System.Drawing.Point(61, 54);
            this.comboBox_Nome.Name = "comboBox_Nome";
            this.comboBox_Nome.Size = new System.Drawing.Size(459, 36);
            this.comboBox_Nome.TabIndex = 4;
            // 
            // comboBox_UnidadeMedida
            // 
            this.comboBox_UnidadeMedida.DropDownHeight = 200;
            this.comboBox_UnidadeMedida.FormattingEnabled = true;
            this.comboBox_UnidadeMedida.IntegralHeight = false;
            this.comboBox_UnidadeMedida.Location = new System.Drawing.Point(129, 184);
            this.comboBox_UnidadeMedida.Name = "comboBox_UnidadeMedida";
            this.comboBox_UnidadeMedida.Size = new System.Drawing.Size(391, 36);
            this.comboBox_UnidadeMedida.TabIndex = 3;
            // 
            // label_unidadeMedida
            // 
            this.label_unidadeMedida.AutoSize = true;
            this.label_unidadeMedida.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_unidadeMedida.Location = new System.Drawing.Point(2, 193);
            this.label_unidadeMedida.Name = "label_unidadeMedida";
            this.label_unidadeMedida.Size = new System.Drawing.Size(121, 20);
            this.label_unidadeMedida.TabIndex = 2;
            this.label_unidadeMedida.Text = "Unidade Medida";
            // 
            // lbl_quantidade
            // 
            this.lbl_quantidade.AutoSize = true;
            this.lbl_quantidade.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantidade.Location = new System.Drawing.Point(7, 129);
            this.lbl_quantidade.Name = "lbl_quantidade";
            this.lbl_quantidade.Size = new System.Drawing.Size(91, 20);
            this.lbl_quantidade.TabIndex = 1;
            this.lbl_quantidade.Text = "Quantidade";
            // 
            // lbl_nomeIngrediente
            // 
            this.lbl_nomeIngrediente.AutoSize = true;
            this.lbl_nomeIngrediente.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomeIngrediente.Location = new System.Drawing.Point(7, 60);
            this.lbl_nomeIngrediente.Name = "lbl_nomeIngrediente";
            this.lbl_nomeIngrediente.Size = new System.Drawing.Size(48, 20);
            this.lbl_nomeIngrediente.TabIndex = 0;
            this.lbl_nomeIngrediente.Text = "Nome";
            // 
            // button_adicionar
            // 
            this.button_adicionar.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_adicionar.Location = new System.Drawing.Point(426, 401);
            this.button_adicionar.Name = "button_adicionar";
            this.button_adicionar.Size = new System.Drawing.Size(526, 36);
            this.button_adicionar.TabIndex = 5;
            this.button_adicionar.Text = "Adicionar";
            this.button_adicionar.UseVisualStyleBackColor = true;
            this.button_adicionar.Click += new System.EventHandler(this.button_adicionar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome Receita";
            // 
            // textBox_IngredientesReceita
            // 
            this.textBox_IngredientesReceita.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_IngredientesReceita.Location = new System.Drawing.Point(159, 71);
            this.textBox_IngredientesReceita.Name = "textBox_IngredientesReceita";
            this.textBox_IngredientesReceita.Size = new System.Drawing.Size(793, 26);
            this.textBox_IngredientesReceita.TabIndex = 6;
            // 
            // listBox_Ingredientes
            // 
            this.listBox_Ingredientes.FormattingEnabled = true;
            this.listBox_Ingredientes.ItemHeight = 18;
            this.listBox_Ingredientes.Location = new System.Drawing.Point(13, 132);
            this.listBox_Ingredientes.Name = "listBox_Ingredientes";
            this.listBox_Ingredientes.Size = new System.Drawing.Size(389, 256);
            this.listBox_Ingredientes.TabIndex = 7;
            // 
            // Ingredientes_Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 449);
            this.Controls.Add(this.listBox_Ingredientes);
            this.Controls.Add(this.textBox_IngredientesReceita);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_adicionar);
            this.Controls.Add(this.groupBox_adicionarIngrientes);
            this.Controls.Add(this.button_eliminar);
            this.Controls.Add(this.lbl_Ingredientes);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Ingredientes_Editar";
            this.Text = "Ingredientes_Editar";
            this.Load += new System.EventHandler(this.Ingredientes_Editar_Load);
            this.groupBox_adicionarIngrientes.ResumeLayout(false);
            this.groupBox_adicionarIngrientes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Ingredientes;
        private System.Windows.Forms.Button button_eliminar;
        private System.Windows.Forms.GroupBox groupBox_adicionarIngrientes;
        private System.Windows.Forms.ComboBox comboBox_UnidadeMedida;
        private System.Windows.Forms.Label label_unidadeMedida;
        private System.Windows.Forms.Label lbl_quantidade;
        private System.Windows.Forms.Label lbl_nomeIngrediente;
        private System.Windows.Forms.Button button_adicionar;
        private System.Windows.Forms.TextBox textBox1_Quantidade;
        private System.Windows.Forms.ComboBox comboBox_Nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_IngredientesReceita;
        private System.Windows.Forms.ListBox listBox_Ingredientes;
    }
}