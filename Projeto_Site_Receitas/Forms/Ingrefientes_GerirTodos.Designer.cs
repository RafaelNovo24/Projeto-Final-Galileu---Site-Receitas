
namespace Projeto_Site_Receitas.Forms
{
    partial class Ingrefientes_GerirTodos
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBox_Nome = new System.Windows.Forms.TextBox();
            this.label_Ingridiente_ADD = new System.Windows.Forms.Label();
            this.groupBox_Eliminar = new System.Windows.Forms.GroupBox();
            this.label_eliminar = new System.Windows.Forms.Label();
            this.button_eliminar = new System.Windows.Forms.Button();
            this.listBox_Ingredientes = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox_Eliminar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Todos os Ingredientes";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(246, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(317, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBox_Nome);
            this.groupBox1.Controls.Add(this.label_Ingridiente_ADD);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(417, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 194);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adicionar Ingrediente";
            // 
            // txtBox_Nome
            // 
            this.txtBox_Nome.Location = new System.Drawing.Point(112, 70);
            this.txtBox_Nome.Name = "txtBox_Nome";
            this.txtBox_Nome.Size = new System.Drawing.Size(461, 35);
            this.txtBox_Nome.TabIndex = 6;
            // 
            // label_Ingridiente_ADD
            // 
            this.label_Ingridiente_ADD.AutoSize = true;
            this.label_Ingridiente_ADD.Location = new System.Drawing.Point(20, 77);
            this.label_Ingridiente_ADD.Name = "label_Ingridiente_ADD";
            this.label_Ingridiente_ADD.Size = new System.Drawing.Size(65, 28);
            this.label_Ingridiente_ADD.TabIndex = 5;
            this.label_Ingridiente_ADD.Text = "Nome";
            // 
            // groupBox_Eliminar
            // 
            this.groupBox_Eliminar.Controls.Add(this.label_eliminar);
            this.groupBox_Eliminar.Controls.Add(this.button_eliminar);
            this.groupBox_Eliminar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Eliminar.Location = new System.Drawing.Point(417, 322);
            this.groupBox_Eliminar.Name = "groupBox_Eliminar";
            this.groupBox_Eliminar.Size = new System.Drawing.Size(604, 161);
            this.groupBox_Eliminar.TabIndex = 7;
            this.groupBox_Eliminar.TabStop = false;
            this.groupBox_Eliminar.Text = "Eliminar Ingrediente";
            // 
            // label_eliminar
            // 
            this.label_eliminar.AutoSize = true;
            this.label_eliminar.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_eliminar.Location = new System.Drawing.Point(21, 55);
            this.label_eliminar.Name = "label_eliminar";
            this.label_eliminar.Size = new System.Drawing.Size(341, 20);
            this.label_eliminar.TabIndex = 5;
            this.label_eliminar.Text = "Elimina itens selecionados de forma permanente.";
            // 
            // button_eliminar
            // 
            this.button_eliminar.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_eliminar.Location = new System.Drawing.Point(246, 100);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(317, 33);
            this.button_eliminar.TabIndex = 4;
            this.button_eliminar.Text = "Eliminar";
            this.button_eliminar.UseVisualStyleBackColor = true;
            this.button_eliminar.Click += new System.EventHandler(this.button_eliminar_Click);
            // 
            // listBox_Ingredientes
            // 
            this.listBox_Ingredientes.FormattingEnabled = true;
            this.listBox_Ingredientes.ItemHeight = 18;
            this.listBox_Ingredientes.Location = new System.Drawing.Point(29, 70);
            this.listBox_Ingredientes.Name = "listBox_Ingredientes";
            this.listBox_Ingredientes.Size = new System.Drawing.Size(369, 418);
            this.listBox_Ingredientes.TabIndex = 8;
            // 
            // Ingrefientes_GerirTodos
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1042, 500);
            this.Controls.Add(this.listBox_Ingredientes);
            this.Controls.Add(this.groupBox_Eliminar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Ingrefientes_GerirTodos";
            this.Text = "Ingrefientes_GerirTodos";
            this.Load += new System.EventHandler(this.Ingrefientes_GerirTodos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_Eliminar.ResumeLayout(false);
            this.groupBox_Eliminar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBox_Nome;
        private System.Windows.Forms.Label label_Ingridiente_ADD;
        private System.Windows.Forms.GroupBox groupBox_Eliminar;
        private System.Windows.Forms.Label label_eliminar;
        private System.Windows.Forms.Button button_eliminar;
        private System.Windows.Forms.ListBox listBox_Ingredientes;
    }
}