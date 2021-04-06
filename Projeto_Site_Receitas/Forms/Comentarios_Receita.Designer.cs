
namespace Projeto_Site_Receitas.Forms
{
    partial class Comentarios_Receita
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
            this.comboBox_listaComentario = new System.Windows.Forms.ComboBox();
            this.label_comentario = new System.Windows.Forms.Label();
            this.textBox_textoComentario = new System.Windows.Forms.TextBox();
            this.label_Receita = new System.Windows.Forms.Label();
            this.label_texto = new System.Windows.Forms.Label();
            this.button_Eliminar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_abrir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_listaComentario
            // 
            this.comboBox_listaComentario.FormattingEnabled = true;
            this.comboBox_listaComentario.Location = new System.Drawing.Point(28, 116);
            this.comboBox_listaComentario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_listaComentario.Name = "comboBox_listaComentario";
            this.comboBox_listaComentario.Size = new System.Drawing.Size(917, 28);
            this.comboBox_listaComentario.TabIndex = 1;
            // 
            // label_comentario
            // 
            this.label_comentario.AutoSize = true;
            this.label_comentario.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_comentario.Location = new System.Drawing.Point(24, 90);
            this.label_comentario.Name = "label_comentario";
            this.label_comentario.Size = new System.Drawing.Size(101, 24);
            this.label_comentario.TabIndex = 2;
            this.label_comentario.Text = "Comentário";
            // 
            // textBox_textoComentario
            // 
            this.textBox_textoComentario.Location = new System.Drawing.Point(134, 196);
            this.textBox_textoComentario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_textoComentario.Multiline = true;
            this.textBox_textoComentario.Name = "textBox_textoComentario";
            this.textBox_textoComentario.ReadOnly = true;
            this.textBox_textoComentario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_textoComentario.Size = new System.Drawing.Size(880, 166);
            this.textBox_textoComentario.TabIndex = 5;
            // 
            // label_Receita
            // 
            this.label_Receita.AutoSize = true;
            this.label_Receita.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Receita.Location = new System.Drawing.Point(22, 24);
            this.label_Receita.Name = "label_Receita";
            this.label_Receita.Size = new System.Drawing.Size(200, 33);
            this.label_Receita.TabIndex = 6;
            this.label_Receita.Text = "Nome da Receita";
            // 
            // label_texto
            // 
            this.label_texto.AutoSize = true;
            this.label_texto.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_texto.Location = new System.Drawing.Point(48, 196);
            this.label_texto.Name = "label_texto";
            this.label_texto.Size = new System.Drawing.Size(60, 24);
            this.label_texto.TabIndex = 7;
            this.label_texto.Text = "Texto";
            // 
            // button_Eliminar
            // 
            this.button_Eliminar.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Eliminar.Location = new System.Drawing.Point(648, 385);
            this.button_Eliminar.Name = "button_Eliminar";
            this.button_Eliminar.Size = new System.Drawing.Size(366, 39);
            this.button_Eliminar.TabIndex = 9;
            this.button_Eliminar.Text = "Eliminar Comentário";
            this.button_Eliminar.UseVisualStyleBackColor = true;
            this.button_Eliminar.Click += new System.EventHandler(this.button_Eliminar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_abrir);
            this.groupBox1.Controls.Add(this.label_Receita);
            this.groupBox1.Controls.Add(this.label_comentario);
            this.groupBox1.Controls.Add(this.comboBox_listaComentario);
            this.groupBox1.Location = new System.Drawing.Point(41, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(973, 168);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // button_abrir
            // 
            this.button_abrir.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_abrir.Location = new System.Drawing.Point(626, 78);
            this.button_abrir.Name = "button_abrir";
            this.button_abrir.Size = new System.Drawing.Size(319, 32);
            this.button_abrir.TabIndex = 11;
            this.button_abrir.Text = "Abrir";
            this.button_abrir.UseVisualStyleBackColor = true;
            this.button_abrir.Click += new System.EventHandler(this.button_abrir_Click);
            // 
            // Comentarios_Receita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1052, 503);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Eliminar);
            this.Controls.Add(this.label_texto);
            this.Controls.Add(this.textBox_textoComentario);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Comentarios_Receita";
            this.Text = "Comentários";
            this.Load += new System.EventHandler(this.Comentarios_Receita_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox_listaComentario;
        private System.Windows.Forms.Label label_comentario;
        private System.Windows.Forms.TextBox textBox_textoComentario;
        private System.Windows.Forms.Label label_Receita;
        private System.Windows.Forms.Label label_texto;
        private System.Windows.Forms.Button button_Eliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_abrir;
    }
}