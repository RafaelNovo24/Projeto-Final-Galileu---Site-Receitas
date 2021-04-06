using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_Site_Receitas.Forms;

namespace Projeto_Site_Receitas.Forms
{
    public partial class Menu_Inicial : Form
    {
        public Menu_Inicial()
        {
            InitializeComponent();
        }

        private void pendentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "ReceitasPendentes")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (isopen == false)
            {
                ReceitasPendentes rPend = new ReceitasPendentes();
                rPend.Show();
                rPend.BringToFront();
            }
        }

        private void listarTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "Ingrefientes_GerirTodos")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (isopen == false)
            {
                Ingrefientes_GerirTodos formGerirIngredientes = new Ingrefientes_GerirTodos();
                formGerirIngredientes.Show();
                formGerirIngredientes.BringToFront();
            }
        }

        private void aprovadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "ReceitasAprovadas")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (isopen == false)
            {
                ReceitasAprovadas receitasAprovadas = new ReceitasAprovadas();
                receitasAprovadas.Show();
                receitasAprovadas.BringToFront();
            }
        }

        private void comentáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "Comentarios_Todos")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (isopen == false)
            {
                Comentarios_Todos comTodos = new Comentarios_Todos();
                comTodos.Show();
                comTodos.BringToFront();
            }
        }

        private void utilizadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "Users")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (isopen == false)
            {
                Users user = new Users();
                user.Show();
                user.BringToFront();
            }
        }
    }
}
