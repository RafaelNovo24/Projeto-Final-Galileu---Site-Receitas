using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_Receitas;

namespace Projeto_Site_Receitas.Forms
{
    public partial class Ingrefientes_GerirTodos : Form
    {
        public Ingrefientes_GerirTodos()
        {
            InitializeComponent();
        }

        Ingrediente ing = new Ingrediente();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(txtBox_Nome.Text))
                {
                    MessageBox.Show("Por favor insira o nome do ingrediente.");
                }
                else
                {
                    if (ing.Inserir(txtBox_Nome.Text))
                    {
                        MessageBox.Show("Ingrediente inserido com sucesso!");
                    }
                    Atualizar();
                }
                txtBox_Nome.Text = String.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir! Tenha atenção:" + Environment.NewLine + ex.Message);
            }
        }

        private void Ingrefientes_GerirTodos_Load(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void button_eliminar_Click(object sender, EventArgs e)
        {
            if (listBox_Ingredientes.SelectedIndex > -1)
            {
                DialogResult dialogo = MessageBox.Show("Tem a certeza que quer eliminar definitivamente este ingrediente?",
                    "Remover Ingrediente", MessageBoxButtons.YesNo);
                if (dialogo == DialogResult.Yes)
                {
                    Ingrediente ingrediente = new Ingrediente((int)listBox_Ingredientes.SelectedValue);
                    ing.Remover(ingrediente.IdIngrediente);
                }
                Atualizar();
            }
            else
            {
                MessageBox.Show("Seleccione um ingrediente para remover", "Sem selecção");
            }
        }

        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            Atualizar();
        }

        public void Atualizar()
        {
            listBox_Ingredientes.ValueMember = "IdIngrediente";
            listBox_Ingredientes.DisplayMember = "NomeIngrediente";
            listBox_Ingredientes.DataSource = Ingrediente.TodosIngredientes();
        }
    }
}
