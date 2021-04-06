
namespace Projeto_Site_Receitas.Forms
{
    partial class Menu_Inicial
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.receitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pendentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aprovadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingredientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarTodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilizadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comentáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lbltexto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.receitasToolStripMenuItem,
            this.ingredientesToolStripMenuItem,
            this.utilizadoresToolStripMenuItem,
            this.comentáriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1000, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // receitasToolStripMenuItem
            // 
            this.receitasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pendentesToolStripMenuItem,
            this.aprovadasToolStripMenuItem});
            this.receitasToolStripMenuItem.Name = "receitasToolStripMenuItem";
            this.receitasToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.receitasToolStripMenuItem.Text = "Receitas";
            // 
            // pendentesToolStripMenuItem
            // 
            this.pendentesToolStripMenuItem.Name = "pendentesToolStripMenuItem";
            this.pendentesToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.pendentesToolStripMenuItem.Text = "Pendentes";
            this.pendentesToolStripMenuItem.Click += new System.EventHandler(this.pendentesToolStripMenuItem_Click);
            // 
            // aprovadasToolStripMenuItem
            // 
            this.aprovadasToolStripMenuItem.Name = "aprovadasToolStripMenuItem";
            this.aprovadasToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.aprovadasToolStripMenuItem.Text = "Aprovadas";
            this.aprovadasToolStripMenuItem.Click += new System.EventHandler(this.aprovadasToolStripMenuItem_Click);
            // 
            // ingredientesToolStripMenuItem
            // 
            this.ingredientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarTodosToolStripMenuItem});
            this.ingredientesToolStripMenuItem.Name = "ingredientesToolStripMenuItem";
            this.ingredientesToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.ingredientesToolStripMenuItem.Text = "Ingredientes";
            // 
            // listarTodosToolStripMenuItem
            // 
            this.listarTodosToolStripMenuItem.Name = "listarTodosToolStripMenuItem";
            this.listarTodosToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.listarTodosToolStripMenuItem.Text = "Listar Todos";
            this.listarTodosToolStripMenuItem.Click += new System.EventHandler(this.listarTodosToolStripMenuItem_Click);
            // 
            // utilizadoresToolStripMenuItem
            // 
            this.utilizadoresToolStripMenuItem.Name = "utilizadoresToolStripMenuItem";
            this.utilizadoresToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.utilizadoresToolStripMenuItem.Text = "Utilizadores";
            this.utilizadoresToolStripMenuItem.Click += new System.EventHandler(this.utilizadoresToolStripMenuItem_Click);
            // 
            // comentáriosToolStripMenuItem
            // 
            this.comentáriosToolStripMenuItem.Name = "comentáriosToolStripMenuItem";
            this.comentáriosToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.comentáriosToolStripMenuItem.Text = "Comentários";
            this.comentáriosToolStripMenuItem.Click += new System.EventHandler(this.comentáriosToolStripMenuItem_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblTitulo.Location = new System.Drawing.Point(41, 54);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(162, 39);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Bem vindo !";
            // 
            // lbltexto
            // 
            this.lbltexto.AutoSize = true;
            this.lbltexto.Location = new System.Drawing.Point(44, 116);
            this.lbltexto.Name = "lbltexto";
            this.lbltexto.Size = new System.Drawing.Size(468, 24);
            this.lbltexto.TabIndex = 2;
            this.lbltexto.Text = "Esta aplicação serve para gerir o Backoffice do seu site! ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(667, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Aqui poderá gerir receitas, Ingredientes , Utilizadores e até mesmo Comentários! " +
    "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(432, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Terá todo o poder a um click de distância, aproveite!";
            // 
            // Menu_Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 346);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbltexto);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu_Inicial";
            this.Text = "Menu Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem receitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pendentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aprovadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingredientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarTodosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilizadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comentáriosToolStripMenuItem;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lbltexto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}