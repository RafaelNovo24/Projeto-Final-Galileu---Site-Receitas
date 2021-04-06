
namespace Projeto_II.WinForms
{
    partial class AdcionarIngrediente
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
            this.textBox_ingredienteInserido = new System.Windows.Forms.TextBox();
            this.label_ingrediente = new System.Windows.Forms.Label();
            this.button_aprovar = new System.Windows.Forms.Button();
            this.button_rejeitar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_ingredienteInserido
            // 
            this.textBox_ingredienteInserido.Location = new System.Drawing.Point(112, 45);
            this.textBox_ingredienteInserido.Name = "textBox_ingredienteInserido";
            this.textBox_ingredienteInserido.Size = new System.Drawing.Size(261, 22);
            this.textBox_ingredienteInserido.TabIndex = 0;
            // 
            // label_ingrediente
            // 
            this.label_ingrediente.AutoSize = true;
            this.label_ingrediente.Location = new System.Drawing.Point(12, 48);
            this.label_ingrediente.Name = "label_ingrediente";
            this.label_ingrediente.Size = new System.Drawing.Size(79, 17);
            this.label_ingrediente.TabIndex = 1;
            this.label_ingrediente.Text = "Ingrediente";
            // 
            // button_aprovar
            // 
            this.button_aprovar.Location = new System.Drawing.Point(88, 103);
            this.button_aprovar.Name = "button_aprovar";
            this.button_aprovar.Size = new System.Drawing.Size(81, 35);
            this.button_aprovar.TabIndex = 2;
            this.button_aprovar.Text = "Aprovar";
            this.button_aprovar.UseVisualStyleBackColor = true;
            // 
            // button_rejeitar
            // 
            this.button_rejeitar.Location = new System.Drawing.Point(240, 103);
            this.button_rejeitar.Name = "button_rejeitar";
            this.button_rejeitar.Size = new System.Drawing.Size(87, 35);
            this.button_rejeitar.TabIndex = 3;
            this.button_rejeitar.Text = "Rejeitar";
            this.button_rejeitar.UseVisualStyleBackColor = true;
            // 
            // AdcionarIgrediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 166);
            this.Controls.Add(this.button_rejeitar);
            this.Controls.Add(this.button_aprovar);
            this.Controls.Add(this.label_ingrediente);
            this.Controls.Add(this.textBox_ingredienteInserido);
            this.Name = "AdcionarIgrediente";
            this.Text = "AdcionarIgrediente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_ingredienteInserido;
        private System.Windows.Forms.Label label_ingrediente;
        private System.Windows.Forms.Button button_aprovar;
        private System.Windows.Forms.Button button_rejeitar;
    }
}