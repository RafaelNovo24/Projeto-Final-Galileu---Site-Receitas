using System;

namespace Projeto_II
{
    partial class GestaoUtilizadores
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
            this.components = new System.ComponentModel.Container();
            this.label_gestaoReceitasId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_info = new System.Windows.Forms.TextBox();
            this.button_gestaoUtilizador_RemoverUtilizador = new System.Windows.Forms.Button();
            this.comboBox_dadosUtilizador = new System.Windows.Forms.ComboBox();
            this.mostrarUtilizadoresRegistadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.utilizadorRegistadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mostrarUtilizadoresRegistadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizadorRegistadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label_gestaoReceitasId
            // 
            this.label_gestaoReceitasId.AutoSize = true;
            this.label_gestaoReceitasId.Location = new System.Drawing.Point(12, 15);
            this.label_gestaoReceitasId.Name = "label_gestaoReceitasId";
            this.label_gestaoReceitasId.Size = new System.Drawing.Size(162, 17);
            this.label_gestaoReceitasId.TabIndex = 2;
            this.label_gestaoReceitasId.Text = "Nome(Primeiro e Último)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dados";
            // 
            // textBox_info
            // 
            this.textBox_info.BackColor = System.Drawing.Color.Silver;
            this.textBox_info.Location = new System.Drawing.Point(83, 75);
            this.textBox_info.Multiline = true;
            this.textBox_info.Name = "textBox_info";
            this.textBox_info.ReadOnly = true;
            this.textBox_info.Size = new System.Drawing.Size(413, 209);
            this.textBox_info.TabIndex = 5;
            // 
            // button_gestaoUtilizador_RemoverUtilizador
            // 
            this.button_gestaoUtilizador_RemoverUtilizador.Location = new System.Drawing.Point(344, 322);
            this.button_gestaoUtilizador_RemoverUtilizador.Name = "button_gestaoUtilizador_RemoverUtilizador";
            this.button_gestaoUtilizador_RemoverUtilizador.Size = new System.Drawing.Size(152, 40);
            this.button_gestaoUtilizador_RemoverUtilizador.TabIndex = 6;
            this.button_gestaoUtilizador_RemoverUtilizador.Text = "Remover Utilizador";
            this.button_gestaoUtilizador_RemoverUtilizador.UseVisualStyleBackColor = true;
            this.button_gestaoUtilizador_RemoverUtilizador.Click += new System.EventHandler(this.button_gestaoUtilizador_RemoverUtilizador_Click);
            // 
            // comboBox_dadosUtilizador
            // 
            this.comboBox_dadosUtilizador.DataSource = this.mostrarUtilizadoresRegistadosBindingSource;
            this.comboBox_dadosUtilizador.DisplayMember = "Nome";
            this.comboBox_dadosUtilizador.FormattingEnabled = true;
            this.comboBox_dadosUtilizador.Location = new System.Drawing.Point(220, 15);
            this.comboBox_dadosUtilizador.Name = "comboBox_dadosUtilizador";
            this.comboBox_dadosUtilizador.Size = new System.Drawing.Size(252, 24);
            this.comboBox_dadosUtilizador.TabIndex = 8;
            this.comboBox_dadosUtilizador.ValueMember = "ID";
            this.comboBox_dadosUtilizador.SelectedIndexChanged += new System.EventHandler(this.comboBox_dadosUtilizador_SelectedIndexChanged);
            // 
            // mostrarUtilizadoresRegistadosBindingSource
            // 
            this.mostrarUtilizadoresRegistadosBindingSource.DataMember = "MostrarUtilizadoresRegistados";            // 
            // projetoDataSet1
            // 
            // 
            // utilizadorRegistadoBindingSource
            // 
            this.utilizadorRegistadoBindingSource.DataMember = "UtilizadorRegistado";
            // 
            // mostrarUtilizadoresRegistadosTableAdapter
            // 
            // 
            // GestaoUtilizadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 415);
            this.Controls.Add(this.comboBox_dadosUtilizador);
            this.Controls.Add(this.button_gestaoUtilizador_RemoverUtilizador);
            this.Controls.Add(this.textBox_info);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_gestaoReceitasId);
            this.Name = "GestaoUtilizadores";
            this.Text = "GestaoUtilizadores";
            this.Load += new System.EventHandler(this.GestaoUtilizadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mostrarUtilizadoresRegistadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizadorRegistadoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Label label_gestaoReceitasId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_info;
        private System.Windows.Forms.Button button_gestaoUtilizador_RemoverUtilizador;
        private System.Windows.Forms.ComboBox comboBox_dadosUtilizador;
        private System.Windows.Forms.BindingSource utilizadorRegistadoBindingSource;
        private System.Windows.Forms.BindingSource mostrarUtilizadoresRegistadosBindingSource;
    }
}